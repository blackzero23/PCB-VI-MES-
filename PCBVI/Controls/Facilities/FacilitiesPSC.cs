using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Facilities
{
    public partial class FacilitiesPSC : UserControl
    {
        public FacilitiesPSC()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }

        private void InitSetDataSource()
        {
            List<Data.Process> processes = DB.Process.GetAll();
            processes.Insert(0, new Data.Process(""));
            bdsProcess.DataSource = processes;

            List<Data.Facility> facilities = DB.Facilities.GetAll();
            facilities.Insert(0, new Data.Facility(""));
            bdsFacilities.DataSource = facilities;
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int processId, int facilitiesId, DateTime fromDate, DateTime toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(processId, facilitiesId, fromDate, toDate);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public int ProcessId { get; set; }
            public int FacilitiesId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int processId, int facilitiesId, DateTime fromDate, DateTime toDate)
            {
                ProcessId = processId;
                FacilitiesId = facilitiesId;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int processId = (int)cbbProcess.SelectedValue;
            int facilitesId = (int)cbbFacilities.SelectedValue;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            OnSearchButtonClicked(processId,facilitesId,fromDate,toDate);
        }
    }
}
