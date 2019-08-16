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
            bdsBarcode.DataSource = DB.BarCode.GetAll();
            bdsEmployee.DataSource = DB.Employee.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsLot.DataSource = DB.Lot.GetAll();
            bdsErrorCode.DataSource = DB.ErrorCode.GetAll();
        }

        public void SetDataSource(List<Data.DefectiveProduct> list)
        {
            dgvList.DataSource = list;
        }
    }
}
