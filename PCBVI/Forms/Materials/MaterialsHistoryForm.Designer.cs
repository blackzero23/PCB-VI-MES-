namespace PCBVI.Forms.Materials
{
    partial class MaterialsHistoryForm
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
            this.naviMaterialHistory = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageMaterialHistory = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Materials.MaterialsHLC();
            this.uscSearch = new PCBVI.Controls.Materials.MaterialsHSC();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialHistory)).BeginInit();
            this.naviMaterialHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageMaterialHistory)).BeginInit();
            this.pageMaterialHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviMaterialHistory
            // 
            this.naviMaterialHistory.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviMaterialHistory.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviMaterialHistory.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviMaterialHistory.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialHistory.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviMaterialHistory.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviMaterialHistory.Location = new System.Drawing.Point(0, 35);
            this.naviMaterialHistory.Name = "naviMaterialHistory";
            this.naviMaterialHistory.Padding = new System.Windows.Forms.Padding(3);
            this.naviMaterialHistory.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageMaterialHistory});
            this.naviMaterialHistory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviMaterialHistory.SelectedIndex = 0;
            this.naviMaterialHistory.Size = new System.Drawing.Size(800, 415);
            this.naviMaterialHistory.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviMaterialHistory.TabIndex = 1;
            this.naviMaterialHistory.Text = "navi";
            // 
            // pageMaterialHistory
            // 
            this.pageMaterialHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageMaterialHistory.Controls.Add(this.uscList);
            this.pageMaterialHistory.Controls.Add(this.uscSearch);
            this.pageMaterialHistory.Flags = 65534;
            this.pageMaterialHistory.LastVisibleSet = true;
            this.pageMaterialHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageMaterialHistory.Name = "pageMaterialHistory";
            this.pageMaterialHistory.Size = new System.Drawing.Size(798, 386);
            this.pageMaterialHistory.Text = "자재 이력";
            this.pageMaterialHistory.ToolTipTitle = "Page ToolTip";
            this.pageMaterialHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 56);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 330);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 56);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Materials.MaterialsHSC.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
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
            // MaterialsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviMaterialHistory);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialsHistoryForm";
            this.Text = "MaterialsHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialHistory)).EndInit();
            this.naviMaterialHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageMaterialHistory)).EndInit();
            this.pageMaterialHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviMaterialHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageMaterialHistory;
        private Controls.Materials.MaterialsHLC uscList;
        private Controls.Materials.MaterialsHSC uscSearch;
    }
}