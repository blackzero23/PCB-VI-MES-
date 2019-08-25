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
    public partial class DefectiveProductListControl : UserControl
    {
        public DefectiveProductListControl()
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

        public void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsLot.DataSource = DB.Lot.GetAll();

            List<Data.ErrorCode> errorCodes = DB.ErrorCode.GetAll();
            errorCodes.Insert(0, new Data.ErrorCode(""));
            bdsErrorCode.DataSource = errorCodes;
        }

        public void SetDataSource(List<Data.Barcode> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.Barcode> GetUpateList()
        {

            List<Data.Barcode> barcodes = (List<Data.Barcode>)dgvList.DataSource;

            foreach (var barcode in barcodes)
            {
                if (barcode.ErrorCodeId == null)
                {
                    barcode.State = "Pass";
                }
            }

            return barcodes;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }
    }
}
