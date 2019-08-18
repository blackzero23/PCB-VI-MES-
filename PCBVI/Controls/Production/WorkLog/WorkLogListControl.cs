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
        }

        public void SetDataSource(List<Data.WorkLog> list)
        {
            dgvList.DataSource = list;
        }

    }
}
