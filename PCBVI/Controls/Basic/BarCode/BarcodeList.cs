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
        private List<Data.Barcode> _barcodes = new List<Data.Barcode>();

        public List<Data.Barcode> GetUpateList()
        {
            return (List<Data.Barcode>)dgvList.DataSource;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.Barcode GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.Barcode;
        }

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Data.Barcode barcode)
            {
                _barcodes.Add(barcode);
            }
        }
    }
}
