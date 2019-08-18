namespace PCBVI.Forms.Production
{
    partial class MaterialsManageForm
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
            this.naviMaterialManage = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageMateriaManage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Production.MaterialsManage.MateriaMangeListControl();
            this.uscSearch = new PCBVI.Controls.Production.MaterialsManage.MaterialManageSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialManage)).BeginInit();
            this.naviMaterialManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageMateriaManage)).BeginInit();
            this.pageMateriaManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviMaterialManage
            // 
            this.naviMaterialManage.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviMaterialManage.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviMaterialManage.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviMaterialManage.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialManage.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviMaterialManage.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviMaterialManage.Location = new System.Drawing.Point(0, 36);
            this.naviMaterialManage.Name = "naviMaterialManage";
            this.naviMaterialManage.Padding = new System.Windows.Forms.Padding(3);
            this.naviMaterialManage.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.naviMaterialManage.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageMateriaManage});
            this.naviMaterialManage.SelectedIndex = 0;
            this.naviMaterialManage.Size = new System.Drawing.Size(800, 414);
            this.naviMaterialManage.TabIndex = 1;
            this.naviMaterialManage.Text = "navi";
            // 
            // pageMateriaManage
            // 
            this.pageMateriaManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageMateriaManage.Controls.Add(this.uscList);
            this.pageMateriaManage.Controls.Add(this.uscSearch);
            this.pageMateriaManage.Flags = 65534;
            this.pageMateriaManage.LastVisibleSet = true;
            this.pageMateriaManage.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageMateriaManage.Name = "pageMateriaManage";
            this.pageMateriaManage.Size = new System.Drawing.Size(798, 387);
            this.pageMateriaManage.Text = "자재 이력 관리";
            this.pageMateriaManage.ToolTipTitle = "Page ToolTip";
            this.pageMateriaManage.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 75);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 312);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 75);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Production.MaterialsManage.MaterialManageSearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.BackColor = System.Drawing.Color.White;
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(800, 36);
            this.uscTopMenu.TabIndex = 0;
            // 
            // MaterialsManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviMaterialManage);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialsManageForm";
            this.Text = "MaterialsManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialManage)).EndInit();
            this.naviMaterialManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageMateriaManage)).EndInit();
            this.pageMateriaManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviMaterialManage;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageMateriaManage;
        private Controls.Production.MaterialsManage.MateriaMangeListControl uscList;
        private Controls.Production.MaterialsManage.MaterialManageSearch uscSearch;
    }
}