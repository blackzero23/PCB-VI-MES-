namespace PCBVI.Controls.Statistics
{
    partial class StockStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StockStaticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockKindsCbb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BunJaLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BunMoLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BunJaTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BunMoTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockStaticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockKindsCbb)).BeginInit();
            this.SuspendLayout();
            // 
            // StockStaticChart
            // 
            chartArea1.Name = "ChartArea1";
            this.StockStaticChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StockStaticChart.Legends.Add(legend1);
            this.StockStaticChart.Location = new System.Drawing.Point(14, 15);
            this.StockStaticChart.Name = "StockStaticChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StockStaticChart.Series.Add(series1);
            this.StockStaticChart.Size = new System.Drawing.Size(374, 345);
            this.StockStaticChart.TabIndex = 0;
            this.StockStaticChart.Text = "chart1";
            // 
            // StockKindsCbb
            // 
            this.StockKindsCbb.DropDownWidth = 121;
            this.StockKindsCbb.Location = new System.Drawing.Point(516, 105);
            this.StockKindsCbb.Name = "StockKindsCbb";
            this.StockKindsCbb.Size = new System.Drawing.Size(121, 21);
            this.StockKindsCbb.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(408, 100);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(102, 29);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "재고 종류 : ";
            // 
            // BunJaLb
            // 
            this.BunJaLb.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.BunJaLb.Location = new System.Drawing.Point(445, 184);
            this.BunJaLb.Name = "BunJaLb";
            this.BunJaLb.Size = new System.Drawing.Size(65, 29);
            this.BunJaLb.TabIndex = 2;
            this.BunJaLb.Values.Text = "분 자 : ";
            // 
            // BunMoLb
            // 
            this.BunMoLb.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.BunMoLb.Location = new System.Drawing.Point(445, 274);
            this.BunMoLb.Name = "BunMoLb";
            this.BunMoLb.Size = new System.Drawing.Size(65, 29);
            this.BunMoLb.TabIndex = 2;
            this.BunMoLb.Values.Text = "분 모 : ";
            // 
            // BunJaTxb
            // 
            this.BunJaTxb.Location = new System.Drawing.Point(516, 191);
            this.BunJaTxb.Name = "BunJaTxb";
            this.BunJaTxb.Size = new System.Drawing.Size(100, 20);
            this.BunJaTxb.TabIndex = 3;
            // 
            // BunMoTxb
            // 
            this.BunMoTxb.Location = new System.Drawing.Point(516, 280);
            this.BunMoTxb.Name = "BunMoTxb";
            this.BunMoTxb.Size = new System.Drawing.Size(100, 20);
            this.BunMoTxb.TabIndex = 3;
            // 
            // StockStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BunMoTxb);
            this.Controls.Add(this.BunJaTxb);
            this.Controls.Add(this.BunMoLb);
            this.Controls.Add(this.BunJaLb);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.StockKindsCbb);
            this.Controls.Add(this.StockStaticChart);
            this.Name = "StockStatistics";
            this.Size = new System.Drawing.Size(800, 373);
            ((System.ComponentModel.ISupportInitialize)(this.StockStaticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockKindsCbb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StockStaticChart;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox StockKindsCbb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel BunJaLb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel BunMoLb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BunJaTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BunMoTxb;
    }
}
