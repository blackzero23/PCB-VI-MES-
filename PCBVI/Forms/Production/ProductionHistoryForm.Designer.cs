namespace PCBVI.Forms.Production
{
    partial class ProductionHistoryForm
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
            this.naviProductionHistory = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageProductionHistory = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscSearch = new PCBVI.Controls.Production.ProductionHistory.ProductionHistorySearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            this.uscList = new PCBVI.Controls.Production.ProductionHistory.ProductionHistoryList();
            ((System.ComponentModel.ISupportInitialize)(this.naviProductionHistory)).BeginInit();
            this.naviProductionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageProductionHistory)).BeginInit();
            this.pageProductionHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviProductionHistory
            // 
            this.naviProductionHistory.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviProductionHistory.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviProductionHistory.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviProductionHistory.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviProductionHistory.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviProductionHistory.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviProductionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviProductionHistory.Location = new System.Drawing.Point(0, 35);
            this.naviProductionHistory.Name = "naviProductionHistory";
            this.naviProductionHistory.Padding = new System.Windows.Forms.Padding(3);
            this.naviProductionHistory.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageProductionHistory});
            this.naviProductionHistory.SelectedIndex = 0;
            this.naviProductionHistory.Size = new System.Drawing.Size(800, 415);
            this.naviProductionHistory.TabIndex = 1;
            this.naviProductionHistory.Text = "navi";
            // 
            // pageProductionHistory
            // 
            this.pageProductionHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageProductionHistory.Controls.Add(this.uscList);
            this.pageProductionHistory.Controls.Add(this.uscSearch);
            this.pageProductionHistory.Flags = 65534;
            this.pageProductionHistory.LastVisibleSet = true;
            this.pageProductionHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageProductionHistory.Name = "pageProductionHistory";
            this.pageProductionHistory.Size = new System.Drawing.Size(798, 388);
            this.pageProductionHistory.Text = "생산 이력";
            this.pageProductionHistory.ToolTipTitle = "Page ToolTip";
            this.pageProductionHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 64);
            this.uscSearch.TabIndex = 1;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Production.ProductionHistory.ProductionHistorySearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.BackColor = System.Drawing.Color.White;
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(800, 35);
            this.uscTopMenu.TabIndex = 0;
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 64);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 324);
            this.uscList.TabIndex = 2;
            // 
            // ProductionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviProductionHistory);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductionHistoryForm";
            this.Text = "ProductionHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviProductionHistory)).EndInit();
            this.naviProductionHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageProductionHistory)).EndInit();
            this.pageProductionHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviProductionHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageProductionHistory;
        private Controls.Production.ProductionHistory.ProductionHistorySearch uscSearch;
        private Controls.Production.ProductionHistory.ProductionHistoryList uscList;
    }
}