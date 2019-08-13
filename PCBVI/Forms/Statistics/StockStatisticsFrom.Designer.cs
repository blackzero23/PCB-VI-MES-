namespace PCBVI.Forms.Statistics
{
    partial class StockStatisticsFrom
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
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BeforeTestStock = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BeforeTest = new PCBVI.Controls.Statistics.StockStatistics();
            this.AfterFirstTestStock = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.AfterFirstTest = new PCBVI.Controls.Statistics.StockStatistics();
            this.AfterTestStock = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.FinalUnGoodStaticTest = new PCBVI.Controls.Statistics.StockStatistics();
            this.WaitinPackageStock = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.stockStatistics4 = new PCBVI.Controls.Statistics.StockStatistics();
            this.FianlStock = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.stockStatistics5 = new PCBVI.Controls.Statistics.StockStatistics();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforeTestStock)).BeginInit();
            this.BeforeTestStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfterFirstTestStock)).BeginInit();
            this.AfterFirstTestStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfterTestStock)).BeginInit();
            this.AfterTestStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitinPackageStock)).BeginInit();
            this.WaitinPackageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FianlStock)).BeginInit();
            this.FianlStock.SuspendLayout();
            this.SuspendLayout();
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
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 35);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.BeforeTestStock,
            this.AfterFirstTestStock,
            this.AfterTestStock,
            this.WaitinPackageStock,
            this.FianlStock});
            this.kryptonNavigator1.SelectedIndex = 4;
            this.kryptonNavigator1.Size = new System.Drawing.Size(800, 415);
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Enabled = false;
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(798, 388);
            this.kryptonPage1.Text = "재고 현황";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "E20447094268458B33A8BE3090C26153";
            // 
            // BeforeTestStock
            // 
            this.BeforeTestStock.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.BeforeTestStock.Controls.Add(this.BeforeTest);
            this.BeforeTestStock.Flags = 65534;
            this.BeforeTestStock.LastVisibleSet = true;
            this.BeforeTestStock.MinimumSize = new System.Drawing.Size(50, 50);
            this.BeforeTestStock.Name = "BeforeTestStock";
            this.BeforeTestStock.Size = new System.Drawing.Size(798, 388);
            this.BeforeTestStock.Text = "미판정 재고 일람";
            this.BeforeTestStock.ToolTipTitle = "Page ToolTip";
            this.BeforeTestStock.UniqueName = "8C4D03E895CD4029CAB9BB395088D8CC";
            // 
            // BeforeTest
            // 
            this.BeforeTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BeforeTest.Location = new System.Drawing.Point(0, 0);
            this.BeforeTest.Name = "BeforeTest";
            this.BeforeTest.Size = new System.Drawing.Size(798, 388);
            this.BeforeTest.TabIndex = 0;
            // 
            // AfterFirstTestStock
            // 
            this.AfterFirstTestStock.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AfterFirstTestStock.Controls.Add(this.AfterFirstTest);
            this.AfterFirstTestStock.Flags = 65534;
            this.AfterFirstTestStock.LastVisibleSet = true;
            this.AfterFirstTestStock.MinimumSize = new System.Drawing.Size(50, 50);
            this.AfterFirstTestStock.Name = "AfterFirstTestStock";
            this.AfterFirstTestStock.Size = new System.Drawing.Size(798, 388);
            this.AfterFirstTestStock.Text = "1차 판정 재고 일람";
            this.AfterFirstTestStock.ToolTipTitle = "Page ToolTip";
            this.AfterFirstTestStock.UniqueName = "BAB495A4DEA74021F8AD8876F5A69531";
            // 
            // AfterFirstTest
            // 
            this.AfterFirstTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AfterFirstTest.Location = new System.Drawing.Point(0, 0);
            this.AfterFirstTest.Name = "AfterFirstTest";
            this.AfterFirstTest.Size = new System.Drawing.Size(798, 388);
            this.AfterFirstTest.TabIndex = 0;
            // 
            // AfterTestStock
            // 
            this.AfterTestStock.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.AfterTestStock.Controls.Add(this.FinalUnGoodStaticTest);
            this.AfterTestStock.Flags = 65534;
            this.AfterTestStock.LastVisibleSet = true;
            this.AfterTestStock.MinimumSize = new System.Drawing.Size(50, 50);
            this.AfterTestStock.Name = "AfterTestStock";
            this.AfterTestStock.Size = new System.Drawing.Size(798, 388);
            this.AfterTestStock.Text = "불량 판정 재고 일람";
            this.AfterTestStock.ToolTipTitle = "Page ToolTip";
            this.AfterTestStock.UniqueName = "89099CD2D77248BA4EAC2AF91B4CC10D";
            // 
            // FinalUnGoodStaticTest
            // 
            this.FinalUnGoodStaticTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalUnGoodStaticTest.Location = new System.Drawing.Point(0, 0);
            this.FinalUnGoodStaticTest.Name = "FinalUnGoodStaticTest";
            this.FinalUnGoodStaticTest.Size = new System.Drawing.Size(798, 388);
            this.FinalUnGoodStaticTest.TabIndex = 0;
            // 
            // WaitinPackageStock
            // 
            this.WaitinPackageStock.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.WaitinPackageStock.Controls.Add(this.stockStatistics4);
            this.WaitinPackageStock.Flags = 65534;
            this.WaitinPackageStock.LastVisibleSet = true;
            this.WaitinPackageStock.MinimumSize = new System.Drawing.Size(50, 50);
            this.WaitinPackageStock.Name = "WaitinPackageStock";
            this.WaitinPackageStock.Size = new System.Drawing.Size(798, 388);
            this.WaitinPackageStock.Text = "포장 대기 재고 일람";
            this.WaitinPackageStock.ToolTipTitle = "Page ToolTip";
            this.WaitinPackageStock.UniqueName = "6AAC82D9FD0D4AC5598FC63356B8E129";
            // 
            // stockStatistics4
            // 
            this.stockStatistics4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockStatistics4.Location = new System.Drawing.Point(0, 0);
            this.stockStatistics4.Name = "stockStatistics4";
            this.stockStatistics4.Size = new System.Drawing.Size(798, 388);
            this.stockStatistics4.TabIndex = 0;
            // 
            // FianlStock
            // 
            this.FianlStock.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.FianlStock.Controls.Add(this.stockStatistics5);
            this.FianlStock.Flags = 65534;
            this.FianlStock.LastVisibleSet = true;
            this.FianlStock.MinimumSize = new System.Drawing.Size(50, 50);
            this.FianlStock.Name = "FianlStock";
            this.FianlStock.Size = new System.Drawing.Size(798, 388);
            this.FianlStock.Text = "최종 재고 일람";
            this.FianlStock.ToolTipTitle = "Page ToolTip";
            this.FianlStock.UniqueName = "AD9F30BE2CDF4EBCA1A5B5961D5CE65C";
            // 
            // stockStatistics5
            // 
            this.stockStatistics5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockStatistics5.Location = new System.Drawing.Point(0, 0);
            this.stockStatistics5.Name = "stockStatistics5";
            this.stockStatistics5.Size = new System.Drawing.Size(798, 388);
            this.stockStatistics5.TabIndex = 0;
            // 
            // StockStatisticsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockStatisticsFrom";
            this.Text = "StockStatisticsFrom";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforeTestStock)).EndInit();
            this.BeforeTestStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AfterFirstTestStock)).EndInit();
            this.AfterFirstTestStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AfterTestStock)).EndInit();
            this.AfterTestStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaitinPackageStock)).EndInit();
            this.WaitinPackageStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FianlStock)).EndInit();
            this.FianlStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage BeforeTestStock;
        private ComponentFactory.Krypton.Navigator.KryptonPage AfterFirstTestStock;
        private ComponentFactory.Krypton.Navigator.KryptonPage AfterTestStock;
        private ComponentFactory.Krypton.Navigator.KryptonPage WaitinPackageStock;
        private ComponentFactory.Krypton.Navigator.KryptonPage FianlStock;
        private Controls.Statistics.StockStatistics BeforeTest;
        private Controls.Statistics.StockStatistics AfterFirstTest;
        private Controls.Statistics.StockStatistics FinalUnGoodStaticTest;
        private Controls.Statistics.StockStatistics stockStatistics4;
        private Controls.Statistics.StockStatistics stockStatistics5;
    }
}