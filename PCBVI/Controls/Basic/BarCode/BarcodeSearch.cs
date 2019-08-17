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

namespace PCBVI.Controls.Basic.BarCode
{
    public partial class BarcodeSearch : UserControl
    {
        public BarcodeSearch()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;

            List<Barcode> barcodes = DB.BarCode.GetAll();
            //barcodes.Insert(0, new Barcode(""));
            cbbBarcodeName.DataSource = barcodes;

            List<Lot> lots = DB.Lot.GetAll();
            lots.Insert(0, new Lot(""));
            cbbLotNo.DataSource = lots;

        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int lotId, int barcodeId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(lotId, barcodeId);
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
            public int BarcodeId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int lotId, int barcodeId)
            {
                LotId = lotId;
                BarcodeId = barcodeId;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int lotId = (int)cbbLotNo.SelectedValue;
            int barcodeId = (int)cbbBarcodeName.SelectedValue;

            OnSearchButtonClicked(lotId, barcodeId);
        }
    }
}
