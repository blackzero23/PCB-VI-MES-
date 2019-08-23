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

namespace PCBVI.Controls.Production.DefectiveProduct
{
    public partial class DefectiveProductSearchControl : UserControl
    {
        public DefectiveProductSearchControl()
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
            cbbProcess.DataSource = processes;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int lotId = (int)cbbProcess.SelectedValue;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            OnSearchButtonClicked(lotId, fromDate, toDate);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int lotId, DateTime fromDate, DateTime toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(lotId, fromDate, toDate);
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
            public int LotId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int lotId, DateTime fromDate, DateTime toDate)
            {
                LotId = lotId;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion
    }
}
