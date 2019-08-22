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

        public void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsRotationGroup.DataSource = DB.RotationGroup.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();

            bdsWorkOrder.DataSource = DB.WorkOrder.ToDayWorkOrderList();
        }

        public void SetDataSource(List<Data.WorkOrder> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.WorkOrder> GetUpateList()
        {
            return (List<Data.WorkOrder>)dgvList.DataSource;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.WorkOrder GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.WorkOrder;
        }
    }
}
