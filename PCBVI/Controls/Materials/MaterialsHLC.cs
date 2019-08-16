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
    public partial class MaterialsHLC : UserControl
    {
        public MaterialsHLC()
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
            bdsBarcode.DataSource = DB.BarCode.GetAll();
            bdsLot.DataSource = DB.Lot.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        public void SetDataSource(List<Data.MaterialHistory> list)
        {
            dgvList.DataSource = list;
        }


    }
}
