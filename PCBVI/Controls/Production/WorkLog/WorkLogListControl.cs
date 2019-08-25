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

namespace PCBVI.Controls.Production.WorkLog
{
    public partial class WorkLogListControl : UserControl
    {
        public WorkLogListControl()
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
            bdsProcess.DataSource = DB.Process.GetAll();
            bdsFacility.DataSource = DB.Facilities.GetAll();
            bdsItem.DataSource = DB.Item.GetAll();
            bdsRotationGroup.DataSource = DB.RotationGroup.GetAll();

            dgvList.DataSource = DB.WorkLog.SetWorkLogList();

        }

        public void SetDataSource(List<Data.WorkLog> list)
        {
            dgvList.DataSource = list;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }
    }
}
