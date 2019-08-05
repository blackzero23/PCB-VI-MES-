using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PCBVI.Forms.Main
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

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

        #region Left MenuBar EventHendlers
        //왼쪽 메뉴바 이벤트 핸들러 함수들
        private void UscMenuBar_BarcodeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.BarcodeButtonClickedEventArgs e)
        {
            OpenForm(e.Barcode);
        }

        private void UscMenuBar_DefectiveProductButtonClicked(object sender, Controls.MainControls.MainMenulistControl.DefectiveProductButtonClickedEventArgs e)
        {
            OpenForm(e.DefectiveProduct);
        }

        private void UscMenuBar_EmployeeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.EmployeeButtonClickedEventArgs e)
        {
            OpenForm(e.Employee);
        }

        private void UscMenuBar_EquipmentButtonClicked(object sender, Controls.MainControls.MainMenulistControl.EquipmentButtonClickedEventArgs e)
        {
            OpenForm(e.Equipment);
        }

        private void UscMenuBar_ErrorCodeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ErrorCodeButtonClickedEventArgs e)
        {
            OpenForm(e.ErrorCode);
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

        private void UscMenuBar_InspectionStButtonClicked(object sender, Controls.MainControls.MainMenulistControl.InspectionStButtonClickedEventArgs e)
        {
            OpenForm(e.InspectionSt);
        }

        private void UscMenuBar_LastInspectionButtonClicked(object sender, Controls.MainControls.MainMenulistControl.LastInspectionButtonClickedEventArgs e)
        {
            OpenForm(e.LastInspection);
        }

        private void UscMenuBar_MaterialManageButtonClicked(object sender, Controls.MainControls.MainMenulistControl.MaterialManageButtonClickedEventArgs e)
        {
            OpenForm(e.MaterialManage);
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

        private void UscMenuBar_NonMovingTypeButtonClicked(object sender, Controls.MainControls.MainMenulistControl.NonMovingTypeButtonClickedEventArgs e)
        {
            OpenForm(e.NonMovingType);
        }

        private void UscMenuBar_PPMonitoringButtonClicked(object sender, Controls.MainControls.MainMenulistControl.PPMonitoringButtonClickedEventArgs e)
        {
            OpenForm(e.PPMonitoring);
        }

        private void UscMenuBar_PPStatisticsButtonClicked(object sender, Controls.MainControls.MainMenulistControl.PPStatisticsButtonClickedEventArgs e)
        {
            OpenForm(e.PPStatistics);
        }

        private void UscMenuBar_ProcessDefectButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProcessDefectButtonClickedEventArgs e)
        {
            OpenForm(e.ProcessDefect);
        }

        private void UscMenuBar_ProcessInspectionButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProcessInspectionButtonClickedEventArgs e)
        {
            OpenForm(e.ProcessInspection);
        }

        private void UscMenuBar_ProductionHistoryButtonClicked(object sender, Controls.MainControls.MainMenulistControl.ProductionHistoryButtonClickedEventArgs e)
        {
            OpenForm(e.ProductionHistory);
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

        private void UscMenuBar_SubjectButtonClicked(object sender, Controls.MainControls.MainMenulistControl.SubjectButtonClickedEventArgs e)
        {
            OpenForm(e.Subject);
        }

        private void UscMenuBar_WorkerButtonClicked(object sender, Controls.MainControls.MainMenulistControl.WorkerButtonClickedEventArgs e)
        {
            OpenForm(e.Worker);
        }

        private void UscMenuBar_WorkLogButtonClicked(object sender, Controls.MainControls.MainMenulistControl.WorkLogButtonClickedEventArgs e)
        {
            OpenForm(e.WorkLog);
        }


        #endregion
    }
}
