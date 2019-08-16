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
    public partial class FacilitiesHSC : UserControl
    {
        public FacilitiesHSC()
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
            //중복되는 코드가 많으니까 함수로 빼보자.
            List<Data.Facility> facilities = DB.Facilities.GetAll();
            facilities.Insert(0, new Data.Facility(""));
            bdsFacilities.DataSource = facilities;

            List<Data.FHistoryDivision> fHistoryDivisions = DB.FHistoryDivision.GetAll();
            fHistoryDivisions.Insert(0, new Data.FHistoryDivision(""));
            bdsHistoryDivision.DataSource = fHistoryDivisions;

            List<Data.WorkPlace> workPlaces = DB.WorkPlace.GetAll();
            workPlaces.Insert(0, new Data.WorkPlace(""));
            bdsWorkPlace.DataSource = workPlaces;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int facilitiesId = (int)cbbFaciliesName.SelectedValue;
            int workPlaceId = (int)cbbWorkPlace.SelectedValue;
            int fHistoryDivisionId = (int)cbbDivision.SelectedValue;

            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            OnSearchButtonClicked(facilitiesId,workPlaceId,fHistoryDivisionId,fromDate,toDate);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int facilitiesId, int workPlaceId, int fHistoryDivisionId, DateTime fromDate, DateTime toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(facilitiesId, workPlaceId, fHistoryDivisionId, fromDate, toDate);
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
            public int WorkPlaceId { get; set; }
            public int FHistoryDivisionId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int facilitiesId, int workPlaceId, int fHistoryDivisionId, DateTime fromDate, DateTime toDate)
            {
                FacilitiesId = facilitiesId;
                WorkPlaceId = workPlaceId;
                FHistoryDivisionId = fHistoryDivisionId;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion
    }
}
