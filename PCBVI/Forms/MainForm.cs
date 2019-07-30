using System;
using System.Drawing;
//폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PCBVI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
        //DllImport(c 나 c++로 작성된 네이티브 DLL에 있는 함수를 호출할때 사용하는 에트리뷰트)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //서브 컨테이너에 띄울 폼 함수.
        private void OpenForm(object subForm)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form sf = subForm as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.Show();
        }
        //폼 크기 마음대로 조절할수있게 해주기위한 변수.
        int LX, LY;


        //폼 최소화 함수
        private void PtbMinimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //폼 종료 함수
        private void PtbCnacle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //폼 최대화 함수
        private void PtbMax_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.WindowState = FormWindowState.Maximized;
            ptbMin.Visible = true;
            ptbMax.Visible = false;
        }
        //폼 이전 크기로  함수
        private void PtbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ////크기를 최대화 했다가 다시 돌아올때 위치 저장.
            //this.Size = new Size(1120, 570);
            //this.Location = new Point(LX, LY);
            ptbMin.Visible = false;
            ptbMax.Visible = true;
        }

        //전체 폼 크기 조절
        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84;
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size AreaForm = ClientSize;
                if (CoordenadaArea.X >= AreaForm.Width - 16 && CoordenadaArea.Y >= AreaForm.Height - 16 && AreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }


        //메인 폼 움직일수 있게해주는 함수.
        private void PanelMainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region MenuBarClickEventHandler
        //왼쪽 메뉴 이벤트 핸들러 정의.
        private void UscMenuBar_EmployeeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.EmployeeButtonClickedEventArgs e)
        {
            OpenForm(e.Employee);
        }

        private void UscMenuBar_SubjectButtonClicked(object sender, Controls.MainControls.MainMenulistControl.SubjectButtonClickedEventArgs e)
        {
            OpenForm(e.Subject);
        }
        private void UscMenuBar_BarcodeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.BarcodeButtonClickedEventArgs e)
        {
            OpenForm(e.Barcode);
        }

        private void UscMenuBar_DefectiveProductButtonClicked(object sender, Controls.MainControls.MainMenulistControl.DefectiveProductButtonClickedEventArgs e)
        {
            OpenForm(e.DefectiveProduct);
        }

        private void UscMenuBar_EquipmentButtonClicked(object sender, Controls.MainControls.MainMenulistControl.EquipmentButtonClickedEventArgs e)
        {
            OpenForm(e.Equipment);
        }

        private void UscMenuBar_ErrorCodeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ErrorCodeButtonClickedEventArgs e)
        {
            OpenForm(e.ErrorCode);
        }

        private void UscMenuBar_InspectionStButtonClicked(object sender, Controls.MainControls.MainMenulistControl.InspectionStButtonClickedEventArgs e)
        {
            OpenForm(e.InspectionSt);
        }

        private void UscMenuBar_MaterialManageButtonClicked(object sender, Controls.MainControls.MainMenulistControl.MaterialManageButtonClickedEventArgs e)
        {
            OpenForm(e.MaterialManage);
        }

        private void UscMenuBar_ProcessDefectButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProcessDefectButtonClickedEventArgs e)
        {
            OpenForm(e.ProcessDefect);
        }

        private void UscMenuBar_ProductionHistoryButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProductionHistoryButtonClickedEventArgs e)
        {
            OpenForm(e.ProductionHistory);
        }

        private void UscMenuBar_WorkerButtonClicked(object sender, Controls.MainControls.MainMenulistControl.WorkerButtonClickedEventArgs e)
        {
            OpenForm(e.Worker);
        }

        private void UscMenuBar_WorkLogButtonClicked(object sender, Controls.MainControls.MainMenulistControl.WorkLogButtonClickedEventArgs e)
        {
            OpenForm(e.WorkLog);
        }

        private void UscMenuBar_NonMovingTypeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.NonMovingTypeButtonClickedEventArgs e)
        {
            OpenForm(e.NonMovingType);
        }

        private void UscMenuBar_ErrorStatisticsButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ErrorStatisticsButtonClickedEventArgs e)
        {
            OpenForm(e.ErrorStatistics);
        }

        private void UscMenuBar_FacilitiesButtonClicked(object sender, Controls.MainControls.MainMenulistControl.FacilitiesButtonClickedEventArgs e)
        {
            OpenForm(e.Facilities);
        }

        private void UscMenuBar_FacilitiesErrorButtonClicked(object sender, Controls.MainControls.MainMenulistControl.FacilitiesErrorButtonClickedEventArgs e)
        {
            OpenForm(e.FacilitiesError);
        }

        private void UscMenuBar_FacilitiesHistoryButtonClicked(object sender, Controls.MainControls.MainMenulistControl.FacilitiesHistoryButtonClickedEventArgs e)
        {
            OpenForm(e.FacilitiesHistory);
        }

        private void UscMenuBar_FacilitiesPowerButtonClicked(object sender, Controls.MainControls.MainMenulistControl.FacilitiesPowerButtonClickedEventArgs e)
        {
            OpenForm(e.FacilitiesPower);
        }

        private void UscMenuBar_FirstInspectionButtonClicked(object sender, Controls.MainControls.MainMenulistControl.FirstInspectionButtonClickedEventArgs e)
        {
            OpenForm(e.FirstInspection);
        }

        private void UscMenuBar_LastInspectionButtonClicked(object sender, Controls.MainControls.MainMenulistControl.LastInspectionButtonClickedEventArgs e)
        {
            OpenForm(e.LastInspection);
        }

        private void UscMenuBar_MaterialsHistoryButtonClicked(object sender, Controls.MainControls.MainMenulistControl.MaterialsHistoryButtonClickedEventArgs e)
        {
            OpenForm(e.MaterialsHistory);
        }

        private void UscMenuBar_MaterialsInOutButtonClicked(object sender, Controls.MainControls.MainMenulistControl.MaterialsInOutButtonClickedEventArgs e)
        {
            OpenForm(e.MeterialsInOut);
        }

        private void UscMenuBar_MaterialsInReButtonClicked(object sender, Controls.MainControls.MainMenulistControl.MaterialsInReButtonClickedEventArgs e)
        {
            OpenForm(e.MaterialsInRe);
        }

        private void UscMenuBar_PPMonitoringButtonClicked(object sender, Controls.MainControls.MainMenulistControl.PPMonitoringButtonClickedEventArgs e)
        {
            OpenForm(e.PPMonitoring);
        }

        private void UscMenuBar_PPStatisticsButtonClicked(object sender, Controls.MainControls.MainMenulistControl.PPStatisticsButtonClickedEventArgs e)
        {
            OpenForm(e.PPStatistics);
        }

        private void UscMenuBar_ProcessInspectionButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProcessInspectionButtonClickedEventArgs e)
        {
            OpenForm(e.ProcessInspection);
        }

        private void UscMenuBar_PSMonitoringButtonClicked(object sender, Controls.MainControls.MainMenulistControl.PSMonitoringButtonClickedEventArgs e)
        {
            OpenForm(e.PSMonitoring);
        }

        private void UscMenuBar_QualityButtonClicked(object sender, Controls.MainControls.MainMenulistControl.QualityButtonClickedEventArgs e)
        {
            OpenForm(e.Quality);
        }

        private void UscMenuBar_StockStatisticsButtonClicked(object sender, Controls.MainControls.MainMenulistControl.StockStatisticsButtonClickedEventArgs e)
        {
            OpenForm(e.StockStatistics);
        }


        #endregion


    }
}
