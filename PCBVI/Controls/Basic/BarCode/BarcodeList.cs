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

namespace PCBVI.Controls.Basic.BarCode
{
    public partial class BarcodeList : UserControl
    {
        public BarcodeList()
        {
            InitializeComponent();
        }

        public void SetBarcodeDataSource(List<Barcode> list)
        {
            dgvList.DataSource = list;
        }
    }
}
