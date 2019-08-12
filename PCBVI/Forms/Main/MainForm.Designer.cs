namespace PCBVI.Forms.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.uscMenuBar = new PCBVI.Controls.MainControls.MainMenulistControl();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLogOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(175, 43);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panelContainer.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonBreadCrumb;
            this.panelContainer.Size = new System.Drawing.Size(625, 407);
            this.panelContainer.TabIndex = 1;
            // 
            // uscMenuBar
            // 
            this.uscMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.uscMenuBar.Location = new System.Drawing.Point(0, 43);
            this.uscMenuBar.Name = "uscMenuBar";
            this.uscMenuBar.Size = new System.Drawing.Size(175, 407);
            this.uscMenuBar.TabIndex = 0;
            this.uscMenuBar.EmployeeButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.EmployeeButtonClickedEventArgs>(this.UscMenuBar_EmployeeButtonClicked);
            this.uscMenuBar.SubjectButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.SubjectButtonClickedEventArgs>(this.UscMenuBar_SubjectButtonClicked);
            this.uscMenuBar.ErrorCodeButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.ErrorCodeButtonClickedEventArgs>(this.UscMenuBar_ErrorCodeButtonClicked);
            this.uscMenuBar.InspectionStButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.InspectionStButtonClickedEventArgs>(this.UscMenuBar_InspectionStButtonClicked);
            this.uscMenuBar.EquipmentButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.EquipmentButtonClickedEventArgs>(this.UscMenuBar_EquipmentButtonClicked);
            this.uscMenuBar.ProductionHistoryButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.ProductionHistoryButtonClickedEventArgs>(this.UscMenuBar_ProductionHistoryButtonClicked);
            this.uscMenuBar.WorkLogButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.WorkLogButtonClickedEventArgs>(this.UscMenuBar_WorkLogButtonClicked);
            this.uscMenuBar.MaterialManageButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.MaterialManageButtonClickedEventArgs>(this.UscMenuBar_MaterialManageButtonClicked);
            this.uscMenuBar.WorkerButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.WorkerButtonClickedEventArgs>(this.UscMenuBar_WorkerButtonClicked);
            this.uscMenuBar.DefectiveProductButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.DefectiveProductButtonClickedEventArgs>(this.UscMenuBar_DefectiveProductButtonClicked);
            this.uscMenuBar.BarcodeButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.BarcodeButtonClickedEventArgs>(this.UscMenuBar_BarcodeButtonClicked);
            this.uscMenuBar.ProcessDefectButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.ProcessDefectButtonClickedEventArgs>(this.UscMenuBar_ProcessDefectButtonClicked);
            this.uscMenuBar.NonMovingTypeButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.NonMovingTypeButtonClickedEventArgs>(this.UscMenuBar_NonMovingTypeButtonClicked);
            this.uscMenuBar.MaterialsInOutButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.MaterialsInOutButtonClickedEventArgs>(this.UscMenuBar_MaterialsInOutButtonClicked);
            this.uscMenuBar.MaterialsInReButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.MaterialsInReButtonClickedEventArgs>(this.UscMenuBar_MaterialsInReButtonClicked);
            this.uscMenuBar.MaterialsHistoryButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.MaterialsHistoryButtonClickedEventArgs>(this.UscMenuBar_MaterialsHistoryButtonClicked);
            this.uscMenuBar.FacilitiesPowerButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.FacilitiesPowerButtonClickedEventArgs>(this.UscMenuBar_FacilitiesPowerButtonClicked);
            this.uscMenuBar.FacilitiesErrorButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.FacilitiesErrorButtonClickedEventArgs>(this.UscMenuBar_FacilitiesErrorButtonClicked);
            this.uscMenuBar.FacilitiesHistoryButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.FacilitiesHistoryButtonClickedEventArgs>(this.UscMenuBar_FacilitiesHistoryButtonClicked);
            this.uscMenuBar.FirstInspectionButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.FirstInspectionButtonClickedEventArgs>(this.UscMenuBar_FirstInspectionButtonClicked);
            this.uscMenuBar.ProcessInspectionButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.ProcessInspectionButtonClickedEventArgs>(this.UscMenuBar_ProcessInspectionButtonClicked);
            this.uscMenuBar.LastInspectionButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.LastInspectionButtonClickedEventArgs>(this.UscMenuBar_LastInspectionButtonClicked);
            this.uscMenuBar.PPMonitoringButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.PPMonitoringButtonClickedEventArgs>(this.UscMenuBar_PPMonitoringButtonClicked);
            this.uscMenuBar.PSMonitoringButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.PSMonitoringButtonClickedEventArgs>(this.UscMenuBar_PSMonitoringButtonClicked);
            this.uscMenuBar.FacilitiesButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.FacilitiesButtonClickedEventArgs>(this.UscMenuBar_FacilitiesButtonClicked);
            this.uscMenuBar.QualityButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.QualityButtonClickedEventArgs>(this.UscMenuBar_QualityButtonClicked);
            this.uscMenuBar.PPStatisticsButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.PPStatisticsButtonClickedEventArgs>(this.UscMenuBar_PPStatisticsButtonClicked);
            this.uscMenuBar.ErrorStatisticsButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.ErrorStatisticsButtonClickedEventArgs>(this.UscMenuBar_ErrorStatisticsButtonClicked);
            this.uscMenuBar.StockStatisticsButtonClicked += new System.EventHandler<PCBVI.Controls.MainControls.MainMenulistControl.StockStatisticsButtonClickedEventArgs>(this.UscMenuBar_StockStatisticsButtonClicked);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnLogOut);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 43);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(735, 13);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(40, 25);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Values.Text = "로그아웃";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(651, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel1.Size = new System.Drawing.Size(77, 22);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "로그인 처리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCB-VI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.uscMenuBar);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MainForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.ShowIcon = false;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MainControls.MainMenulistControl uscMenuBar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogOut;
    }
}