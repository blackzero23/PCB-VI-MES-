namespace PCBVI.Forms.Basic
{
    partial class EmployeeForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.naviEmployee = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageEmployee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uscList = new PCBVI.Controls.Basic.Employee.EmployeeList();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.uscSearch = new PCBVI.Controls.Basic.Employee.EmployeeSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).BeginInit();
            this.naviEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).BeginInit();
            this.pageEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.naviEmployee);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 36);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 414);
            this.MainPanel.TabIndex = 1;
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
            this.naviEmployee.Size = new System.Drawing.Size(800, 414);
            this.naviEmployee.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviEmployee.TabIndex = 0;
            this.naviEmployee.Text = "navi";
            // 
            // pageEmployee
            // 
            this.pageEmployee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEmployee.Controls.Add(this.panel1);
            this.pageEmployee.Controls.Add(this.panelSearch);
            this.pageEmployee.Flags = 65534;
            this.pageEmployee.LastVisibleSet = true;
            this.pageEmployee.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEmployee.Name = "pageEmployee";
            this.pageEmployee.Size = new System.Drawing.Size(798, 385);
            this.pageEmployee.Text = "사원 정보";
            this.pageEmployee.ToolTipTitle = "Page ToolTip";
            this.pageEmployee.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uscList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 325);
            this.panel1.TabIndex = 1;
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 0);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(798, 325);
            this.uscList.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.uscSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(798, 60);
            this.panelSearch.TabIndex = 0;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 60);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Basic.Employee.EmployeeSearch.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.BackColor = System.Drawing.Color.White;
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(800, 36);
            this.uscTopMenu.TabIndex = 0;
            this.uscTopMenu.InsertButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs>(this.UscTopMenu_InsertButtonClicked);
            this.uscTopMenu.UpdateButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs>(this.UscTopMenu_UpdateButtonClicked);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).EndInit();
            this.naviEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).EndInit();
            this.pageEmployee.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private System.Windows.Forms.Panel MainPanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviEmployee;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEmployee;
        private System.Windows.Forms.Panel panelSearch;
        private Controls.Basic.Employee.EmployeeSearch uscSearch;
        private System.Windows.Forms.Panel panel1;
        private Controls.Basic.Employee.EmployeeList uscList;
    }
}