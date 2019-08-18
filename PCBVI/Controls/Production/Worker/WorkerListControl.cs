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

namespace PCBVI.Controls.Production.Worker
{
    public partial class WorkerListControl : UserControl
    {
        public WorkerListControl()
        {
            InitializeComponent();
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
