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

namespace PCBVI.Controls.Production.WorkOrder
{
    public partial class WorkOrderListControl : UserControl
    {
        public WorkOrderListControl()
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
            bdsItem.DataSource = DB.Item.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsRotationGroup.DataSource = DB.RotationGroup.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        public void SetDataSource(List<Data.WorkOrder> list)
        {
            dgvList.DataSource = list;
        }

    }
}
