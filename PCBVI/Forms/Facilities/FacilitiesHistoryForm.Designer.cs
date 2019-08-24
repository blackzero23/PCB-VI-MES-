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
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            this.naviFacilitiesHistory = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageFacilitiesHistory = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Facilities.FacilitiesHLC();
            this.uscSearch = new PCBVI.Controls.Facilities.FacilitiesHSC();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesHistory)).BeginInit();
            this.naviFacilitiesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesHistory)).BeginInit();
            this.pageFacilitiesHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.BackColor = System.Drawing.Color.White;
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(800, 35);
            this.uscTopMenu.TabIndex = 0;
            this.uscTopMenu.InsertButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs>(this.UscTopMenu_InsertButtonClicked);
            this.uscTopMenu.DeleteButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs>(this.UscTopMenu_DeleteButtonClicked);
            this.uscTopMenu.ExcelButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs>(this.UscTopMenu_ExcelButtonClicked);
            this.uscTopMenu.UpdateButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs>(this.UscTopMenu_UpdateButtonClicked);
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
            this.naviFacilitiesHistory.SelectedIndex = 0;
            this.naviFacilitiesHistory.Size = new System.Drawing.Size(800, 415);
            this.naviFacilitiesHistory.TabIndex = 1;
            this.naviFacilitiesHistory.Text = "navi";
            // 
            // pageFacilitiesHistory
            // 
            this.pageFacilitiesHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageFacilitiesHistory.Controls.Add(this.uscList);
            this.pageFacilitiesHistory.Controls.Add(this.uscSearch);
            this.pageFacilitiesHistory.Flags = 65534;
            this.pageFacilitiesHistory.LastVisibleSet = true;
            this.pageFacilitiesHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageFacilitiesHistory.Name = "pageFacilitiesHistory";
            this.pageFacilitiesHistory.Size = new System.Drawing.Size(798, 388);
            this.pageFacilitiesHistory.Text = "설비 이력";
            this.pageFacilitiesHistory.ToolTipTitle = "Page ToolTip";
            this.pageFacilitiesHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.AutoScroll = true;
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 109);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 279);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 109);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Facilities.FacilitiesHSC.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
            // 
            // FacilitiesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviFacilitiesHistory);
            this.Controls.Add(this.uscTopMenu);
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

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviFacilitiesHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageFacilitiesHistory;
        private Controls.Facilities.FacilitiesHSC uscSearch;
        private Controls.Facilities.FacilitiesHLC uscList;
    }
}