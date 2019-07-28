using PCBVI.Forms.Basic;
using PCBVI.Forms.Production;
using PCBVI.Properties;
using System;
using System.Windows.Forms;

namespace PCBVI.Controls.MainControls
{
    enum category//메터정보,생산,자재,설비,품질,모니터링,통계
    {
        Basic, Production, Materials, Facilities, Quality, Monitoring, Statistics
    }
    public partial class MainMenulistControl : UserControl
    {
        //접힘 묻는 상태들
        private bool[] isCollapsed = { true, true, true, true, true, true, true};
        public MainMenulistControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 드롭 다운 관련 타이머 함수
        /// 매개변수  타이머 판넬 버튼 카테고리
        /// </summary>    
        private void TimerDropDown(Timer timer,Panel panel, Button button ,int category)
        {
            if(isCollapsed[category])
            {
                button.Image = Resources.Collapse_Arrow_20px;
                panel.Height += 10;
                if(panel.Size == panel.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed[category] = false;
                }
            }
            else
            {
                button.Image = Resources.Expand_Arrow_20px;
                panel.Height -= 10;
                if (panel.Size == panel.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed[category] = true;
                }

            }
        }



        #region Timer
        private void TimerBasicDropDown_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerBasicDropDown, panelBasicInfo, btnBasicInfo, (int)category.Basic);
        }
        private void BtnBasicInfo_Click(object sender, EventArgs e)
        {
            timerBasicDropDown.Start();
        }

        private void TimerProduction_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerProduction, panelProduction, btnProduction, (int)category.Production);
        }

        private void BtnProduction_Click(object sender, EventArgs e)
        {
            timerProduction.Start();
        }
        private void TimerMaterials_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerMaterials, panelMaterials, btnMaterials, (int)category.Materials);
        }

        private void BtnMaterials_Click(object sender, EventArgs e)
        {
            timerMaterials.Start();
        }

        private void TimerFacilities_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerFacilities, panelFacilities, btnFacilities, (int)category.Facilities);
        }

        private void BtnFacilities_Click(object sender, EventArgs e)
        {
            timerFacilities.Start();
        }

        private void TimerQuality_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerQuality, panelQuality, btnQuality, (int)category.Quality);
        }

        private void BtnQuality_Click(object sender, EventArgs e)
        {
            timerQuality.Start();
        }

        private void TimerMonitering_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerMonitoring, panelMonitoring, btnMonitoring, (int)category.Monitoring);
        }
        private void BtnMonitering_Click(object sender, EventArgs e)
        {
            timerMonitoring.Start();
        }
        private void TimerStatistics_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerStatistics, panelStatistics, btnStatistics, (int)category.Statistics);
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            timerStatistics.Start();
        }
        #endregion

        #region ClickEventHandler

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            OnEmployeeButtonClicked(new EmployeeForm());
        }

        private void BtnSubject_Click(object sender, EventArgs e)
        {
            OnSubjectButtonClicked(new SubJectForm());
        }

        private void BtnErrorCode_Click(object sender, EventArgs e)
        {
            OnErrorCodeButtonClicked(new ErrorCodeForm());
        }

        private void BtnInspectionSt_Click(object sender, EventArgs e)
        {
            OnInspectionStButtonClicked(new InspectionStForm());
        }

        private void BtnEquipment_Click(object sender, EventArgs e)
        {
            OnEquipmentButtonClicked(new EquipmentForm());
        }

        private void BtnProductionHistory_Click(object sender, EventArgs e)
        {
            OnProductionHistoryButtonClicked(new ProductionHistoryForm());
        }
        private void BtnWorkLog_Click(object sender, EventArgs e)
        {
            OnWorkLogButtonClicked(new WorkLogForm());
        }

        private void BtnMaterialsManage_Click(object sender, EventArgs e)
        {
            OnMaterialManageButtonClicked(new MaterialsManageForm());
        }

        private void BtnWorker_Click(object sender, EventArgs e)
        {
            OnWorkerButtonClicked(new WorkerForm());
        }

        private void BtnDefectiveProduct_Click(object sender, EventArgs e)
        {
            OnDefectiveProductButtonClicked(new DefectiveProductForm());
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            OnBarcodeButtonClicked(new BarcodeForm());
        }

        private void BtnProcessDefect_Click(object sender, EventArgs e)
        {
            OnProcessDefectButtonClicked(new DefectiveProductForm());
        }
        private void BtnNonMovingType_Click(object sender, EventArgs e)
        {
            OnNonMovingTypeButtonClicked(new NonMovingTypeForm());
        }

        #endregion

        #region EmployeeButtonClicked event things for C# 3.0
        public event EventHandler<EmployeeButtonClickedEventArgs> EmployeeButtonClicked;

        protected virtual void OnEmployeeButtonClicked(EmployeeButtonClickedEventArgs e)
        {
            if (EmployeeButtonClicked != null)
                EmployeeButtonClicked(this, e);
        }

        private EmployeeButtonClickedEventArgs OnEmployeeButtonClicked(object employee)
        {
            EmployeeButtonClickedEventArgs args = new EmployeeButtonClickedEventArgs(employee);
            OnEmployeeButtonClicked(args);

            return args;
        }

        private EmployeeButtonClickedEventArgs OnEmployeeButtonClickedForOut()
        {
            EmployeeButtonClickedEventArgs args = new EmployeeButtonClickedEventArgs();
            OnEmployeeButtonClicked(args);

            return args;
        }

        public class EmployeeButtonClickedEventArgs : EventArgs
        {
            public object Employee { get; set; }

            public EmployeeButtonClickedEventArgs()
            {
            }

            public EmployeeButtonClickedEventArgs(object employee)
            {
                Employee = employee;
            }
        }
        #endregion
        #region SubjectButtonClicked event things for C# 3.0
        public event EventHandler<SubjectButtonClickedEventArgs> SubjectButtonClicked;

        protected virtual void OnSubjectButtonClicked(SubjectButtonClickedEventArgs e)
        {
            if (SubjectButtonClicked != null)
                SubjectButtonClicked(this, e);
        }

        private SubjectButtonClickedEventArgs OnSubjectButtonClicked(object subject)
        {
            SubjectButtonClickedEventArgs args = new SubjectButtonClickedEventArgs(subject);
            OnSubjectButtonClicked(args);

            return args;
        }

        private SubjectButtonClickedEventArgs OnSubjectButtonClickedForOut()
        {
            SubjectButtonClickedEventArgs args = new SubjectButtonClickedEventArgs();
            OnSubjectButtonClicked(args);

            return args;
        }

        public class SubjectButtonClickedEventArgs : EventArgs
        {
            public object Subject { get; set; }

            public SubjectButtonClickedEventArgs()
            {
            }

            public SubjectButtonClickedEventArgs(object subject)
            {
                Subject = subject;
            }
        }
        #endregion
        #region ErrorCodeButtonClicked event things for C# 3.0
        public event EventHandler<ErrorCodeButtonClickedEventArgs> ErrorCodeButtonClicked;

        protected virtual void OnErrorCodeButtonClicked(ErrorCodeButtonClickedEventArgs e)
        {
            if (ErrorCodeButtonClicked != null)
                ErrorCodeButtonClicked(this, e);
        }

        private ErrorCodeButtonClickedEventArgs OnErrorCodeButtonClicked(object errorCode)
        {
            ErrorCodeButtonClickedEventArgs args = new ErrorCodeButtonClickedEventArgs(errorCode);
            OnErrorCodeButtonClicked(args);

            return args;
        }

        private ErrorCodeButtonClickedEventArgs OnErrorCodeButtonClickedForOut()
        {
            ErrorCodeButtonClickedEventArgs args = new ErrorCodeButtonClickedEventArgs();
            OnErrorCodeButtonClicked(args);

            return args;
        }

        public class ErrorCodeButtonClickedEventArgs : EventArgs
        {
            public object ErrorCode { get; set; }

            public ErrorCodeButtonClickedEventArgs()
            {
            }

            public ErrorCodeButtonClickedEventArgs(object errorCode)
            {
                ErrorCode = errorCode;
            }
        }
        #endregion
        #region InspectionStButtonClicked event things for C# 3.0
        public event EventHandler<InspectionStButtonClickedEventArgs> InspectionStButtonClicked;

        protected virtual void OnInspectionStButtonClicked(InspectionStButtonClickedEventArgs e)
        {
            if (InspectionStButtonClicked != null)
                InspectionStButtonClicked(this, e);
        }

        private InspectionStButtonClickedEventArgs OnInspectionStButtonClicked(object inspectionSt)
        {
            InspectionStButtonClickedEventArgs args = new InspectionStButtonClickedEventArgs(inspectionSt);
            OnInspectionStButtonClicked(args);

            return args;
        }

        private InspectionStButtonClickedEventArgs OnInspectionStButtonClickedForOut()
        {
            InspectionStButtonClickedEventArgs args = new InspectionStButtonClickedEventArgs();
            OnInspectionStButtonClicked(args);

            return args;
        }

        public class InspectionStButtonClickedEventArgs : EventArgs
        {
            public object InspectionSt { get; set; }

            public InspectionStButtonClickedEventArgs()
            {
            }

            public InspectionStButtonClickedEventArgs(object inspectionSt)
            {
                InspectionSt = inspectionSt;
            }
        }
        #endregion
        #region EquipmentButtonClicked event things for C# 3.0
        public event EventHandler<EquipmentButtonClickedEventArgs> EquipmentButtonClicked;

        protected virtual void OnEquipmentButtonClicked(EquipmentButtonClickedEventArgs e)
        {
            if (EquipmentButtonClicked != null)
                EquipmentButtonClicked(this, e);
        }

        private EquipmentButtonClickedEventArgs OnEquipmentButtonClicked(object equipment)
        {
            EquipmentButtonClickedEventArgs args = new EquipmentButtonClickedEventArgs(equipment);
            OnEquipmentButtonClicked(args);

            return args;
        }

        private EquipmentButtonClickedEventArgs OnEquipmentButtonClickedForOut()
        {
            EquipmentButtonClickedEventArgs args = new EquipmentButtonClickedEventArgs();
            OnEquipmentButtonClicked(args);

            return args;
        }

        public class EquipmentButtonClickedEventArgs : EventArgs
        {
            public object Equipment { get; set; }

            public EquipmentButtonClickedEventArgs()
            {
            }

            public EquipmentButtonClickedEventArgs(object equipment)
            {
                Equipment = equipment;
            }
        }
        #endregion
        #region ProductionHistoryButtonClicked event things for C# 3.0
        public event EventHandler<ProductionHistoryButtonClickedEventArgs> ProductionHistoryButtonClicked;

        protected virtual void OnProductionHistoryButtonClicked(ProductionHistoryButtonClickedEventArgs e)
        {
            if (ProductionHistoryButtonClicked != null)
                ProductionHistoryButtonClicked(this, e);
        }

        private ProductionHistoryButtonClickedEventArgs OnProductionHistoryButtonClicked(object productionHistory)
        {
            ProductionHistoryButtonClickedEventArgs args = new ProductionHistoryButtonClickedEventArgs(productionHistory);
            OnProductionHistoryButtonClicked(args);

            return args;
        }

        private ProductionHistoryButtonClickedEventArgs OnProductionHistoryButtonClickedForOut()
        {
            ProductionHistoryButtonClickedEventArgs args = new ProductionHistoryButtonClickedEventArgs();
            OnProductionHistoryButtonClicked(args);

            return args;
        }

        public class ProductionHistoryButtonClickedEventArgs : EventArgs
        {
            public object ProductionHistory { get; set; }

            public ProductionHistoryButtonClickedEventArgs()
            {
            }

            public ProductionHistoryButtonClickedEventArgs(object productionHistory)
            {
                ProductionHistory = productionHistory;
            }
        }
        #endregion
        #region WorkLogButtonClicked event things for C# 3.0
        public event EventHandler<WorkLogButtonClickedEventArgs> WorkLogButtonClicked;

        protected virtual void OnWorkLogButtonClicked(WorkLogButtonClickedEventArgs e)
        {
            if (WorkLogButtonClicked != null)
                WorkLogButtonClicked(this, e);
        }

        private WorkLogButtonClickedEventArgs OnWorkLogButtonClicked(object workLog)
        {
            WorkLogButtonClickedEventArgs args = new WorkLogButtonClickedEventArgs(workLog);
            OnWorkLogButtonClicked(args);

            return args;
        }

        private WorkLogButtonClickedEventArgs OnWorkLogButtonClickedForOut()
        {
            WorkLogButtonClickedEventArgs args = new WorkLogButtonClickedEventArgs();
            OnWorkLogButtonClicked(args);

            return args;
        }

        public class WorkLogButtonClickedEventArgs : EventArgs
        {
            public object WorkLog { get; set; }

            public WorkLogButtonClickedEventArgs()
            {
            }

            public WorkLogButtonClickedEventArgs(object workLog)
            {
                WorkLog = workLog;
            }
        }
        #endregion
        #region MaterialManageButtonClicked event things for C# 3.0
        public event EventHandler<MaterialManageButtonClickedEventArgs> MaterialManageButtonClicked;

        protected virtual void OnMaterialManageButtonClicked(MaterialManageButtonClickedEventArgs e)
        {
            if (MaterialManageButtonClicked != null)
                MaterialManageButtonClicked(this, e);
        }

        private MaterialManageButtonClickedEventArgs OnMaterialManageButtonClicked(object materialManage)
        {
            MaterialManageButtonClickedEventArgs args = new MaterialManageButtonClickedEventArgs(materialManage);
            OnMaterialManageButtonClicked(args);

            return args;
        }

        private MaterialManageButtonClickedEventArgs OnMaterialManageButtonClickedForOut()
        {
            MaterialManageButtonClickedEventArgs args = new MaterialManageButtonClickedEventArgs();
            OnMaterialManageButtonClicked(args);

            return args;
        }

        public class MaterialManageButtonClickedEventArgs : EventArgs
        {
            public object MaterialManage { get; set; }

            public MaterialManageButtonClickedEventArgs()
            {
            }

            public MaterialManageButtonClickedEventArgs(object materialManage)
            {
                MaterialManage = materialManage;
            }
        }
        #endregion
        #region WorkerButtonClicked event things for C# 3.0
        public event EventHandler<WorkerButtonClickedEventArgs> WorkerButtonClicked;

        protected virtual void OnWorkerButtonClicked(WorkerButtonClickedEventArgs e)
        {
            if (WorkerButtonClicked != null)
                WorkerButtonClicked(this, e);
        }

        private WorkerButtonClickedEventArgs OnWorkerButtonClicked(object worker)
        {
            WorkerButtonClickedEventArgs args = new WorkerButtonClickedEventArgs(worker);
            OnWorkerButtonClicked(args);

            return args;
        }

        private WorkerButtonClickedEventArgs OnWorkerButtonClickedForOut()
        {
            WorkerButtonClickedEventArgs args = new WorkerButtonClickedEventArgs();
            OnWorkerButtonClicked(args);

            return args;
        }

        public class WorkerButtonClickedEventArgs : EventArgs
        {
            public object Worker { get; set; }

            public WorkerButtonClickedEventArgs()
            {
            }

            public WorkerButtonClickedEventArgs(object worker)
            {
                Worker = worker;
            }
        }
        #endregion
        #region DefectiveProductButtonClicked event things for C# 3.0
        public event EventHandler<DefectiveProductButtonClickedEventArgs> DefectiveProductButtonClicked;

        protected virtual void OnDefectiveProductButtonClicked(DefectiveProductButtonClickedEventArgs e)
        {
            if (DefectiveProductButtonClicked != null)
                DefectiveProductButtonClicked(this, e);
        }

        private DefectiveProductButtonClickedEventArgs OnDefectiveProductButtonClicked(object defectiveProduct)
        {
            DefectiveProductButtonClickedEventArgs args = new DefectiveProductButtonClickedEventArgs(defectiveProduct);
            OnDefectiveProductButtonClicked(args);

            return args;
        }

        private DefectiveProductButtonClickedEventArgs OnDefectiveProductButtonClickedForOut()
        {
            DefectiveProductButtonClickedEventArgs args = new DefectiveProductButtonClickedEventArgs();
            OnDefectiveProductButtonClicked(args);

            return args;
        }

        public class DefectiveProductButtonClickedEventArgs : EventArgs
        {
            public object DefectiveProduct { get; set; }

            public DefectiveProductButtonClickedEventArgs()
            {
            }

            public DefectiveProductButtonClickedEventArgs(object defectiveProduct)
            {
                DefectiveProduct = defectiveProduct;
            }
        }
        #endregion
        #region BarcodeButtonClicked event things for C# 3.0
        public event EventHandler<BarcodeButtonClickedEventArgs> BarcodeButtonClicked;

        protected virtual void OnBarcodeButtonClicked(BarcodeButtonClickedEventArgs e)
        {
            if (BarcodeButtonClicked != null)
                BarcodeButtonClicked(this, e);
        }

        private BarcodeButtonClickedEventArgs OnBarcodeButtonClicked(object barcode)
        {
            BarcodeButtonClickedEventArgs args = new BarcodeButtonClickedEventArgs(barcode);
            OnBarcodeButtonClicked(args);

            return args;
        }

        private BarcodeButtonClickedEventArgs OnBarcodeButtonClickedForOut()
        {
            BarcodeButtonClickedEventArgs args = new BarcodeButtonClickedEventArgs();
            OnBarcodeButtonClicked(args);

            return args;
        }

        public class BarcodeButtonClickedEventArgs : EventArgs
        {
            public object Barcode { get; set; }

            public BarcodeButtonClickedEventArgs()
            {
            }

            public BarcodeButtonClickedEventArgs(object barcode)
            {
                Barcode = barcode;
            }
        }
        #endregion
        #region ProcessDefectButtonClicked event things for C# 3.0
        public event EventHandler<ProcessDefectButtonClickedEventArgs> ProcessDefectButtonClicked;

        protected virtual void OnProcessDefectButtonClicked(ProcessDefectButtonClickedEventArgs e)
        {
            if (ProcessDefectButtonClicked != null)
                ProcessDefectButtonClicked(this, e);
        }

        private ProcessDefectButtonClickedEventArgs OnProcessDefectButtonClicked(object processDefect)
        {
            ProcessDefectButtonClickedEventArgs args = new ProcessDefectButtonClickedEventArgs(processDefect);
            OnProcessDefectButtonClicked(args);

            return args;
        }

        private ProcessDefectButtonClickedEventArgs OnProcessDefectButtonClickedForOut()
        {
            ProcessDefectButtonClickedEventArgs args = new ProcessDefectButtonClickedEventArgs();
            OnProcessDefectButtonClicked(args);

            return args;
        }

        public class ProcessDefectButtonClickedEventArgs : EventArgs
        {
            public object ProcessDefect { get; set; }

            public ProcessDefectButtonClickedEventArgs()
            {
            }

            public ProcessDefectButtonClickedEventArgs(object processDefect)
            {
                ProcessDefect = processDefect;
            }
        }
        #endregion
        #region NonMovingTypeButtonClicked event things for C# 3.0
        public event EventHandler<NonMovingTypeButtonClickedEventArgs> NonMovingTypeButtonClicked;

        protected virtual void OnNonMovingTypeButtonClicked(NonMovingTypeButtonClickedEventArgs e)
        {
            if (NonMovingTypeButtonClicked != null)
                NonMovingTypeButtonClicked(this, e);
        }

        private NonMovingTypeButtonClickedEventArgs OnNonMovingTypeButtonClicked(object nonMovingType)
        {
            NonMovingTypeButtonClickedEventArgs args = new NonMovingTypeButtonClickedEventArgs(nonMovingType);
            OnNonMovingTypeButtonClicked(args);

            return args;
        }

        private NonMovingTypeButtonClickedEventArgs OnNonMovingTypeButtonClickedForOut()
        {
            NonMovingTypeButtonClickedEventArgs args = new NonMovingTypeButtonClickedEventArgs();
            OnNonMovingTypeButtonClicked(args);

            return args;
        }

        public class NonMovingTypeButtonClickedEventArgs : EventArgs
        {
            public object NonMovingType { get; set; }

            public NonMovingTypeButtonClickedEventArgs()
            {
            }

            public NonMovingTypeButtonClickedEventArgs(object nonMovingType)
            {
                NonMovingType = nonMovingType;
            }
        }
        #endregion
       
    }
}
