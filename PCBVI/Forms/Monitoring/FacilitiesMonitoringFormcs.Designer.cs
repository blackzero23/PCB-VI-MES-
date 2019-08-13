namespace PCBVI.Forms.Monitoring
{
    partial class FacilitiesMonitoringFormcs
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
            this.vspLineTv = new AForge.Controls.VideoSourcePlayer();
            this.btnSetting = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.naviEmployee = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageEmployee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).BeginInit();
            this.naviEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).BeginInit();
            this.pageEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // vspLineTv
            // 
            this.vspLineTv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vspLineTv.Location = new System.Drawing.Point(0, 26);
            this.vspLineTv.Name = "vspLineTv";
            this.vspLineTv.Size = new System.Drawing.Size(300, 224);
            this.vspLineTv.TabIndex = 0;
            this.vspLineTv.Text = "videoSourcePlayer1";
            this.vspLineTv.VideoSource = null;
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(300, 26);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Values.Image = global::PCBVI.Properties.Resources.icons8_settings_20px;
            this.btnSetting.Values.Text = "";
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.vspLineTv);
            this.kryptonPanel1.Controls.Add(this.btnSetting);
            this.kryptonPanel1.Location = new System.Drawing.Point(29, 88);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(300, 250);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.videoSourcePlayer1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Location = new System.Drawing.Point(383, 88);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(300, 250);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 26);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(300, 224);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonButton1.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(300, 26);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Image = global::PCBVI.Properties.Resources.icons8_settings_20px;
            this.kryptonButton1.Values.Text = "";
            // 
            // naviEmployee
            // 
            this.naviEmployee.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviEmployee.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviEmployee.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviEmployee.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviEmployee.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviEmployee.Location = new System.Drawing.Point(0, 0);
            this.naviEmployee.Name = "naviEmployee";
            this.naviEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.naviEmployee.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageEmployee});
            this.naviEmployee.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviEmployee.SelectedIndex = 0;
            this.naviEmployee.Size = new System.Drawing.Size(800, 450);
            this.naviEmployee.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviEmployee.TabIndex = 4;
            this.naviEmployee.Text = "navi";
            // 
            // pageEmployee
            // 
            this.pageEmployee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEmployee.Controls.Add(this.kryptonLabel2);
            this.pageEmployee.Controls.Add(this.kryptonLabel1);
            this.pageEmployee.Controls.Add(this.kryptonPanel1);
            this.pageEmployee.Controls.Add(this.kryptonPanel2);
            this.pageEmployee.Flags = 65534;
            this.pageEmployee.LastVisibleSet = true;
            this.pageEmployee.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEmployee.Name = "pageEmployee";
            this.pageEmployee.Size = new System.Drawing.Size(798, 421);
            this.pageEmployee.Text = "설비 모니터링";
            this.pageEmployee.ToolTipTitle = "Page ToolTip";
            this.pageEmployee.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(144, 344);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "설비 이름";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(502, 344);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "설비 이름";
            // 
            // FacilitiesMonitoringFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacilitiesMonitoringFormcs";
            this.Text = "FacilitiesMonitoringFormcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacilitiesMonitoringFormcs_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).EndInit();
            this.naviEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).EndInit();
            this.pageEmployee.ResumeLayout(false);
            this.pageEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vspLineTv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSetting;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviEmployee;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}