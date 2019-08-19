namespace PCBVI.Forms.Basic
{
    partial class InspectionStForm
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
            this.naviEmployee = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageEmployee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Basic.InspectionStandard.InspectionStandardList();
            this.uscSearch = new PCBVI.Controls.Basic.InspectionStandard.InspectionStandardSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).BeginInit();
            this.naviEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).BeginInit();
            this.pageEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviEmployee
            // 
            this.naviEmployee.Bar.BarMapExtraText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None;
            this.naviEmployee.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviEmployee.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviEmployee.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameHeight;
            this.naviEmployee.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.Context;
            this.naviEmployee.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviEmployee.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviEmployee.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small;
            this.naviEmployee.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.naviEmployee.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviEmployee.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviEmployee.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviEmployee.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviEmployee.Location = new System.Drawing.Point(0, 35);
            this.naviEmployee.Name = "naviEmployee";
            this.naviEmployee.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.naviEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.naviEmployee.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageEmployee});
            this.naviEmployee.SelectedIndex = 0;
            this.naviEmployee.Size = new System.Drawing.Size(800, 415);
            this.naviEmployee.TabIndex = 2;
            this.naviEmployee.Text = "navi";
            // 
            // pageEmployee
            // 
            this.pageEmployee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEmployee.Controls.Add(this.uscList);
            this.pageEmployee.Controls.Add(this.uscSearch);
            this.pageEmployee.Flags = 65534;
            this.pageEmployee.LastVisibleSet = true;
            this.pageEmployee.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEmployee.Name = "pageEmployee";
            this.pageEmployee.Size = new System.Drawing.Size(798, 388);
            this.pageEmployee.Text = "검사기준정보";
            this.pageEmployee.ToolTipTitle = "Page ToolTip";
            this.pageEmployee.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 75);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 313);
            this.uscList.TabIndex = 1;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 75);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Basic.InspectionStandard.InspectionStandardSearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
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
            this.uscTopMenu.ExcelButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs>(this.UscTopMenu_ExcelButtonClicked);
            // 
            // InspectionStForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviEmployee);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionStForm";
            this.Text = "InspectionStForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).EndInit();
            this.naviEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).EndInit();
            this.pageEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviEmployee;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEmployee;
        private Controls.Basic.InspectionStandard.InspectionStandardSearch uscSearch;
        private Controls.Basic.InspectionStandard.InspectionStandardList uscList;
    }
}