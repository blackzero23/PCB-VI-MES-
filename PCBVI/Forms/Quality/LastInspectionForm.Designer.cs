namespace PCBVI.Forms.Quality
{
    partial class LastInspectionForm
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
            this.naviLastInspection = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageLastInspection = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Quality.LastInspectionList();
            this.uscSearch = new PCBVI.Controls.Quality.LastInspectionSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviLastInspection)).BeginInit();
            this.naviLastInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageLastInspection)).BeginInit();
            this.pageLastInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviLastInspection
            // 
            this.naviLastInspection.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviLastInspection.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviLastInspection.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviLastInspection.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviLastInspection.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviLastInspection.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviLastInspection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviLastInspection.Location = new System.Drawing.Point(0, 35);
            this.naviLastInspection.Name = "naviLastInspection";
            this.naviLastInspection.Padding = new System.Windows.Forms.Padding(3);
            this.naviLastInspection.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageLastInspection});
            this.naviLastInspection.SelectedIndex = 0;
            this.naviLastInspection.Size = new System.Drawing.Size(800, 415);
            this.naviLastInspection.TabIndex = 1;
            this.naviLastInspection.Text = "navi";
            // 
            // pageLastInspection
            // 
            this.pageLastInspection.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageLastInspection.Controls.Add(this.uscList);
            this.pageLastInspection.Controls.Add(this.uscSearch);
            this.pageLastInspection.Flags = 65534;
            this.pageLastInspection.LastVisibleSet = true;
            this.pageLastInspection.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageLastInspection.Name = "pageLastInspection";
            this.pageLastInspection.Size = new System.Drawing.Size(798, 388);
            this.pageLastInspection.Text = "출하검사관리";
            this.pageLastInspection.ToolTipTitle = "Page ToolTip";
            this.pageLastInspection.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 123);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 265);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 123);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Quality.LastInspectionSearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
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
            // LastInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviLastInspection);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LastInspectionForm";
            this.Text = "LastInspectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviLastInspection)).EndInit();
            this.naviLastInspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageLastInspection)).EndInit();
            this.pageLastInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviLastInspection;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageLastInspection;
        private Controls.Quality.LastInspectionSearch uscSearch;
        private Controls.Quality.LastInspectionList uscList;
    }
}