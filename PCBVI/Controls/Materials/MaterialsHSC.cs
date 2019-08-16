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

namespace PCBVI.Controls.Materials
{
    public partial class MaterialsHSC : UserControl
    {
        public MaterialsHSC()
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
            bdsBarCode.DataSource = DB.BarCode.GetAll();
            bdsLot.DataSource = DB.Lot.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int lotId = (int)cbbLotNo.SelectedValue;
            int barCodeId = (int)cbbBarcodeName.SelectedValue;

            OnSearchButtonClicked(lotId, barCodeId);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int lotId, int barCodeId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(lotId, barCodeId);
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
            public int BarCodeId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int lotId, int barCodeId)
            {
                LotId = lotId;
                BarCodeId = barCodeId;
            }
        }
        #endregion
    }
}
