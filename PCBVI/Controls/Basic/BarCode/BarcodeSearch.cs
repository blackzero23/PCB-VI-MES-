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
            cbbBarcodeName.DataSource = DB.BarCode.GetAll();
            cbbLotNo.DataSource = DB.Lot.GetAll();

        }

        #region SeaechButtonClicked event things for C# 3.0
        public event EventHandler<SeaechButtonClickedEventArgs> SeaechButtonClicked;

        protected virtual void OnSeaechButtonClicked(SeaechButtonClickedEventArgs e)
        {
            if (SeaechButtonClicked != null)
                SeaechButtonClicked(this, e);
        }

        private SeaechButtonClickedEventArgs OnSeaechButtonClicked(int lotId)
        {
            SeaechButtonClickedEventArgs args = new SeaechButtonClickedEventArgs(lotId);
            OnSeaechButtonClicked(args);

            return args;
        }

        private SeaechButtonClickedEventArgs OnSeaechButtonClickedForOut()
        {
            SeaechButtonClickedEventArgs args = new SeaechButtonClickedEventArgs();
            OnSeaechButtonClicked(args);

            return args;
        }

        public class SeaechButtonClickedEventArgs : EventArgs
        {
            public int LotId { get; set; }

            public SeaechButtonClickedEventArgs()
            {
            }

            public SeaechButtonClickedEventArgs(int lotId)
            {
                LotId = lotId;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int lotId = (int)cbbLotNo.SelectedValue;

            OnSeaechButtonClicked(lotId);
        }
    }
}
