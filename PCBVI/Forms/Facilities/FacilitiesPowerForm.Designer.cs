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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bdsTodayFacilitiesList = new System.Windows.Forms.BindingSource(this.components);
            this.chartCircle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bdsFacilitiesPower = new System.Windows.Forms.BindingSource(this.components);
            this.naviFacilitiesPower = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageFacilitiesPower = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Facilities.FacilitiesPLC();
            this.uscSearch = new PCBVI.Controls.Facilities.FacilitiesPSC();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTodayFacilitiesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesPower)).BeginInit();
            this.naviFacilitiesPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesPower)).BeginInit();
            this.pageFacilitiesPower.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsTodayFacilitiesList
            // 
            this.bdsTodayFacilitiesList.DataSource = typeof(PCBVI.Data.FacilitiesPower);
            // 
            // chartCircle
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCircle.ChartAreas.Add(chartArea1);
            this.chartCircle.DataSource = this.bdsFacilitiesPower;
            this.chartCircle.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartCircle.Legends.Add(legend1);
            this.chartCircle.Location = new System.Drawing.Point(464, 63);
            this.chartCircle.Name = "chartCircle";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelFormat = "#.##%";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "FacilitiesName";
            series1.YValueMembers = "WorkTime";
            this.chartCircle.Series.Add(series1);
            this.chartCircle.Size = new System.Drawing.Size(334, 360);
            this.chartCircle.TabIndex = 1;
            this.chartCircle.Text = "chartCircle";
            title1.Name = "Title1";
            title1.Text = "설비 가동율";
            this.chartCircle.Titles.Add(title1);
            // 
            // bdsFacilitiesPower
            // 
            this.bdsFacilitiesPower.DataSource = typeof(PCBVI.Data.FacilitiesPower);
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
            this.pageFacilitiesPower.Controls.Add(this.chartCircle);
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
            this.uscList.Size = new System.Drawing.Size(464, 360);
            this.uscList.TabIndex = 3;
            this.uscList.CellMouceClicked += new System.EventHandler<PCBVI.Controls.Facilities.FacilitiesPLC.CellMouceClickedEventArgs>(this.UscList_CellMouceClicked);
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(798, 63);
            this.uscSearch.TabIndex = 2;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Facilities.FacilitiesPSC.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
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
            this.Load += new System.EventHandler(this.FacilitiesPowerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTodayFacilitiesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviFacilitiesPower)).EndInit();
            this.naviFacilitiesPower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageFacilitiesPower)).EndInit();
            this.pageFacilitiesPower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCircle;
        private Controls.Facilities.FacilitiesPSC uscSearch;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviFacilitiesPower;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageFacilitiesPower;
        private Controls.Facilities.FacilitiesPLC uscList;
        private System.Windows.Forms.BindingSource bdsFacilitiesPower;
        private System.Windows.Forms.BindingSource bdsTodayFacilitiesList;
    }
}