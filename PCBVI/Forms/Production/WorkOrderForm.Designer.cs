namespace PCBVI.Forms.Production
{
    partial class WorkOrderForm
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
            this.naviWorkOrder = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageWorkOrder = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Production.WorkOrder.WorkOrderListControl();
            this.uscSearch = new PCBVI.Controls.Production.WorkOrder.WorkOrderSearchControl();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviWorkOrder)).BeginInit();
            this.naviWorkOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageWorkOrder)).BeginInit();
            this.pageWorkOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviWorkOrder
            // 
            this.naviWorkOrder.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviWorkOrder.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviWorkOrder.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviWorkOrder.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviWorkOrder.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviWorkOrder.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviWorkOrder.Location = new System.Drawing.Point(0, 36);
            this.naviWorkOrder.Name = "naviWorkOrder";
            this.naviWorkOrder.Padding = new System.Windows.Forms.Padding(3);
            this.naviWorkOrder.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageWorkOrder});
            this.naviWorkOrder.SelectedIndex = 0;
            this.naviWorkOrder.Size = new System.Drawing.Size(800, 414);
            this.naviWorkOrder.TabIndex = 4;
            this.naviWorkOrder.Text = "navi";
            // 
            // pageWorkOrder
            // 
            this.pageWorkOrder.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageWorkOrder.Controls.Add(this.uscList);
            this.pageWorkOrder.Controls.Add(this.uscSearch);
            this.pageWorkOrder.Flags = 65534;
            this.pageWorkOrder.LastVisibleSet = true;
            this.pageWorkOrder.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageWorkOrder.Name = "pageWorkOrder";
            this.pageWorkOrder.Size = new System.Drawing.Size(798, 387);
            this.pageWorkOrder.Text = "바코드 정보";
            this.pageWorkOrder.ToolTipTitle = "Page ToolTip";
            this.pageWorkOrder.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
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
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Production.WorkOrder.WorkOrderSearchControl.SearchButtonClickedEventArgs>(this.WorkOrderSearchControl1_SearchButtonClicked);
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
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviWorkOrder);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkOrderForm";
            this.Text = "WorkOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviWorkOrder)).EndInit();
            this.naviWorkOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageWorkOrder)).EndInit();
            this.pageWorkOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviWorkOrder;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageWorkOrder;
        private Controls.Production.WorkOrder.WorkOrderSearchControl uscSearch;
        private Controls.Production.WorkOrder.WorkOrderListControl uscList;
    }
}