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
            List<Data.Barcode> barcodes = null;
            try
            {
                barcodes = (List<Data.Barcode>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("수정할 목록이 없습니다.");
            }

            return barcodes;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.Barcode GetCurrentLow()
        {
            Data.Barcode barcode = null;
            try
            {
                barcode = dgvList.CurrentRow.DataBoundItem as Data.Barcode;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return barcode;
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
