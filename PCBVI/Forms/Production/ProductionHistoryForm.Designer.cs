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
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.productionList1 = new PCBVI.Controls.Production.ProductionHistory.ProductionList();
            this.productionSearch1 = new PCBVI.Controls.Production.ProductionHistory.ProductionSearch();
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
            this.naviProductionHistory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviProductionHistory.SelectedIndex = 0;
            this.naviProductionHistory.Size = new System.Drawing.Size(800, 415);
            this.naviProductionHistory.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviProductionHistory.TabIndex = 1;
            this.naviProductionHistory.Text = "navi";
            // 
            // pageProductionHistory
            // 
            this.pageProductionHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageProductionHistory.Controls.Add(this.productionSearch1);
            this.pageProductionHistory.Controls.Add(this.productionList1);
            this.pageProductionHistory.Flags = 65534;
            this.pageProductionHistory.LastVisibleSet = true;
            this.pageProductionHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageProductionHistory.Name = "pageProductionHistory";
            this.pageProductionHistory.Size = new System.Drawing.Size(798, 386);
            this.pageProductionHistory.Text = "생산 이력";
            this.pageProductionHistory.ToolTipTitle = "Page ToolTip";
            this.pageProductionHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
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
            // productionList1
            // 
            this.productionList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionList1.Location = new System.Drawing.Point(0, 0);
            this.productionList1.Name = "productionList1";
            this.productionList1.Size = new System.Drawing.Size(798, 386);
            this.productionList1.TabIndex = 0;
            // 
            // productionSearch1
            // 
            this.productionSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.productionSearch1.Location = new System.Drawing.Point(0, 0);
            this.productionSearch1.Name = "productionSearch1";
            this.productionSearch1.Size = new System.Drawing.Size(798, 64);
            this.productionSearch1.TabIndex = 1;
            // 
            // ProductionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviProductionHistory);
            this.Controls.Add(this.topMenubar1);
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

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviProductionHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageProductionHistory;
        private Controls.Production.ProductionHistory.ProductionSearch productionSearch1;
        private Controls.Production.ProductionHistory.ProductionList productionList1;
    }
}