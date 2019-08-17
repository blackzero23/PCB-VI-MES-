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

namespace PCBVI.Controls.Basic.Facilities
{
    public partial class FacilitiesSearch : UserControl
    {
        public FacilitiesSearch()
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
            List<Data.Facility> facilities = DB.Facilities.GetAll();
            facilities.Insert(0, new Data.Facility(""));
            cbbFacilities.DataSource = facilities;

            List<Data.Process> processes = DB.Process.GetAll();
            processes.Insert(0, new Data.Process(""));
            cbbProcess.DataSource = processes;
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int facilitiesId, int processId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(facilitiesId, processId);
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
            public int FacilitiesId { get; set; }
            public int ProcessId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int facilitiesId, int processId)
            {
                FacilitiesId = facilitiesId;
                ProcessId = processId;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int facilitiesId = (int)cbbFacilities.SelectedValue;
            int processId = (int)cbbProcess.SelectedValue;

            OnSearchButtonClicked(facilitiesId, processId);
        }

       

       
    }
}
