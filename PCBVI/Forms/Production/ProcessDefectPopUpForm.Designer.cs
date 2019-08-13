namespace PCBVI.Forms.Production
{
    partial class ProcessDefectPopUpForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ProductNameTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ErrorCodeTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ProcessDefectPopUpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDefectPopUpChart)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(63, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "제품명 : ";
            // 
            // ProductNameTxb
            // 
            this.ProductNameTxb.Location = new System.Drawing.Point(124, 13);
            this.ProductNameTxb.Name = "ProductNameTxb";
            this.ProductNameTxb.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTxb.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(230, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "불량 코드 : ";
            // 
            // ErrorCodeTxb
            // 
            this.ErrorCodeTxb.Location = new System.Drawing.Point(305, 13);
            this.ErrorCodeTxb.Name = "ErrorCodeTxb";
            this.ErrorCodeTxb.Size = new System.Drawing.Size(100, 20);
            this.ErrorCodeTxb.TabIndex = 2;
            // 
            // ProcessDefectPopUpChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ProcessDefectPopUpChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ProcessDefectPopUpChart.Legends.Add(legend1);
            this.ProcessDefectPopUpChart.Location = new System.Drawing.Point(90, 50);
            this.ProcessDefectPopUpChart.Name = "ProcessDefectPopUpChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ProcessDefectPopUpChart.Series.Add(series1);
            this.ProcessDefectPopUpChart.Size = new System.Drawing.Size(300, 300);
            this.ProcessDefectPopUpChart.TabIndex = 3;
            this.ProcessDefectPopUpChart.Text = "chart1";
            // 
            // ProcessDefectPopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.ProcessDefectPopUpChart);
            this.Controls.Add(this.ErrorCodeTxb);
            this.Controls.Add(this.ProductNameTxb);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "ProcessDefectPopUpForm";
            this.Text = "ProcessDefectPopUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDefectPopUpChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ProductNameTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ErrorCodeTxb;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProcessDefectPopUpChart;
    }
}