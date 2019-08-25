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

namespace PCBVI.Controls.Quality
{
    public partial class LastInspectionSearch : UserControl
    {
        public LastInspectionSearch()
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
            List<Data.Item> items = DB.Item.GetAll();
            items.Insert(0, new Data.Item(""));
            bdsItem.DataSource = items;

            List<Data.WorkPlace> workPlaces = DB.WorkPlace.GetAll();
            workPlaces.Insert(0, new Data.WorkPlace(""));
            bdsWorkPlace.DataSource = workPlaces;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            string companyName = txbCompanyName.Text;
            string workerName = txbWorker.Text;
            int itemId = (int)cbbItemCode.SelectedValue;
            int workPlaceId = (int)cbbWorkPlace.SelectedValue;
            DateTime productionFrom = dtpProductionFromDate.Value;
            DateTime productionTo = dtpProductionToDate.Value;
           

            OnSearchButtonClicked(companyName, workerName, itemId, workPlaceId, productionFrom, productionTo);
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string companyName, string employeeName, int itemId, int workPlaceId, DateTime productionFrom, DateTime productionTo)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(companyName, employeeName, itemId, workPlaceId, productionFrom, productionTo);
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
            public string CompanyName { get; set; }
            public string EmployeeName { get; set; }
            public int ItemId { get; set; }
            public int WorkPlaceId { get; set; }
            public DateTime ProductionFrom { get; set; }
            public DateTime ProductionTo { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string companyName, string employeeName, int itemId, int workPlaceId, DateTime productionFrom, DateTime productionTo)
            {
                CompanyName = companyName;
                EmployeeName = employeeName;
                ItemId = itemId;
                WorkPlaceId = workPlaceId;
                ProductionFrom = productionFrom;
                ProductionTo = productionTo;
            }
        }
        #endregion

    }
}
