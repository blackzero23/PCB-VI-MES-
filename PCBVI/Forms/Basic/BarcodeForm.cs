using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Basic
{
    public partial class BarcodeForm : Form
    {
        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void BarcodeSearch1_SeaechButtonClicked(object sender, Controls.Basic.BarCode.BarcodeSearch.SeaechButtonClickedEventArgs e)
        {
            uscList.SetBarcodeDataSource(DB.BarCode.Search(e.LotId));
        }
    }
}
