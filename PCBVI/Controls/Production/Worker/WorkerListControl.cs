﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;
using PCBVI.Data;
using System.Net.Sockets;

namespace PCBVI.Controls.Production.Worker
{
    public partial class WorkerListControl : UserControl
    {
        public WorkerListControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }

        

        private void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsRotationGroup.DataSource = DB.RotationGroup.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
            bdsFacilities.DataSource = DB.Facilities.GetAll();
            //오늘 작업 목록 만 들고오기.
            bdsWorkOrder.DataSource = DB.WorkOrder.TodayWorkerListALL();
        }



        public void SetDataSource(List<Data.WorkOrder> list)
        {
            dgvList.DataSource = list;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //작업 시작을 누르면 작업일지에 등록이 되고 설비가 돌아가야된다.
            int connectionTryCnt = 0;

            TcpClient tc = new TcpClient();
            while (!tc.Connected)
            {
                try
                {
                    tc.Connect("192.168.0.2", 50005);
                }
                catch (Exception)
                {
                    connectionTryCnt++;
                }

                if (connectionTryCnt > 5)
                {
                    MessageBox.Show("기기에 연결할 수 없습니다.");
                    return;
                }
            }

            NetworkStream stream = tc.GetStream();

            byte[] buffer = Encoding.ASCII.GetBytes("start");
            stream.Write(buffer, 0, buffer.Length);

            stream.Close();
            tc.Close();
            tc.Dispose();

            //빈칸 체크

            if (string.IsNullOrWhiteSpace(txbWorker.Text))
            {
                MessageBox.Show("작업자를 입력 해 주세요.");
                return;
            }

            //이미 시작하고있는지 없는지 체크
            Data.WorkOrder workOrder = dgvList.CurrentRow.DataBoundItem as Data.WorkOrder;

            if (DB.WorkLog.HasWorkOrderId(workOrder.WorkOrderId))
            {
                MessageBox.Show("해당 시설은 이미 작업 시작중입니다.");
                return;
            }

            

            //시작하지 않았으면 작업일보 작성 등록.
            SetStartWorkLog(workOrder);
            //수정
            workOrder.WorkerName = txbWorker.Text;
            DB.WorkOrder.Update(workOrder);
            dgvList.DataSource = DB.WorkOrder.TodayWorkerListALL();
        }



        private void SetStartWorkLog(Data.WorkOrder workOrder)
        {
            Data.WorkLog workLog = new Data.WorkLog();

            //nullable 형태에서 다시 평범한 int 형태로 넘길때 쓰는 구문.
            //v2 = v1 == null ? default(int) : v1;
            //v2 = v1.GetValueOrDefault();

            workLog.RotationGroupId = workOrder.RotationGroupId.GetValueOrDefault();
            workLog.WorkDate = DateTime.Today;
            workLog.SartTime = DateTime.Now;
            workLog.TargetQuantity = workOrder.TargetQuantity;
            workLog.ProcessId = workOrder.ProcessId.GetValueOrDefault();
            workLog.WorkOrderId = workOrder.WorkOrderId;
            workLog.ItemId = workOrder.ItemId.GetValueOrDefault();
            workLog.FacilitiesId = workOrder.FacilitiesId.GetValueOrDefault();
            workLog.WorkerName = txbWorker.Text;

            //등록
            DB.WorkLog.Insert(workLog);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //작업종료를 누르면 해당 설비가 멈추고 작업 일보 작성
            int connectionTryCnt = 0;
            TcpClient tc = new TcpClient();
            while (!tc.Connected)
            {
                try
                {
                    tc.Connect("192.168.0.2", 50005);
                }
                catch (Exception)
                {
                    connectionTryCnt++;
                }

                if (connectionTryCnt > 5)
                {
                    MessageBox.Show("기기에 연결할 수 없습니다.");
                    return;
                }
            }

            NetworkStream stream = tc.GetStream();

            byte[] buffer = new byte[1024];
            byte[] integerbuffer = new byte[4];
            buffer = Encoding.ASCII.GetBytes("end");
            stream.Write(buffer, 0, buffer.Length);

            stream.Read(integerbuffer, 0, integerbuffer.Length);
            int pass = BitConverter.ToInt32(integerbuffer, 0);

            stream.Read(integerbuffer, 0, integerbuffer.Length);


            int fail = BitConverter.ToInt32(integerbuffer, 0);


            stream.Close();
            tc.Close();
            tc.Dispose();

            //MessageBox.Show($"{pass}Pass + {fail}Fail = {pass + fail}Total");

            //통신을 통해서 라즈베리파이에서 시간과 생산수량 불량 수량을 넣을수 있는지 체크 
            //아니면 새창을 통해서 직접작성 하도록.
            try
            {
                //해당 시설이 작업중인지 체크
                // Data.WorkOrder workOrder = dgvList.CurrentRow.DataBoundItem as Data.WorkOrder;
                Data.WorkOrder workOrder = dgvList.CurrentRow.DataBoundItem as Data.WorkOrder;

                if (DB.WorkLog.HasWorkOrderId(workOrder.WorkOrderId) == false)
                {
                    MessageBox.Show("해당 시설은 가동중이지 않습니다.");
                    return;
                }

                if (DB.WorkLog.IsOver(workOrder.WorkOrderId))
                {
                    MessageBox.Show("해당 시설은 이미 작업이 종료 되었습니다.");
                    return;
                }
                


                //작업일보 종료된 데이터 작성.
                
                SetEndWorkLog(workOrder, pass, fail);

                //생산 이력 작성.
                //작업일,공정,품목,양품,불량품,시작시간,종료시간
                SetProductionHistory(workOrder);

                //설비 가동 / 비가동 작성.
                SetFacilitiesPower(workOrder);

                MessageBox.Show("작업종료");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("작업을 선택 해 주세요.");
            }






            //설비 가동 / 비가동 작성.
            //공정명, 설비명, 작업일, 총작업시간
            //생산그룹이 3개 라고 가정. 해당 생산일에 해당 공정, 품목 명에
            //작업시작 시간은 최소 시간.
            //작업종료 시간은 마지막 종료 시간 업데이트.
            //해당 설비,공정,품목, 날짜가 있는지 없는지 먼저검색.
            //있다면 업데이트
            //업데이트는 +종료시간 + 양품수량 + 불량수량
            //없다면 등록.
        }

        private void SetEndWorkLog(Data.WorkOrder workOrder,int passQuantity, int errorQuantity)
        {
            //작업일보에서 작업지시id로 등록된 일보를 불러온다.
            Data.WorkLog workLog = DB.WorkLog.SearhWorkDateFirst(workOrder.WorkOrderId);
            //일단 임시 값을 넘기는걸로 종료는 현재 시각, 생산량 : 10 불량 : 10

            workLog.EndTime = DateTime.Now;
            workLog.ProductionQuantity = passQuantity;
            workLog.ErrorQuantity = errorQuantity;

            DB.WorkLog.Update((workLog));
        }

        private void SetFacilitiesPower(Data.WorkOrder workOrder)
        {
            //공정명, 설비명, 작업일, 총작업시간
            DateTime workOrderDate = DateTime.Today;
            int facilitiesId = workOrder.FacilitiesId.GetValueOrDefault();
            int processId = workOrder.ProcessId.GetValueOrDefault();
            int itemId = workOrder.ItemId.GetValueOrDefault();

            //해당일 의 공정명 설비명 에 해당하는 가동 비가동 테이블에 해당 이 없으면 만들어야된다.
            FacilitiesPower facilitiesPower = DB.FacilitiesPower.SearchDateInfo(workOrderDate, processId, facilitiesId);


            //생산그룹이 3개 라고 가정. 해당 생산일에 해당 공정, 품목 명에
            //해당 일자, 공정, 설비,품목에 해당하는 설비이력리스트를 가지고온다.
            var productHistoryList = DB.ProductionHistory.GetWorkList(workOrderDate, facilitiesId, processId, itemId);

            //작업시작 시간은 최소 시간.
            //작업종료 시간은 마지막 종료 시간 업데이트.
            //해당 설비,공정,품목, 날짜가 있는지 없는지 먼저검색.
            //있다면 업데이트
            //업데이트는 +종료시간 + 양품수량 + 불량수량
            //없다면 등록.

            //없다면 등록.
            if (facilitiesPower == null)
            {
                facilitiesPower = new FacilitiesPower();
                facilitiesPower.ProcessId = processId;
                facilitiesPower.FacilitiesId = facilitiesId;
                facilitiesPower.WorkDate = workOrderDate;

                TimeSpan ts;

                //최초시간
                DateTime start = productHistoryList.Select(x => x.StartTime).Min();

                //마지막시간
                DateTime end = productHistoryList.Select(x => x.EndTime).Max();

                ts = end - start;

                //에러 나것지.
                facilitiesPower.WorkTime = ts;

                DB.FacilitiesPower.Insert(facilitiesPower);

            }
            else
            {
                //있다면 업데이트

                TimeSpan ts;

                //최초시간
                DateTime start = productHistoryList.Select(x => x.StartTime).Min();

                //마지막시간
                DateTime end = productHistoryList.Select(x => x.EndTime).Max();

                ts = end - start;
                facilitiesPower.WorkTime = ts;

                DB.FacilitiesPower.Update(facilitiesPower);
            }



        }

        private void SetProductionHistory(Data.WorkOrder workOrder)
        {

            DateTime workOrderDate = workOrder.OrderDate;
            int facilitiesId = workOrder.FacilitiesId.GetValueOrDefault();
            int processId = workOrder.ProcessId.GetValueOrDefault();
            int itemId = workOrder.ItemId.GetValueOrDefault();

            //해당 생산일,설비,공정,품목,가 있는지 없는지 먼저검색.
            var productionHistory = DB.ProductionHistory.DuplicateCheck(workOrderDate, facilitiesId, processId, itemId);
            //없다면 등록.
            //해당 작업지시로 등록된 작업일지를 찾아온다.
            Data.WorkLog workLog = DB.WorkLog.SearhWorkDateFirst(workOrder.WorkOrderId);
            if (productionHistory == null)
            {
                //그 작업일지의 기준으로 새로은 이력서 작성.
                //작업일,공정,품목,양품,불량품,시작시간,종료시간
                productionHistory = new Data.ProductionHistory();
                productionHistory.ProductionDate = workLog.WorkDate.Date;
                productionHistory.ProcessId = workLog.ProcessId.GetValueOrDefault();
                productionHistory.ItemId = workLog.ItemId.GetValueOrDefault();
                productionHistory.PassQuantity = workLog.ProductionQuantity.GetValueOrDefault();
                productionHistory.ErrorQuantity = workLog.ErrorQuantity.GetValueOrDefault();
                productionHistory.StartTime = workLog.SartTime;
                productionHistory.EndTime = workLog.EndTime.GetValueOrDefault();
                productionHistory.FacilitiesId = workLog.FacilitiesId.GetValueOrDefault();

                DB.ProductionHistory.Insert(productionHistory);
            }
            else
            {
                //있다면 업데이트
                //업데이트는 +종료시간 + 양품수량 + 불량수량
                productionHistory.EndTime = workLog.EndTime.GetValueOrDefault();
                productionHistory.PassQuantity += workLog.ProductionQuantity.GetValueOrDefault();
                productionHistory.ErrorQuantity += workLog.ProductionQuantity.GetValueOrDefault();

                DB.ProductionHistory.Update(productionHistory);
            }


        }

    }
}
