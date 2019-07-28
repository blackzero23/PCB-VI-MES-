using System;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //서브 컨테이너에 띄울 폼 함수.
        private void OpenForm(object subForm)
        {
            if(this.panelContainer.Controls.Count>0)
                this.panelContainer.Controls.RemoveAt(0);

            Form sf = subForm as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.Show();
        }

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
            this.WindowState = FormWindowState.Maximized;
            ptbMin.Visible = true;
            ptbMax.Visible = false;
        }
        //폼 이전 크기로  함수
        private void PtbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbMin.Visible = false;
            ptbMax.Visible = true;
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

        #endregion


    }
}
