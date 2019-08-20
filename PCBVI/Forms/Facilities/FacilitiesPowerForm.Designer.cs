namespace PCBVI.Forms.Facilities
{
    partial class FacilitiesPowerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uscSearch = new PCBVI.Controls.Facilities.FacilitiesPSC();
            this.naviFacilitiesPower = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageFacilitiesPower = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Facilities.FacilitiesPLC();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesPower)).BeginInit();
            this.naviFacilitiesPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesPower)).BeginInit();
            this.pageFacilitiesPower.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 306);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(798, 117);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(555, 63);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(243, 243);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 63);
            this.uscSearch.TabIndex = 2;
            // 
            // naviFacilitiesPower
            // 
            this.naviFacilitiesPower.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviFacilitiesPower.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviFacilitiesPower.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviFacilitiesPower.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFacilitiesPower.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviFacilitiesPower.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviFacilitiesPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviFacilitiesPower.Location = new System.Drawing.Point(0, 0);
            this.naviFacilitiesPower.Name = "naviFacilitiesPower";
            this.naviFacilitiesPower.Padding = new System.Windows.Forms.Padding(3);
            this.naviFacilitiesPower.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageFacilitiesPower});
            this.naviFacilitiesPower.SelectedIndex = 0;
            this.naviFacilitiesPower.Size = new System.Drawing.Size(800, 450);
            this.naviFacilitiesPower.TabIndex = 3;
            this.naviFacilitiesPower.Text = "navi";
            // 
            // pageFacilitiesPower
            // 
            this.pageFacilitiesPower.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageFacilitiesPower.Controls.Add(this.uscList);
            this.pageFacilitiesPower.Controls.Add(this.chart2);
            this.pageFacilitiesPower.Controls.Add(this.chart1);
            this.pageFacilitiesPower.Controls.Add(this.uscSearch);
            this.pageFacilitiesPower.Flags = 65534;
            this.pageFacilitiesPower.LastVisibleSet = true;
            this.pageFacilitiesPower.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageFacilitiesPower.Name = "pageFacilitiesPower";
            this.pageFacilitiesPower.Size = new System.Drawing.Size(798, 423);
            this.pageFacilitiesPower.Text = "설비 가동/ 비가동";
            this.pageFacilitiesPower.ToolTipTitle = "Page ToolTip";
            this.pageFacilitiesPower.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 63);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(555, 243);
            this.uscList.TabIndex = 3;
            // 
            // FacilitiesPowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviFacilitiesPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacilitiesPowerForm";
            this.Text = "FacilitiesPowerForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesPower)).EndInit();
            this.naviFacilitiesPower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesPower)).EndInit();
            this.pageFacilitiesPower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Controls.Facilities.FacilitiesPSC uscSearch;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviFacilitiesPower;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageFacilitiesPower;
        private Controls.Facilities.FacilitiesPLC uscList;
    }
}