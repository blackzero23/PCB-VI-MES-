﻿using ComponentFactory.Krypton.Toolkit;
using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Production
{
    public partial class WorkOrderInsertForm : KryptonForm
    {
        public WorkOrderInsertForm()
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
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            //품목, 공정 , 설비, 날짜, 근무조, 목표수량, 작업장
            ///품목
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("품목"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("폼목을 선택해주세요.");
                    e.Cancel = true;
                }
            }
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("공정"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("공정을 선택해주세요.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("근무조"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("근무조를 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("목표수량"))
            {
                int tryinteeger;

                if (int.TryParse(e.FormattedValue.ToString(), out tryinteeger) == false)
                {
                    MessageBox.Show("숫자만 입력해주세요.");
                    e.Cancel = true;
                }
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            ////품목, 공정 , 설비, 날짜, 근무조, 목표수량, 작업장
            if (dgvList.Rows.Count > 0)
            {
                Data.WorkOrder workOrder = dgvList.Rows[0].DataBoundItem as Data.WorkOrder;
             
                if (workOrder != null)
                {
                  
                    //DB 상에서는 NULL 허용이 안되지만
                    //Entity Frame에서 Nullable 형태로 변경하였기때문에
                    //초기값이 Null이 온다.
                    if (workOrder == null || workOrder.ItemId == null || workOrder.ProcessId == null
                        ||  workOrder.RotationGroupId == null
                        || workOrder.TargetQuantity == 0)
                    {
                        MessageBox.Show("등록 할 수있는 작업 지시가 없습니다.");
                        return;
                    }
                }
            }

            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.WorkOrder workOrder = dr.DataBoundItem as Data.WorkOrder;

                if (workOrder == null || workOrder.ItemId == null || workOrder.ProcessId == null
                    || workOrder.RotationGroupId == null
                    || workOrder.TargetQuantity == 0 )
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                workOrder.OrderDate = DateTime.Today;

                //설비 ,공정명,품목명,날짜,근무조.
                Data.WorkOrder SearchOrder =
                    DB.WorkOrder.DuplicateCheck(workOrder.FacilitiesId.GetValueOrDefault(), workOrder.ProcessId.GetValueOrDefault()
                        ,  workOrder.OrderDate, workOrder.RotationGroupId.GetValueOrDefault());
                if (SearchOrder != null)
                {
                    MessageBox.Show($"중복된 지시 입니다.");
                    return;
                }

                DB.WorkOrder.Insert(workOrder);

            }
        }
    }
}

