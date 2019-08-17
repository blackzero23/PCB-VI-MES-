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
    public partial class FirstInspectionSearch : UserControl
    {
        public FirstInspectionSearch()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;


        }
        private void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string companyName = txbCompanyName.Text;
            int itemId = (int)cbbProductName.SelectedValue;
            DateTime fromDate = dtpFromDate.Value;
            DateTime ToDate = dtpToDate.Value;

            OnSearchButtonClicked(companyName, itemId, fromDate, ToDate);
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string outCompanName, int itemId, DateTime fromDate, DateTime toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(outCompanName, itemId, fromDate, toDate);
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
            public string OutCompanName { get; set; }
            public int ItemId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string outCompanName, int itemId, DateTime fromDate, DateTime toDate)
            {
                OutCompanName = outCompanName;
                ItemId = itemId;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion

      
    }
}

