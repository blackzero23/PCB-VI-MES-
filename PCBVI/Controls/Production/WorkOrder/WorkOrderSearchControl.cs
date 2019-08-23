using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Production.WorkOrder
{
    public partial class WorkOrderSearchControl : UserControl
    {
        public WorkOrderSearchControl()
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
            var items = DB.Item.GetAll();
            items.Insert(0, new Item(""));
            bdsItem.DataSource = items;

            var rotations = DB.RotationGroup.GetAll();
            rotations.Insert(0, new RotationGroup(""));
            bdsRotation.DataSource = rotations;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int itemId = (int)cbbItemName.SelectedValue;
            int rotationId = (int) cbbRotation.SelectedValue;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            OnSearchButtonClicked(itemId, rotationId, fromDate, toDate);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int itemId, int rotationId, DateTime fromDate, DateTime toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(itemId, rotationId, fromDate, toDate);
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
            public int ItemId { get; set; }
            public int RotationId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int itemId, int rotationId, DateTime fromDate, DateTime toDate)
            {
                ItemId = itemId;
                RotationId = rotationId;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion

    }
}
