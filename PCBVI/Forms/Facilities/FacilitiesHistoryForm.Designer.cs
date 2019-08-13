namespace PCBVI.Forms.Facilities
{
    partial class FacilitiesHistoryForm
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
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.naviFacilitiesHistory = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageFacilitiesHistory = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.facilitiesHSC1 = new PCBVI.Controls.Facilities.FacilitiesHSC();
            this.facilitiesHLC1 = new PCBVI.Controls.Facilities.FacilitiesHLC();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesHistory)).BeginInit();
            this.naviFacilitiesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesHistory)).BeginInit();
            this.pageFacilitiesHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenubar1
            // 
            this.topMenubar1.BackColor = System.Drawing.Color.White;
            this.topMenubar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenubar1.Location = new System.Drawing.Point(0, 0);
            this.topMenubar1.Name = "topMenubar1";
            this.topMenubar1.Size = new System.Drawing.Size(800, 35);
            this.topMenubar1.TabIndex = 0;
            // 
            // naviFacilitiesHistory
            // 
            this.naviFacilitiesHistory.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviFacilitiesHistory.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviFacilitiesHistory.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviFacilitiesHistory.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFacilitiesHistory.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviFacilitiesHistory.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFacilitiesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviFacilitiesHistory.Location = new System.Drawing.Point(0, 35);
            this.naviFacilitiesHistory.Name = "naviFacilitiesHistory";
            this.naviFacilitiesHistory.Padding = new System.Windows.Forms.Padding(3);
            this.naviFacilitiesHistory.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageFacilitiesHistory});
            this.naviFacilitiesHistory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviFacilitiesHistory.SelectedIndex = 0;
            this.naviFacilitiesHistory.Size = new System.Drawing.Size(800, 415);
            this.naviFacilitiesHistory.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviFacilitiesHistory.TabIndex = 1;
            this.naviFacilitiesHistory.Text = "navi";
            // 
            // pageFacilitiesHistory
            // 
            this.pageFacilitiesHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageFacilitiesHistory.Controls.Add(this.facilitiesHLC1);
            this.pageFacilitiesHistory.Controls.Add(this.facilitiesHSC1);
            this.pageFacilitiesHistory.Flags = 65534;
            this.pageFacilitiesHistory.LastVisibleSet = true;
            this.pageFacilitiesHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageFacilitiesHistory.Name = "pageFacilitiesHistory";
            this.pageFacilitiesHistory.Size = new System.Drawing.Size(798, 386);
            this.pageFacilitiesHistory.Text = "설비 이력";
            this.pageFacilitiesHistory.ToolTipTitle = "Page ToolTip";
            this.pageFacilitiesHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // facilitiesHSC1
            // 
            this.facilitiesHSC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.facilitiesHSC1.Location = new System.Drawing.Point(0, 0);
            this.facilitiesHSC1.Name = "facilitiesHSC1";
            this.facilitiesHSC1.Size = new System.Drawing.Size(798, 109);
            this.facilitiesHSC1.TabIndex = 0;
            // 
            // facilitiesHLC1
            // 
            this.facilitiesHLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilitiesHLC1.Location = new System.Drawing.Point(0, 109);
            this.facilitiesHLC1.Name = "facilitiesHLC1";
            this.facilitiesHLC1.Size = new System.Drawing.Size(798, 277);
            this.facilitiesHLC1.TabIndex = 1;
            // 
            // FacilitiesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviFacilitiesHistory);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacilitiesHistoryForm";
            this.Text = "FacilitiesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesHistory)).EndInit();
            this.naviFacilitiesHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesHistory)).EndInit();
            this.pageFacilitiesHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviFacilitiesHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageFacilitiesHistory;
        private Controls.Facilities.FacilitiesHSC facilitiesHSC1;
        private Controls.Facilities.FacilitiesHLC facilitiesHLC1;
    }
}