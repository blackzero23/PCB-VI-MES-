using PCBVI.Forms.Basic;
using PCBVI.Forms.Facilities;
using PCBVI.Forms.Materials;
using PCBVI.Forms.Monitoring;
using PCBVI.Forms.Production;
using PCBVI.Forms.Quality;
using PCBVI.Forms.Statistics;
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
        private bool[] isCollapsed = { true, true, true, true, true, true, true };
        public MainMenulistControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 드롭 다운 관련 타이머 함수
        /// 매개변수  타이머 판넬 버튼 카테고리
        /// </summary>    
        private void TimerDropDown(Timer timer, Panel panel, Button button, int category)
        {
            if (isCollapsed[category])
            {
                button.Image = Resources.Collapse_Arrow_20px;
                panel.Height += 10;
                if (panel.Size == panel.MaximumSize)
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
        private void BtnMaterialsInOut_Click(object sender, EventArgs e)
        {
            OnMaterialsInOutButtonClicked(new MaterialsInOutForm());
        }

        private void BtnMaterialsInRe_Click(object sender, EventArgs e)
        {
            OnMaterialsInReButtonClicked(new MaterialsInReForm());
        }

        private void BtnMaterialsHistory_Click(object sender, EventArgs e)
        {
            OnMaterialsHistoryButtonClicked(new MaterialsHistoryForm());
        }

        private void BtnFacilitiesPower_Click(object sender, EventArgs e)
        {
            OnFacilitiesPowerButtonClicked(new FacilitiesPowerForm());
        }

        private void BtnFacilitiesError_Click(object sender, EventArgs e)
        {
            OnFacilitiesErrorButtonClicked(new FacilitiesErrorForm());
        }

        private void BtnFacilitiesHistory_Click(object sender, EventArgs e)
        {
            OnFacilitiesHistoryButtonClicked(new FacilitiesHistoryForm());
        }

        private void BtnFirstInspection_Click(object sender, EventArgs e)
        {
            OnFirstInspectionButtonClicked(new FirstInspectionForm());
        }

        private void BtnProcessInspection_Click(object sender, EventArgs e)
        {
            OnProcessInspectionButtonClicked(new ProcessInspectionForm());
        }

        private void BtnLastInspection_Click(object sender, EventArgs e)
        {
            OnLastInspectionButtonClicked(new LastInspectionForm());
        }

        private void BtnProPerformanceMonitoring_Click(object sender, EventArgs e)
        {
            OnPPMonitoringButtonClicked(new PPMonitoringForm());
        }

        private void BtnProStatusMonitoring_Click(object sender, EventArgs e)
        {
            OnPSMonitoringButtonClicked(new PSMonitoringForm());
        }

        private void BtnFacilitiesMonitoring_Click(object sender, EventArgs e)
        {
            OnFacilitiesButtonClicked(new FacilitiesMonitoringFormcs());
        }

        private void BtnQualityMonitoring_Click(object sender, EventArgs e)
        {
            OnPSMonitoringButtonClicked(new QualityMonitoringForm());
        }

        private void BtnProductProcessStatistics_Click(object sender, EventArgs e)
        {
            OnPPStatisticsButtonClicked(new PPStatisticsForm());
        }

        private void BtnErrorStatistics_Click(object sender, EventArgs e)
        {
            OnErrorStatisticsButtonClicked(new ErrorStatisticsFrom());
        }

        private void BtnStockStatistics_Click(object sender, EventArgs e)
        {
            OnStockStatisticsButtonClicked(new StockStatisticsFrom());
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
        #region MaterialsInOutButtonClicked event things for C# 3.0
        public event EventHandler<MaterialsInOutButtonClickedEventArgs> MaterialsInOutButtonClicked;

        protected virtual void OnMaterialsInOutButtonClicked(MaterialsInOutButtonClickedEventArgs e)
        {
            if (MaterialsInOutButtonClicked != null)
                MaterialsInOutButtonClicked(this, e);
        }

        private MaterialsInOutButtonClickedEventArgs OnMaterialsInOutButtonClicked(object meterialsInOut)
        {
            MaterialsInOutButtonClickedEventArgs args = new MaterialsInOutButtonClickedEventArgs(meterialsInOut);
            OnMaterialsInOutButtonClicked(args);

            return args;
        }

        private MaterialsInOutButtonClickedEventArgs OnMaterialsInOutButtonClickedForOut()
        {
            MaterialsInOutButtonClickedEventArgs args = new MaterialsInOutButtonClickedEventArgs();
            OnMaterialsInOutButtonClicked(args);

            return args;
        }

        public class MaterialsInOutButtonClickedEventArgs : EventArgs
        {
            public object MeterialsInOut { get; set; }

            public MaterialsInOutButtonClickedEventArgs()
            {
            }

            public MaterialsInOutButtonClickedEventArgs(object meterialsInOut)
            {
                MeterialsInOut = meterialsInOut;
            }
        }
        #endregion
        #region MaterialsInReButtonClicked event things for C# 3.0
        public event EventHandler<MaterialsInReButtonClickedEventArgs> MaterialsInReButtonClicked;

        protected virtual void OnMaterialsInReButtonClicked(MaterialsInReButtonClickedEventArgs e)
        {
            if (MaterialsInReButtonClicked != null)
                MaterialsInReButtonClicked(this, e);
        }

        private MaterialsInReButtonClickedEventArgs OnMaterialsInReButtonClicked(object materialsInRe)
        {
            MaterialsInReButtonClickedEventArgs args = new MaterialsInReButtonClickedEventArgs(materialsInRe);
            OnMaterialsInReButtonClicked(args);

            return args;
        }

        private MaterialsInReButtonClickedEventArgs OnMaterialsInReButtonClickedForOut()
        {
            MaterialsInReButtonClickedEventArgs args = new MaterialsInReButtonClickedEventArgs();
            OnMaterialsInReButtonClicked(args);

            return args;
        }

        public class MaterialsInReButtonClickedEventArgs : EventArgs
        {
            public object MaterialsInRe { get; set; }

            public MaterialsInReButtonClickedEventArgs()
            {
            }

            public MaterialsInReButtonClickedEventArgs(object materialsInRe)
            {
                MaterialsInRe = materialsInRe;
            }
        }
        #endregion
        #region MaterialsHistoryButtonClicked event things for C# 3.0
        public event EventHandler<MaterialsHistoryButtonClickedEventArgs> MaterialsHistoryButtonClicked;

        protected virtual void OnMaterialsHistoryButtonClicked(MaterialsHistoryButtonClickedEventArgs e)
        {
            if (MaterialsHistoryButtonClicked != null)
                MaterialsHistoryButtonClicked(this, e);
        }

        private MaterialsHistoryButtonClickedEventArgs OnMaterialsHistoryButtonClicked(object materialsHistory)
        {
            MaterialsHistoryButtonClickedEventArgs args = new MaterialsHistoryButtonClickedEventArgs(materialsHistory);
            OnMaterialsHistoryButtonClicked(args);

            return args;
        }

        private MaterialsHistoryButtonClickedEventArgs OnMaterialsHistoryButtonClickedForOut()
        {
            MaterialsHistoryButtonClickedEventArgs args = new MaterialsHistoryButtonClickedEventArgs();
            OnMaterialsHistoryButtonClicked(args);

            return args;
        }

        public class MaterialsHistoryButtonClickedEventArgs : EventArgs
        {
            public object MaterialsHistory { get; set; }

            public MaterialsHistoryButtonClickedEventArgs()
            {
            }

            public MaterialsHistoryButtonClickedEventArgs(object materialsHistory)
            {
                MaterialsHistory = materialsHistory;
            }
        }
        #endregion
        #region FacilitiesPowerButtonClicked event things for C# 3.0
        public event EventHandler<FacilitiesPowerButtonClickedEventArgs> FacilitiesPowerButtonClicked;

        protected virtual void OnFacilitiesPowerButtonClicked(FacilitiesPowerButtonClickedEventArgs e)
        {
            if (FacilitiesPowerButtonClicked != null)
                FacilitiesPowerButtonClicked(this, e);
        }

        private FacilitiesPowerButtonClickedEventArgs OnFacilitiesPowerButtonClicked(object facilitiesPower)
        {
            FacilitiesPowerButtonClickedEventArgs args = new FacilitiesPowerButtonClickedEventArgs(facilitiesPower);
            OnFacilitiesPowerButtonClicked(args);

            return args;
        }

        private FacilitiesPowerButtonClickedEventArgs OnFacilitiesPowerButtonClickedForOut()
        {
            FacilitiesPowerButtonClickedEventArgs args = new FacilitiesPowerButtonClickedEventArgs();
            OnFacilitiesPowerButtonClicked(args);

            return args;
        }

        public class FacilitiesPowerButtonClickedEventArgs : EventArgs
        {
            public object FacilitiesPower { get; set; }

            public FacilitiesPowerButtonClickedEventArgs()
            {
            }

            public FacilitiesPowerButtonClickedEventArgs(object facilitiesPower)
            {
                FacilitiesPower = facilitiesPower;
            }
        }
        #endregion
        #region FacilitiesErrorButtonClicked event things for C# 3.0
        public event EventHandler<FacilitiesErrorButtonClickedEventArgs> FacilitiesErrorButtonClicked;

        protected virtual void OnFacilitiesErrorButtonClicked(FacilitiesErrorButtonClickedEventArgs e)
        {
            if (FacilitiesErrorButtonClicked != null)
                FacilitiesErrorButtonClicked(this, e);
        }

        private FacilitiesErrorButtonClickedEventArgs OnFacilitiesErrorButtonClicked(object facilitiesError)
        {
            FacilitiesErrorButtonClickedEventArgs args = new FacilitiesErrorButtonClickedEventArgs(facilitiesError);
            OnFacilitiesErrorButtonClicked(args);

            return args;
        }

        private FacilitiesErrorButtonClickedEventArgs OnFacilitiesErrorButtonClickedForOut()
        {
            FacilitiesErrorButtonClickedEventArgs args = new FacilitiesErrorButtonClickedEventArgs();
            OnFacilitiesErrorButtonClicked(args);

            return args;
        }

        public class FacilitiesErrorButtonClickedEventArgs : EventArgs
        {
            public object FacilitiesError { get; set; }

            public FacilitiesErrorButtonClickedEventArgs()
            {
            }

            public FacilitiesErrorButtonClickedEventArgs(object facilitiesError)
            {
                FacilitiesError = facilitiesError;
            }
        }
        #endregion
        #region FacilitiesHistoryButtonClicked event things for C# 3.0
        public event EventHandler<FacilitiesHistoryButtonClickedEventArgs> FacilitiesHistoryButtonClicked;

        protected virtual void OnFacilitiesHistoryButtonClicked(FacilitiesHistoryButtonClickedEventArgs e)
        {
            if (FacilitiesHistoryButtonClicked != null)
                FacilitiesHistoryButtonClicked(this, e);
        }

        private FacilitiesHistoryButtonClickedEventArgs OnFacilitiesHistoryButtonClicked(object facilitiesHistory)
        {
            FacilitiesHistoryButtonClickedEventArgs args = new FacilitiesHistoryButtonClickedEventArgs(facilitiesHistory);
            OnFacilitiesHistoryButtonClicked(args);

            return args;
        }

        private FacilitiesHistoryButtonClickedEventArgs OnFacilitiesHistoryButtonClickedForOut()
        {
            FacilitiesHistoryButtonClickedEventArgs args = new FacilitiesHistoryButtonClickedEventArgs();
            OnFacilitiesHistoryButtonClicked(args);

            return args;
        }

        public class FacilitiesHistoryButtonClickedEventArgs : EventArgs
        {
            public object FacilitiesHistory { get; set; }

            public FacilitiesHistoryButtonClickedEventArgs()
            {
            }

            public FacilitiesHistoryButtonClickedEventArgs(object facilitiesHistory)
            {
                FacilitiesHistory = facilitiesHistory;
            }
        }
        #endregion
        #region FirstInspectionButtonClicked event things for C# 3.0
        public event EventHandler<FirstInspectionButtonClickedEventArgs> FirstInspectionButtonClicked;

        protected virtual void OnFirstInspectionButtonClicked(FirstInspectionButtonClickedEventArgs e)
        {
            if (FirstInspectionButtonClicked != null)
                FirstInspectionButtonClicked(this, e);
        }

        private FirstInspectionButtonClickedEventArgs OnFirstInspectionButtonClicked(object firstInspection)
        {
            FirstInspectionButtonClickedEventArgs args = new FirstInspectionButtonClickedEventArgs(firstInspection);
            OnFirstInspectionButtonClicked(args);

            return args;
        }

        private FirstInspectionButtonClickedEventArgs OnFirstInspectionButtonClickedForOut()
        {
            FirstInspectionButtonClickedEventArgs args = new FirstInspectionButtonClickedEventArgs();
            OnFirstInspectionButtonClicked(args);

            return args;
        }

        public class FirstInspectionButtonClickedEventArgs : EventArgs
        {
            public object FirstInspection { get; set; }

            public FirstInspectionButtonClickedEventArgs()
            {
            }

            public FirstInspectionButtonClickedEventArgs(object firstInspection)
            {
                FirstInspection = firstInspection;
            }
        }
        #endregion
        #region ProcessInspectionButtonClicked event things for C# 3.0
        public event EventHandler<ProcessInspectionButtonClickedEventArgs> ProcessInspectionButtonClicked;

        protected virtual void OnProcessInspectionButtonClicked(ProcessInspectionButtonClickedEventArgs e)
        {
            if (ProcessInspectionButtonClicked != null)
                ProcessInspectionButtonClicked(this, e);
        }

        private ProcessInspectionButtonClickedEventArgs OnProcessInspectionButtonClicked(object processInspection)
        {
            ProcessInspectionButtonClickedEventArgs args = new ProcessInspectionButtonClickedEventArgs(processInspection);
            OnProcessInspectionButtonClicked(args);

            return args;
        }

        private ProcessInspectionButtonClickedEventArgs OnProcessInspectionButtonClickedForOut()
        {
            ProcessInspectionButtonClickedEventArgs args = new ProcessInspectionButtonClickedEventArgs();
            OnProcessInspectionButtonClicked(args);

            return args;
        }

        public class ProcessInspectionButtonClickedEventArgs : EventArgs
        {
            public object ProcessInspection { get; set; }

            public ProcessInspectionButtonClickedEventArgs()
            {
            }

            public ProcessInspectionButtonClickedEventArgs(object processInspection)
            {
                ProcessInspection = processInspection;
            }
        }
        #endregion
        #region LastInspectionButtonClicked event things for C# 3.0
        public event EventHandler<LastInspectionButtonClickedEventArgs> LastInspectionButtonClicked;

        protected virtual void OnLastInspectionButtonClicked(LastInspectionButtonClickedEventArgs e)
        {
            if (LastInspectionButtonClicked != null)
                LastInspectionButtonClicked(this, e);
        }

        private LastInspectionButtonClickedEventArgs OnLastInspectionButtonClicked(object lastInspection)
        {
            LastInspectionButtonClickedEventArgs args = new LastInspectionButtonClickedEventArgs(lastInspection);
            OnLastInspectionButtonClicked(args);

            return args;
        }

        private LastInspectionButtonClickedEventArgs OnLastInspectionButtonClickedForOut()
        {
            LastInspectionButtonClickedEventArgs args = new LastInspectionButtonClickedEventArgs();
            OnLastInspectionButtonClicked(args);

            return args;
        }

        public class LastInspectionButtonClickedEventArgs : EventArgs
        {
            public object LastInspection { get; set; }

            public LastInspectionButtonClickedEventArgs()
            {
            }

            public LastInspectionButtonClickedEventArgs(object lastInspection)
            {
                LastInspection = lastInspection;
            }
        }
        #endregion
        #region PPMonitoringButtonClicked event things for C# 3.0
        public event EventHandler<PPMonitoringButtonClickedEventArgs> PPMonitoringButtonClicked;

        protected virtual void OnPPMonitoringButtonClicked(PPMonitoringButtonClickedEventArgs e)
        {
            if (PPMonitoringButtonClicked != null)
                PPMonitoringButtonClicked(this, e);
        }

        private PPMonitoringButtonClickedEventArgs OnPPMonitoringButtonClicked(object pPMonitoring)
        {
            PPMonitoringButtonClickedEventArgs args = new PPMonitoringButtonClickedEventArgs(pPMonitoring);
            OnPPMonitoringButtonClicked(args);

            return args;
        }

        private PPMonitoringButtonClickedEventArgs OnPPMonitoringButtonClickedForOut()
        {
            PPMonitoringButtonClickedEventArgs args = new PPMonitoringButtonClickedEventArgs();
            OnPPMonitoringButtonClicked(args);

            return args;
        }

        public class PPMonitoringButtonClickedEventArgs : EventArgs
        {
            public object PPMonitoring { get; set; }

            public PPMonitoringButtonClickedEventArgs()
            {
            }

            public PPMonitoringButtonClickedEventArgs(object pPMonitoring)
            {
                PPMonitoring = pPMonitoring;
            }
        }
        #endregion
        #region PSMonitoringButtonClicked event things for C# 3.0
        public event EventHandler<PSMonitoringButtonClickedEventArgs> PSMonitoringButtonClicked;

        protected virtual void OnPSMonitoringButtonClicked(PSMonitoringButtonClickedEventArgs e)
        {
            if (PSMonitoringButtonClicked != null)
                PSMonitoringButtonClicked(this, e);
        }

        private PSMonitoringButtonClickedEventArgs OnPSMonitoringButtonClicked(object pSMonitoring)
        {
            PSMonitoringButtonClickedEventArgs args = new PSMonitoringButtonClickedEventArgs(pSMonitoring);
            OnPSMonitoringButtonClicked(args);

            return args;
        }

        private PSMonitoringButtonClickedEventArgs OnPSMonitoringButtonClickedForOut()
        {
            PSMonitoringButtonClickedEventArgs args = new PSMonitoringButtonClickedEventArgs();
            OnPSMonitoringButtonClicked(args);

            return args;
        }

        public class PSMonitoringButtonClickedEventArgs : EventArgs
        {
            public object PSMonitoring { get; set; }

            public PSMonitoringButtonClickedEventArgs()
            {
            }

            public PSMonitoringButtonClickedEventArgs(object pSMonitoring)
            {
                PSMonitoring = pSMonitoring;
            }
        }
        #endregion
        #region FacilitiesButtonClicked event things for C# 3.0
        public event EventHandler<FacilitiesButtonClickedEventArgs> FacilitiesButtonClicked;

        protected virtual void OnFacilitiesButtonClicked(FacilitiesButtonClickedEventArgs e)
        {
            if (FacilitiesButtonClicked != null)
                FacilitiesButtonClicked(this, e);
        }

        private FacilitiesButtonClickedEventArgs OnFacilitiesButtonClicked(object facilities)
        {
            FacilitiesButtonClickedEventArgs args = new FacilitiesButtonClickedEventArgs(facilities);
            OnFacilitiesButtonClicked(args);

            return args;
        }

        private FacilitiesButtonClickedEventArgs OnFacilitiesButtonClickedForOut()
        {
            FacilitiesButtonClickedEventArgs args = new FacilitiesButtonClickedEventArgs();
            OnFacilitiesButtonClicked(args);

            return args;
        }

        public class FacilitiesButtonClickedEventArgs : EventArgs
        {
            public object Facilities { get; set; }

            public FacilitiesButtonClickedEventArgs()
            {
            }

            public FacilitiesButtonClickedEventArgs(object facilities)
            {
                Facilities = facilities;
            }
        }
        #endregion
        #region QualityButtonClicked event things for C# 3.0
        public event EventHandler<QualityButtonClickedEventArgs> QualityButtonClicked;

        protected virtual void OnQualityButtonClicked(QualityButtonClickedEventArgs e)
        {
            if (QualityButtonClicked != null)
                QualityButtonClicked(this, e);
        }

        private QualityButtonClickedEventArgs OnQualityButtonClicked(object quality)
        {
            QualityButtonClickedEventArgs args = new QualityButtonClickedEventArgs(quality);
            OnQualityButtonClicked(args);

            return args;
        }

        private QualityButtonClickedEventArgs OnQualityButtonClickedForOut()
        {
            QualityButtonClickedEventArgs args = new QualityButtonClickedEventArgs();
            OnQualityButtonClicked(args);

            return args;
        }

        public class QualityButtonClickedEventArgs : EventArgs
        {
            public object Quality { get; set; }

            public QualityButtonClickedEventArgs()
            {
            }

            public QualityButtonClickedEventArgs(object quality)
            {
                Quality = quality;
            }
        }
        #endregion
        #region PPStatisticsButtonClicked event things for C# 3.0
        public event EventHandler<PPStatisticsButtonClickedEventArgs> PPStatisticsButtonClicked;

        protected virtual void OnPPStatisticsButtonClicked(PPStatisticsButtonClickedEventArgs e)
        {
            if (PPStatisticsButtonClicked != null)
                PPStatisticsButtonClicked(this, e);
        }

        private PPStatisticsButtonClickedEventArgs OnPPStatisticsButtonClicked(object pPStatistics)
        {
            PPStatisticsButtonClickedEventArgs args = new PPStatisticsButtonClickedEventArgs(pPStatistics);
            OnPPStatisticsButtonClicked(args);

            return args;
        }

        private PPStatisticsButtonClickedEventArgs OnPPStatisticsButtonClickedForOut()
        {
            PPStatisticsButtonClickedEventArgs args = new PPStatisticsButtonClickedEventArgs();
            OnPPStatisticsButtonClicked(args);

            return args;
        }

        public class PPStatisticsButtonClickedEventArgs : EventArgs
        {
            public object PPStatistics { get; set; }

            public PPStatisticsButtonClickedEventArgs()
            {
            }

            public PPStatisticsButtonClickedEventArgs(object pPStatistics)
            {
                PPStatistics = pPStatistics;
            }
        }
        #endregion
        #region ErrorStatisticsButtonClicked event things for C# 3.0
        public event EventHandler<ErrorStatisticsButtonClickedEventArgs> ErrorStatisticsButtonClicked;

        protected virtual void OnErrorStatisticsButtonClicked(ErrorStatisticsButtonClickedEventArgs e)
        {
            if (ErrorStatisticsButtonClicked != null)
                ErrorStatisticsButtonClicked(this, e);
        }

        private ErrorStatisticsButtonClickedEventArgs OnErrorStatisticsButtonClicked(object errorStatistics)
        {
            ErrorStatisticsButtonClickedEventArgs args = new ErrorStatisticsButtonClickedEventArgs(errorStatistics);
            OnErrorStatisticsButtonClicked(args);

            return args;
        }

        private ErrorStatisticsButtonClickedEventArgs OnErrorStatisticsButtonClickedForOut()
        {
            ErrorStatisticsButtonClickedEventArgs args = new ErrorStatisticsButtonClickedEventArgs();
            OnErrorStatisticsButtonClicked(args);

            return args;
        }

        public class ErrorStatisticsButtonClickedEventArgs : EventArgs
        {
            public object ErrorStatistics { get; set; }

            public ErrorStatisticsButtonClickedEventArgs()
            {
            }

            public ErrorStatisticsButtonClickedEventArgs(object errorStatistics)
            {
                ErrorStatistics = errorStatistics;
            }
        }
        #endregion
        #region StockStatisticsButtonClicked event things for C# 3.0
        public event EventHandler<StockStatisticsButtonClickedEventArgs> StockStatisticsButtonClicked;

        protected virtual void OnStockStatisticsButtonClicked(StockStatisticsButtonClickedEventArgs e)
        {
            if (StockStatisticsButtonClicked != null)
                StockStatisticsButtonClicked(this, e);
        }

        private StockStatisticsButtonClickedEventArgs OnStockStatisticsButtonClicked(object stockStatistics)
        {
            StockStatisticsButtonClickedEventArgs args = new StockStatisticsButtonClickedEventArgs(stockStatistics);
            OnStockStatisticsButtonClicked(args);

            return args;
        }

        private StockStatisticsButtonClickedEventArgs OnStockStatisticsButtonClickedForOut()
        {
            StockStatisticsButtonClickedEventArgs args = new StockStatisticsButtonClickedEventArgs();
            OnStockStatisticsButtonClicked(args);

            return args;
        }

        public class StockStatisticsButtonClickedEventArgs : EventArgs
        {
            public object StockStatistics { get; set; }

            public StockStatisticsButtonClickedEventArgs()
            {
            }

            public StockStatisticsButtonClickedEventArgs(object stockStatistics)
            {
                StockStatistics = stockStatistics;
            }
        }
        #endregion

    }
}
