namespace PCBVI.Forms.Quality
{
    partial class FirstInspectionForm
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
            this.naviFirstInspection = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageFirstInspection = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Quality.FirstInspectionList();
            this.uscSearch = new PCBVI.Controls.Quality.FirstInspectionSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviFirstInspection)).BeginInit();
            this.naviFirstInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageFirstInspection)).BeginInit();
            this.pageFirstInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviFirstInspection
            // 
            this.naviFirstInspection.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviFirstInspection.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviFirstInspection.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviFirstInspection.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFirstInspection.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviFirstInspection.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFirstInspection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviFirstInspection.Location = new System.Drawing.Point(0, 35);
            this.naviFirstInspection.Name = "naviFirstInspection";
            this.naviFirstInspection.Padding = new System.Windows.Forms.Padding(3);
            this.naviFirstInspection.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageFirstInspection});
            this.naviFirstInspection.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviFirstInspection.SelectedIndex = 0;
            this.naviFirstInspection.Size = new System.Drawing.Size(800, 415);
            this.naviFirstInspection.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviFirstInspection.TabIndex = 1;
            this.naviFirstInspection.Text = "navi";
            // 
            // pageFirstInspection
            // 
            this.pageFirstInspection.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageFirstInspection.Controls.Add(this.uscList);
            this.pageFirstInspection.Controls.Add(this.uscSearch);
            this.pageFirstInspection.Flags = 65534;
            this.pageFirstInspection.LastVisibleSet = true;
            this.pageFirstInspection.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageFirstInspection.Name = "pageFirstInspection";
            this.pageFirstInspection.Size = new System.Drawing.Size(798, 386);
            this.pageFirstInspection.Text = "수입 검사 관리";
            this.pageFirstInspection.ToolTipTitle = "Page ToolTip";
            this.pageFirstInspection.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 60);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 326);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 60);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Quality.FirstInspectionSearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
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
            // FirstInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviFirstInspection);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstInspectionForm";
            this.Text = "FirstInspectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviFirstInspection)).EndInit();
            this.naviFirstInspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageFirstInspection)).EndInit();
            this.pageFirstInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviFirstInspection;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageFirstInspection;
        private Controls.Quality.FirstInspectionSearch uscSearch;
        private Controls.Quality.FirstInspectionList uscList;
    }
}