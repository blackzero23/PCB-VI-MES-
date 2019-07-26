namespace PCBVI.Controls.MainControls
{
    partial class MainMenulistControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBasicInfo = new System.Windows.Forms.Panel();
            this.btnNonMovingType = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnInspectionSt = new System.Windows.Forms.Button();
            this.btnErrorCode = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnBasicInfo = new System.Windows.Forms.Button();
            this.timerBasicDropDown = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProduction = new System.Windows.Forms.Panel();
            this.btnProcessDefect = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnDefectiveProduct = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnMaterialsManage = new System.Windows.Forms.Button();
            this.btnWorkLog = new System.Windows.Forms.Button();
            this.btnProductionHistory = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.panelMaterials = new System.Windows.Forms.Panel();
            this.btnMaterialsHistory = new System.Windows.Forms.Button();
            this.btnMaterialsInRe = new System.Windows.Forms.Button();
            this.btnMaterialsInOut = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.panelFacilities = new System.Windows.Forms.Panel();
            this.btnFacilitiesHistory = new System.Windows.Forms.Button();
            this.btnFacilitiesError = new System.Windows.Forms.Button();
            this.btnFacilitiesPower = new System.Windows.Forms.Button();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.panelQuality = new System.Windows.Forms.Panel();
            this.btnLastInspection = new System.Windows.Forms.Button();
            this.btnProcessInspection = new System.Windows.Forms.Button();
            this.btnFirstInspection = new System.Windows.Forms.Button();
            this.btnQuality = new System.Windows.Forms.Button();
            this.panelMonitering = new System.Windows.Forms.Panel();
            this.btnQualityMonitering = new System.Windows.Forms.Button();
            this.btnFacilitiesMonitering = new System.Windows.Forms.Button();
            this.btnProStatusMonitering = new System.Windows.Forms.Button();
            this.btnProPerformanceMoniTering = new System.Windows.Forms.Button();
            this.btnMonitering = new System.Windows.Forms.Button();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.btnStockStatistics = new System.Windows.Forms.Button();
            this.btnErrorStatistics = new System.Windows.Forms.Button();
            this.btnProductProcessStatistics = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.timerMaterials = new System.Windows.Forms.Timer(this.components);
            this.timerFacilities = new System.Windows.Forms.Timer(this.components);
            this.timerQuality = new System.Windows.Forms.Timer(this.components);
            this.timerMonitering = new System.Windows.Forms.Timer(this.components);
            this.timerStatistics = new System.Windows.Forms.Timer(this.components);
            this.panelBasicInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelProduction.SuspendLayout();
            this.panelMaterials.SuspendLayout();
            this.panelFacilities.SuspendLayout();
            this.panelQuality.SuspendLayout();
            this.panelMonitering.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBasicInfo
            // 
            this.panelBasicInfo.Controls.Add(this.btnNonMovingType);
            this.panelBasicInfo.Controls.Add(this.btnEquipment);
            this.panelBasicInfo.Controls.Add(this.btnInspectionSt);
            this.panelBasicInfo.Controls.Add(this.btnErrorCode);
            this.panelBasicInfo.Controls.Add(this.btnSubject);
            this.panelBasicInfo.Controls.Add(this.btnEmployee);
            this.panelBasicInfo.Controls.Add(this.btnBasicInfo);
            this.panelBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasicInfo.Location = new System.Drawing.Point(3, 3);
            this.panelBasicInfo.MaximumSize = new System.Drawing.Size(168, 222);
            this.panelBasicInfo.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelBasicInfo.Name = "panelBasicInfo";
            this.panelBasicInfo.Size = new System.Drawing.Size(168, 51);
            this.panelBasicInfo.TabIndex = 1;
            // 
            // btnNonMovingType
            // 
            this.btnNonMovingType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnNonMovingType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNonMovingType.FlatAppearance.BorderSize = 0;
            this.btnNonMovingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonMovingType.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNonMovingType.ForeColor = System.Drawing.Color.White;
            this.btnNonMovingType.Location = new System.Drawing.Point(0, 196);
            this.btnNonMovingType.Name = "btnNonMovingType";
            this.btnNonMovingType.Size = new System.Drawing.Size(168, 29);
            this.btnNonMovingType.TabIndex = 14;
            this.btnNonMovingType.Text = "비가동유형관리";
            this.btnNonMovingType.UseVisualStyleBackColor = false;
            // 
            // btnEquipment
            // 
            this.btnEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipment.FlatAppearance.BorderSize = 0;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEquipment.ForeColor = System.Drawing.Color.White;
            this.btnEquipment.Location = new System.Drawing.Point(0, 167);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(168, 29);
            this.btnEquipment.TabIndex = 13;
            this.btnEquipment.Text = "설비정보";
            this.btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnInspectionSt
            // 
            this.btnInspectionSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnInspectionSt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInspectionSt.FlatAppearance.BorderSize = 0;
            this.btnInspectionSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectionSt.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInspectionSt.ForeColor = System.Drawing.Color.White;
            this.btnInspectionSt.Location = new System.Drawing.Point(0, 138);
            this.btnInspectionSt.Name = "btnInspectionSt";
            this.btnInspectionSt.Size = new System.Drawing.Size(168, 29);
            this.btnInspectionSt.TabIndex = 12;
            this.btnInspectionSt.Text = "검사기준정보";
            this.btnInspectionSt.UseVisualStyleBackColor = false;
            // 
            // btnErrorCode
            // 
            this.btnErrorCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnErrorCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnErrorCode.FlatAppearance.BorderSize = 0;
            this.btnErrorCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorCode.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnErrorCode.ForeColor = System.Drawing.Color.White;
            this.btnErrorCode.Location = new System.Drawing.Point(0, 109);
            this.btnErrorCode.Name = "btnErrorCode";
            this.btnErrorCode.Size = new System.Drawing.Size(168, 29);
            this.btnErrorCode.TabIndex = 11;
            this.btnErrorCode.Text = "불량 정보";
            this.btnErrorCode.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.Location = new System.Drawing.Point(0, 80);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(168, 29);
            this.btnSubject.TabIndex = 10;
            this.btnSubject.Text = "품목 정보";
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 51);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(168, 29);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.Text = "사원 정보";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnBasicInfo
            // 
            this.btnBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicInfo.FlatAppearance.BorderSize = 0;
            this.btnBasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicInfo.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBasicInfo.ForeColor = System.Drawing.Color.White;
            this.btnBasicInfo.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.btnBasicInfo.Name = "btnBasicInfo";
            this.btnBasicInfo.Size = new System.Drawing.Size(168, 51);
            this.btnBasicInfo.TabIndex = 8;
            this.btnBasicInfo.Text = "기준 정보";
            this.btnBasicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasicInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBasicInfo.UseVisualStyleBackColor = false;
            this.btnBasicInfo.Click += new System.EventHandler(this.BtnBasicInfo_Click);
            // 
            // timerBasicDropDown
            // 
            this.timerBasicDropDown.Interval = 15;
            this.timerBasicDropDown.Tick += new System.EventHandler(this.TimerBasicDropDown_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panelBasicInfo);
            this.flowLayoutPanel1.Controls.Add(this.panelProduction);
            this.flowLayoutPanel1.Controls.Add(this.panelMaterials);
            this.flowLayoutPanel1.Controls.Add(this.panelFacilities);
            this.flowLayoutPanel1.Controls.Add(this.panelQuality);
            this.flowLayoutPanel1.Controls.Add(this.panelMonitering);
            this.flowLayoutPanel1.Controls.Add(this.panelStatistics);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 711);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelProduction
            // 
            this.panelProduction.Controls.Add(this.btnProcessDefect);
            this.panelProduction.Controls.Add(this.btnBarcode);
            this.panelProduction.Controls.Add(this.btnDefectiveProduct);
            this.panelProduction.Controls.Add(this.btnWorker);
            this.panelProduction.Controls.Add(this.btnMaterialsManage);
            this.panelProduction.Controls.Add(this.btnWorkLog);
            this.panelProduction.Controls.Add(this.btnProductionHistory);
            this.panelProduction.Controls.Add(this.btnProduction);
            this.panelProduction.Location = new System.Drawing.Point(3, 60);
            this.panelProduction.MaximumSize = new System.Drawing.Size(168, 256);
            this.panelProduction.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelProduction.Name = "panelProduction";
            this.panelProduction.Size = new System.Drawing.Size(168, 51);
            this.panelProduction.TabIndex = 3;
            // 
            // btnProcessDefect
            // 
            this.btnProcessDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnProcessDefect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessDefect.FlatAppearance.BorderSize = 0;
            this.btnProcessDefect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessDefect.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcessDefect.ForeColor = System.Drawing.Color.White;
            this.btnProcessDefect.Location = new System.Drawing.Point(0, 225);
            this.btnProcessDefect.Name = "btnProcessDefect";
            this.btnProcessDefect.Size = new System.Drawing.Size(168, 29);
            this.btnProcessDefect.TabIndex = 18;
            this.btnProcessDefect.Text = "공정불량관리";
            this.btnProcessDefect.UseVisualStyleBackColor = false;
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarcode.FlatAppearance.BorderSize = 0;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBarcode.ForeColor = System.Drawing.Color.White;
            this.btnBarcode.Location = new System.Drawing.Point(0, 196);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(168, 29);
            this.btnBarcode.TabIndex = 17;
            this.btnBarcode.Text = "바코드라벨관리";
            this.btnBarcode.UseVisualStyleBackColor = false;
            // 
            // btnDefectiveProduct
            // 
            this.btnDefectiveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnDefectiveProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDefectiveProduct.FlatAppearance.BorderSize = 0;
            this.btnDefectiveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefectiveProduct.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDefectiveProduct.ForeColor = System.Drawing.Color.White;
            this.btnDefectiveProduct.Location = new System.Drawing.Point(0, 167);
            this.btnDefectiveProduct.Name = "btnDefectiveProduct";
            this.btnDefectiveProduct.Size = new System.Drawing.Size(168, 29);
            this.btnDefectiveProduct.TabIndex = 16;
            this.btnDefectiveProduct.Text = "불량 관리";
            this.btnDefectiveProduct.UseVisualStyleBackColor = false;
            // 
            // btnWorker
            // 
            this.btnWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorker.FlatAppearance.BorderSize = 0;
            this.btnWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorker.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorker.ForeColor = System.Drawing.Color.White;
            this.btnWorker.Location = new System.Drawing.Point(0, 138);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(168, 29);
            this.btnWorker.TabIndex = 15;
            this.btnWorker.Text = "작업자 관리";
            this.btnWorker.UseVisualStyleBackColor = false;
            // 
            // btnMaterialsManage
            // 
            this.btnMaterialsManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnMaterialsManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialsManage.FlatAppearance.BorderSize = 0;
            this.btnMaterialsManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialsManage.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterialsManage.ForeColor = System.Drawing.Color.White;
            this.btnMaterialsManage.Location = new System.Drawing.Point(0, 109);
            this.btnMaterialsManage.Name = "btnMaterialsManage";
            this.btnMaterialsManage.Size = new System.Drawing.Size(168, 29);
            this.btnMaterialsManage.TabIndex = 14;
            this.btnMaterialsManage.Text = "자재투입관리";
            this.btnMaterialsManage.UseVisualStyleBackColor = false;
            // 
            // btnWorkLog
            // 
            this.btnWorkLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnWorkLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkLog.FlatAppearance.BorderSize = 0;
            this.btnWorkLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkLog.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkLog.ForeColor = System.Drawing.Color.White;
            this.btnWorkLog.Location = new System.Drawing.Point(0, 80);
            this.btnWorkLog.Name = "btnWorkLog";
            this.btnWorkLog.Size = new System.Drawing.Size(168, 29);
            this.btnWorkLog.TabIndex = 13;
            this.btnWorkLog.Text = "작업 일지";
            this.btnWorkLog.UseVisualStyleBackColor = false;
            // 
            // btnProductionHistory
            // 
            this.btnProductionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnProductionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionHistory.FlatAppearance.BorderSize = 0;
            this.btnProductionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionHistory.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProductionHistory.ForeColor = System.Drawing.Color.White;
            this.btnProductionHistory.Location = new System.Drawing.Point(0, 51);
            this.btnProductionHistory.Name = "btnProductionHistory";
            this.btnProductionHistory.Size = new System.Drawing.Size(168, 29);
            this.btnProductionHistory.TabIndex = 12;
            this.btnProductionHistory.Text = "생산이력관리";
            this.btnProductionHistory.UseVisualStyleBackColor = false;
            // 
            // btnProduction
            // 
            this.btnProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduction.FlatAppearance.BorderSize = 0;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduction.ForeColor = System.Drawing.Color.White;
            this.btnProduction.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnProduction.Location = new System.Drawing.Point(0, 0);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(168, 51);
            this.btnProduction.TabIndex = 10;
            this.btnProduction.Text = "생 산";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProduction.UseVisualStyleBackColor = false;
            this.btnProduction.Click += new System.EventHandler(this.BtnProduction_Click);
            // 
            // panelMaterials
            // 
            this.panelMaterials.Controls.Add(this.btnMaterialsHistory);
            this.panelMaterials.Controls.Add(this.btnMaterialsInRe);
            this.panelMaterials.Controls.Add(this.btnMaterialsInOut);
            this.panelMaterials.Controls.Add(this.btnMaterials);
            this.panelMaterials.Location = new System.Drawing.Point(3, 117);
            this.panelMaterials.MaximumSize = new System.Drawing.Size(168, 138);
            this.panelMaterials.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelMaterials.Name = "panelMaterials";
            this.panelMaterials.Size = new System.Drawing.Size(168, 51);
            this.panelMaterials.TabIndex = 17;
            // 
            // btnMaterialsHistory
            // 
            this.btnMaterialsHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnMaterialsHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialsHistory.FlatAppearance.BorderSize = 0;
            this.btnMaterialsHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialsHistory.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterialsHistory.ForeColor = System.Drawing.Color.White;
            this.btnMaterialsHistory.Location = new System.Drawing.Point(0, 109);
            this.btnMaterialsHistory.Name = "btnMaterialsHistory";
            this.btnMaterialsHistory.Size = new System.Drawing.Size(168, 29);
            this.btnMaterialsHistory.TabIndex = 14;
            this.btnMaterialsHistory.Text = "자재이력관리";
            this.btnMaterialsHistory.UseVisualStyleBackColor = false;
            // 
            // btnMaterialsInRe
            // 
            this.btnMaterialsInRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnMaterialsInRe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialsInRe.FlatAppearance.BorderSize = 0;
            this.btnMaterialsInRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialsInRe.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterialsInRe.ForeColor = System.Drawing.Color.White;
            this.btnMaterialsInRe.Location = new System.Drawing.Point(0, 80);
            this.btnMaterialsInRe.Name = "btnMaterialsInRe";
            this.btnMaterialsInRe.Size = new System.Drawing.Size(168, 29);
            this.btnMaterialsInRe.TabIndex = 13;
            this.btnMaterialsInRe.Text = "자재투입반품관리";
            this.btnMaterialsInRe.UseVisualStyleBackColor = false;
            // 
            // btnMaterialsInOut
            // 
            this.btnMaterialsInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnMaterialsInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialsInOut.FlatAppearance.BorderSize = 0;
            this.btnMaterialsInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialsInOut.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterialsInOut.ForeColor = System.Drawing.Color.White;
            this.btnMaterialsInOut.Location = new System.Drawing.Point(0, 51);
            this.btnMaterialsInOut.Name = "btnMaterialsInOut";
            this.btnMaterialsInOut.Size = new System.Drawing.Size(168, 29);
            this.btnMaterialsInOut.TabIndex = 12;
            this.btnMaterialsInOut.Text = "자재입출고관리";
            this.btnMaterialsInOut.UseVisualStyleBackColor = false;
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterials.ForeColor = System.Drawing.Color.White;
            this.btnMaterials.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnMaterials.Location = new System.Drawing.Point(0, 0);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(168, 51);
            this.btnMaterials.TabIndex = 10;
            this.btnMaterials.Text = "자 재";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.BtnMaterials_Click);
            // 
            // panelFacilities
            // 
            this.panelFacilities.Controls.Add(this.btnFacilitiesHistory);
            this.panelFacilities.Controls.Add(this.btnFacilitiesError);
            this.panelFacilities.Controls.Add(this.btnFacilitiesPower);
            this.panelFacilities.Controls.Add(this.btnFacilities);
            this.panelFacilities.Location = new System.Drawing.Point(3, 174);
            this.panelFacilities.MaximumSize = new System.Drawing.Size(168, 138);
            this.panelFacilities.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelFacilities.Name = "panelFacilities";
            this.panelFacilities.Size = new System.Drawing.Size(168, 51);
            this.panelFacilities.TabIndex = 18;
            // 
            // btnFacilitiesHistory
            // 
            this.btnFacilitiesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnFacilitiesHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilitiesHistory.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesHistory.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacilitiesHistory.ForeColor = System.Drawing.Color.White;
            this.btnFacilitiesHistory.Location = new System.Drawing.Point(0, 109);
            this.btnFacilitiesHistory.Name = "btnFacilitiesHistory";
            this.btnFacilitiesHistory.Size = new System.Drawing.Size(168, 29);
            this.btnFacilitiesHistory.TabIndex = 14;
            this.btnFacilitiesHistory.Text = "설비이력관리";
            this.btnFacilitiesHistory.UseVisualStyleBackColor = false;
            // 
            // btnFacilitiesError
            // 
            this.btnFacilitiesError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnFacilitiesError.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilitiesError.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesError.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacilitiesError.ForeColor = System.Drawing.Color.White;
            this.btnFacilitiesError.Location = new System.Drawing.Point(0, 80);
            this.btnFacilitiesError.Name = "btnFacilitiesError";
            this.btnFacilitiesError.Size = new System.Drawing.Size(168, 29);
            this.btnFacilitiesError.TabIndex = 13;
            this.btnFacilitiesError.Text = "설비이상관리";
            this.btnFacilitiesError.UseVisualStyleBackColor = false;
            // 
            // btnFacilitiesPower
            // 
            this.btnFacilitiesPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnFacilitiesPower.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilitiesPower.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesPower.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacilitiesPower.ForeColor = System.Drawing.Color.White;
            this.btnFacilitiesPower.Location = new System.Drawing.Point(0, 51);
            this.btnFacilitiesPower.Name = "btnFacilitiesPower";
            this.btnFacilitiesPower.Size = new System.Drawing.Size(168, 29);
            this.btnFacilitiesPower.TabIndex = 12;
            this.btnFacilitiesPower.Text = "설비가동/비가동관리";
            this.btnFacilitiesPower.UseVisualStyleBackColor = false;
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnFacilities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacilities.ForeColor = System.Drawing.Color.White;
            this.btnFacilities.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnFacilities.Location = new System.Drawing.Point(0, 0);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(168, 51);
            this.btnFacilities.TabIndex = 10;
            this.btnFacilities.Text = "설 비";
            this.btnFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.Click += new System.EventHandler(this.BtnFacilities_Click);
            // 
            // panelQuality
            // 
            this.panelQuality.Controls.Add(this.btnLastInspection);
            this.panelQuality.Controls.Add(this.btnProcessInspection);
            this.panelQuality.Controls.Add(this.btnFirstInspection);
            this.panelQuality.Controls.Add(this.btnQuality);
            this.panelQuality.Location = new System.Drawing.Point(3, 231);
            this.panelQuality.MaximumSize = new System.Drawing.Size(168, 138);
            this.panelQuality.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelQuality.Name = "panelQuality";
            this.panelQuality.Size = new System.Drawing.Size(168, 51);
            this.panelQuality.TabIndex = 20;
            // 
            // btnLastInspection
            // 
            this.btnLastInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnLastInspection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLastInspection.FlatAppearance.BorderSize = 0;
            this.btnLastInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastInspection.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLastInspection.ForeColor = System.Drawing.Color.Black;
            this.btnLastInspection.Location = new System.Drawing.Point(0, 109);
            this.btnLastInspection.Name = "btnLastInspection";
            this.btnLastInspection.Size = new System.Drawing.Size(168, 29);
            this.btnLastInspection.TabIndex = 14;
            this.btnLastInspection.Text = "출하전검사관리";
            this.btnLastInspection.UseVisualStyleBackColor = false;
            // 
            // btnProcessInspection
            // 
            this.btnProcessInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnProcessInspection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessInspection.FlatAppearance.BorderSize = 0;
            this.btnProcessInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessInspection.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcessInspection.ForeColor = System.Drawing.Color.Black;
            this.btnProcessInspection.Location = new System.Drawing.Point(0, 80);
            this.btnProcessInspection.Name = "btnProcessInspection";
            this.btnProcessInspection.Size = new System.Drawing.Size(168, 29);
            this.btnProcessInspection.TabIndex = 13;
            this.btnProcessInspection.Text = "공정검사관리";
            this.btnProcessInspection.UseVisualStyleBackColor = false;
            // 
            // btnFirstInspection
            // 
            this.btnFirstInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnFirstInspection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFirstInspection.FlatAppearance.BorderSize = 0;
            this.btnFirstInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstInspection.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFirstInspection.ForeColor = System.Drawing.Color.Black;
            this.btnFirstInspection.Location = new System.Drawing.Point(0, 51);
            this.btnFirstInspection.Name = "btnFirstInspection";
            this.btnFirstInspection.Size = new System.Drawing.Size(168, 29);
            this.btnFirstInspection.TabIndex = 12;
            this.btnFirstInspection.Text = "수입검사관리";
            this.btnFirstInspection.UseVisualStyleBackColor = false;
            // 
            // btnQuality
            // 
            this.btnQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnQuality.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuality.FlatAppearance.BorderSize = 0;
            this.btnQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuality.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQuality.ForeColor = System.Drawing.Color.Black;
            this.btnQuality.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnQuality.Location = new System.Drawing.Point(0, 0);
            this.btnQuality.Name = "btnQuality";
            this.btnQuality.Size = new System.Drawing.Size(168, 51);
            this.btnQuality.TabIndex = 10;
            this.btnQuality.Text = "품 질";
            this.btnQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuality.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuality.UseVisualStyleBackColor = false;
            this.btnQuality.Click += new System.EventHandler(this.BtnQuality_Click);
            // 
            // panelMonitering
            // 
            this.panelMonitering.Controls.Add(this.btnQualityMonitering);
            this.panelMonitering.Controls.Add(this.btnFacilitiesMonitering);
            this.panelMonitering.Controls.Add(this.btnProStatusMonitering);
            this.panelMonitering.Controls.Add(this.btnProPerformanceMoniTering);
            this.panelMonitering.Controls.Add(this.btnMonitering);
            this.panelMonitering.Location = new System.Drawing.Point(3, 288);
            this.panelMonitering.MaximumSize = new System.Drawing.Size(168, 167);
            this.panelMonitering.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelMonitering.Name = "panelMonitering";
            this.panelMonitering.Size = new System.Drawing.Size(168, 51);
            this.panelMonitering.TabIndex = 21;
            // 
            // btnQualityMonitering
            // 
            this.btnQualityMonitering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnQualityMonitering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQualityMonitering.FlatAppearance.BorderSize = 0;
            this.btnQualityMonitering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMonitering.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMonitering.ForeColor = System.Drawing.Color.Black;
            this.btnQualityMonitering.Location = new System.Drawing.Point(0, 138);
            this.btnQualityMonitering.Name = "btnQualityMonitering";
            this.btnQualityMonitering.Size = new System.Drawing.Size(168, 29);
            this.btnQualityMonitering.TabIndex = 15;
            this.btnQualityMonitering.Text = "품질검사모니터링";
            this.btnQualityMonitering.UseVisualStyleBackColor = false;
            // 
            // btnFacilitiesMonitering
            // 
            this.btnFacilitiesMonitering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnFacilitiesMonitering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilitiesMonitering.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesMonitering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesMonitering.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacilitiesMonitering.ForeColor = System.Drawing.Color.Black;
            this.btnFacilitiesMonitering.Location = new System.Drawing.Point(0, 109);
            this.btnFacilitiesMonitering.Name = "btnFacilitiesMonitering";
            this.btnFacilitiesMonitering.Size = new System.Drawing.Size(168, 29);
            this.btnFacilitiesMonitering.TabIndex = 14;
            this.btnFacilitiesMonitering.Text = "설비현황모니터링";
            this.btnFacilitiesMonitering.UseVisualStyleBackColor = false;
            // 
            // btnProStatusMonitering
            // 
            this.btnProStatusMonitering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnProStatusMonitering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProStatusMonitering.FlatAppearance.BorderSize = 0;
            this.btnProStatusMonitering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProStatusMonitering.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProStatusMonitering.ForeColor = System.Drawing.Color.Black;
            this.btnProStatusMonitering.Location = new System.Drawing.Point(0, 80);
            this.btnProStatusMonitering.Name = "btnProStatusMonitering";
            this.btnProStatusMonitering.Size = new System.Drawing.Size(168, 29);
            this.btnProStatusMonitering.TabIndex = 13;
            this.btnProStatusMonitering.Text = "생산현황모니터링";
            this.btnProStatusMonitering.UseVisualStyleBackColor = false;
            // 
            // btnProPerformanceMoniTering
            // 
            this.btnProPerformanceMoniTering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnProPerformanceMoniTering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProPerformanceMoniTering.FlatAppearance.BorderSize = 0;
            this.btnProPerformanceMoniTering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProPerformanceMoniTering.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProPerformanceMoniTering.ForeColor = System.Drawing.Color.Black;
            this.btnProPerformanceMoniTering.Location = new System.Drawing.Point(0, 51);
            this.btnProPerformanceMoniTering.Name = "btnProPerformanceMoniTering";
            this.btnProPerformanceMoniTering.Size = new System.Drawing.Size(168, 29);
            this.btnProPerformanceMoniTering.TabIndex = 12;
            this.btnProPerformanceMoniTering.Text = "생산실적모니터링";
            this.btnProPerformanceMoniTering.UseVisualStyleBackColor = false;
            // 
            // btnMonitering
            // 
            this.btnMonitering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnMonitering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitering.FlatAppearance.BorderSize = 0;
            this.btnMonitering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitering.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMonitering.ForeColor = System.Drawing.Color.Black;
            this.btnMonitering.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnMonitering.Location = new System.Drawing.Point(0, 0);
            this.btnMonitering.Name = "btnMonitering";
            this.btnMonitering.Size = new System.Drawing.Size(168, 51);
            this.btnMonitering.TabIndex = 10;
            this.btnMonitering.Text = "모니터링";
            this.btnMonitering.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitering.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMonitering.UseVisualStyleBackColor = false;
            this.btnMonitering.Click += new System.EventHandler(this.BtnMonitering_Click);
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.btnStockStatistics);
            this.panelStatistics.Controls.Add(this.btnErrorStatistics);
            this.panelStatistics.Controls.Add(this.btnProductProcessStatistics);
            this.panelStatistics.Controls.Add(this.btnStatistics);
            this.panelStatistics.Location = new System.Drawing.Point(3, 345);
            this.panelStatistics.MaximumSize = new System.Drawing.Size(168, 139);
            this.panelStatistics.MinimumSize = new System.Drawing.Size(168, 51);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(168, 51);
            this.panelStatistics.TabIndex = 20;
            // 
            // btnStockStatistics
            // 
            this.btnStockStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnStockStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockStatistics.FlatAppearance.BorderSize = 0;
            this.btnStockStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockStatistics.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStockStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStockStatistics.Location = new System.Drawing.Point(0, 109);
            this.btnStockStatistics.Name = "btnStockStatistics";
            this.btnStockStatistics.Size = new System.Drawing.Size(168, 29);
            this.btnStockStatistics.TabIndex = 14;
            this.btnStockStatistics.Text = "재고 현황";
            this.btnStockStatistics.UseVisualStyleBackColor = false;
            // 
            // btnErrorStatistics
            // 
            this.btnErrorStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnErrorStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnErrorStatistics.FlatAppearance.BorderSize = 0;
            this.btnErrorStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorStatistics.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnErrorStatistics.ForeColor = System.Drawing.Color.White;
            this.btnErrorStatistics.Location = new System.Drawing.Point(0, 80);
            this.btnErrorStatistics.Name = "btnErrorStatistics";
            this.btnErrorStatistics.Size = new System.Drawing.Size(168, 29);
            this.btnErrorStatistics.TabIndex = 13;
            this.btnErrorStatistics.Text = "불량/부적합 현황";
            this.btnErrorStatistics.UseVisualStyleBackColor = false;
            // 
            // btnProductProcessStatistics
            // 
            this.btnProductProcessStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnProductProcessStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductProcessStatistics.FlatAppearance.BorderSize = 0;
            this.btnProductProcessStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductProcessStatistics.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProductProcessStatistics.ForeColor = System.Drawing.Color.White;
            this.btnProductProcessStatistics.Location = new System.Drawing.Point(0, 51);
            this.btnProductProcessStatistics.Name = "btnProductProcessStatistics";
            this.btnProductProcessStatistics.Size = new System.Drawing.Size(168, 29);
            this.btnProductProcessStatistics.TabIndex = 12;
            this.btnProductProcessStatistics.Text = "제품/공정별 생산현황";
            this.btnProductProcessStatistics.UseVisualStyleBackColor = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::PCBVI.Properties.Resources.Expand_Arrow_20px;
            this.btnStatistics.Location = new System.Drawing.Point(0, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(168, 51);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "통 계";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // timerProduction
            // 
            this.timerProduction.Interval = 15;
            this.timerProduction.Tick += new System.EventHandler(this.TimerProduction_Tick);
            // 
            // timerMaterials
            // 
            this.timerMaterials.Interval = 15;
            this.timerMaterials.Tick += new System.EventHandler(this.TimerMaterials_Tick);
            // 
            // timerFacilities
            // 
            this.timerFacilities.Interval = 15;
            this.timerFacilities.Tick += new System.EventHandler(this.TimerFacilities_Tick);
            // 
            // timerQuality
            // 
            this.timerQuality.Interval = 15;
            this.timerQuality.Tick += new System.EventHandler(this.TimerQuality_Tick);
            // 
            // timerMonitering
            // 
            this.timerMonitering.Interval = 15;
            this.timerMonitering.Tick += new System.EventHandler(this.TimerMonitering_Tick);
            // 
            // timerStatistics
            // 
            this.timerStatistics.Interval = 15;
            this.timerStatistics.Tick += new System.EventHandler(this.TimerStatistics_Tick);
            // 
            // MainMenulistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainMenulistControl";
            this.Size = new System.Drawing.Size(175, 711);
            this.panelBasicInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelProduction.ResumeLayout(false);
            this.panelMaterials.ResumeLayout(false);
            this.panelFacilities.ResumeLayout(false);
            this.panelQuality.ResumeLayout(false);
            this.panelMonitering.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBasicInfo;
        private System.Windows.Forms.Button btnNonMovingType;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnInspectionSt;
        private System.Windows.Forms.Button btnErrorCode;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnBasicInfo;
        private System.Windows.Forms.Timer timerBasicDropDown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelProduction;
        private System.Windows.Forms.Button btnDefectiveProduct;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnMaterialsManage;
        private System.Windows.Forms.Button btnWorkLog;
        private System.Windows.Forms.Button btnProductionHistory;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Panel panelMaterials;
        private System.Windows.Forms.Button btnMaterialsHistory;
        private System.Windows.Forms.Button btnMaterialsInRe;
        private System.Windows.Forms.Button btnMaterialsInOut;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnProcessDefect;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Timer timerProduction;
        private System.Windows.Forms.Panel panelFacilities;
        private System.Windows.Forms.Button btnFacilitiesHistory;
        private System.Windows.Forms.Button btnFacilitiesError;
        private System.Windows.Forms.Button btnFacilitiesPower;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Timer timerMaterials;
        private System.Windows.Forms.Timer timerFacilities;
        private System.Windows.Forms.Panel panelQuality;
        private System.Windows.Forms.Button btnLastInspection;
        private System.Windows.Forms.Button btnProcessInspection;
        private System.Windows.Forms.Button btnFirstInspection;
        private System.Windows.Forms.Button btnQuality;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Panel panelMonitering;
        private System.Windows.Forms.Button btnFacilitiesMonitering;
        private System.Windows.Forms.Button btnProStatusMonitering;
        private System.Windows.Forms.Button btnProPerformanceMoniTering;
        private System.Windows.Forms.Button btnMonitering;
        private System.Windows.Forms.Button btnStockStatistics;
        private System.Windows.Forms.Button btnErrorStatistics;
        private System.Windows.Forms.Button btnProductProcessStatistics;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Timer timerQuality;
        private System.Windows.Forms.Button btnQualityMonitering;
        private System.Windows.Forms.Timer timerMonitering;
        private System.Windows.Forms.Timer timerStatistics;
    }
}
