namespace PCBVI.Forms
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ptbMin = new System.Windows.Forms.PictureBox();
            this.ptbMinimi = new System.Windows.Forms.PictureBox();
            this.ptbMax = new System.Windows.Forms.PictureBox();
            this.ptbCnacle = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.uscMenuBar = new PCBVI.Controls.MainControls.MainMenulistControl();
            this.panelMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCnacle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.ForeColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(175, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(625, 642);
            this.panelContainer.TabIndex = 2;
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelMainTitle.Controls.Add(this.lbTitle);
            this.panelMainTitle.Controls.Add(this.ptbMin);
            this.panelMainTitle.Controls.Add(this.ptbMinimi);
            this.panelMainTitle.Controls.Add(this.ptbMax);
            this.panelMainTitle.Controls.Add(this.ptbCnacle);
            this.panelMainTitle.Controls.Add(this.maskedTextBox1);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.ForeColor = System.Drawing.Color.White;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(800, 33);
            this.panelMainTitle.TabIndex = 1;
            this.panelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMainTitle_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("배달의민족 주아", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.Location = new System.Drawing.Point(35, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(103, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "PK Vision";
            // 
            // ptbMin
            // 
            this.ptbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMin.Image = global::PCBVI.Properties.Resources.main_res;
            this.ptbMin.Location = new System.Drawing.Point(742, 5);
            this.ptbMin.Name = "ptbMin";
            this.ptbMin.Size = new System.Drawing.Size(20, 20);
            this.ptbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMin.TabIndex = 5;
            this.ptbMin.TabStop = false;
            this.ptbMin.Visible = false;
            this.ptbMin.Click += new System.EventHandler(this.PtbMin_Click);
            // 
            // ptbMinimi
            // 
            this.ptbMinimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimi.Image = global::PCBVI.Properties.Resources.main_minimazar;
            this.ptbMinimi.Location = new System.Drawing.Point(716, 5);
            this.ptbMinimi.Name = "ptbMinimi";
            this.ptbMinimi.Size = new System.Drawing.Size(20, 20);
            this.ptbMinimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimi.TabIndex = 4;
            this.ptbMinimi.TabStop = false;
            this.ptbMinimi.Click += new System.EventHandler(this.PtbMinimi_Click);
            // 
            // ptbMax
            // 
            this.ptbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMax.Image = global::PCBVI.Properties.Resources.main_maxi;
            this.ptbMax.Location = new System.Drawing.Point(742, 5);
            this.ptbMax.Name = "ptbMax";
            this.ptbMax.Size = new System.Drawing.Size(20, 20);
            this.ptbMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMax.TabIndex = 3;
            this.ptbMax.TabStop = false;
            this.ptbMax.Click += new System.EventHandler(this.PtbMax_Click);
            // 
            // ptbCnacle
            // 
            this.ptbCnacle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCnacle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCnacle.Image = global::PCBVI.Properties.Resources.main_cerrar;
            this.ptbCnacle.Location = new System.Drawing.Point(768, 5);
            this.ptbCnacle.Name = "ptbCnacle";
            this.ptbCnacle.Size = new System.Drawing.Size(20, 20);
            this.ptbCnacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCnacle.TabIndex = 1;
            this.ptbCnacle.TabStop = false;
            this.ptbCnacle.Click += new System.EventHandler(this.PtbCnacle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(610, 5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Text = "나중에 로그인 처리";
            // 
            // uscMenuBar
            // 
            this.uscMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.uscMenuBar.Location = new System.Drawing.Point(0, 33);
            this.uscMenuBar.Name = "uscMenuBar";
            this.uscMenuBar.Size = new System.Drawing.Size(175, 642);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.uscMenuBar);
            this.Controls.Add(this.panelMainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCnacle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MainControls.MainMenulistControl uscMenuBar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.PictureBox ptbMin;
        private System.Windows.Forms.PictureBox ptbMinimi;
        private System.Windows.Forms.PictureBox ptbMax;
        private System.Windows.Forms.PictureBox ptbCnacle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbTitle;
    }
}