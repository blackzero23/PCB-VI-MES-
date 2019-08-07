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
            this.txbtj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vspLineTv
            // 
            this.vspLineTv.Location = new System.Drawing.Point(272, 48);
            this.vspLineTv.Name = "vspLineTv";
            this.vspLineTv.Size = new System.Drawing.Size(252, 173);
            this.vspLineTv.TabIndex = 0;
            this.vspLineTv.Text = "videoSourcePlayer1";
            this.vspLineTv.VideoSource = null;
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.Location = new System.Drawing.Point(552, 48);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(33, 26);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Values.Image = global::PCBVI.Properties.Resources.icons8_settings_20px;
            this.btnSetting.Values.Text = "";
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // txbtj
            // 
            this.txbtj.Location = new System.Drawing.Point(335, 359);
            this.txbtj.Name = "txbtj";
            this.txbtj.Size = new System.Drawing.Size(100, 21);
            this.txbtj.TabIndex = 2;
            // 
            // FacilitiesMonitoringFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbtj);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.vspLineTv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacilitiesMonitoringFormcs";
            this.Text = "FacilitiesMonitoringFormcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacilitiesMonitoringFormcs_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vspLineTv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSetting;
        private System.Windows.Forms.TextBox txbtj;
    }
}