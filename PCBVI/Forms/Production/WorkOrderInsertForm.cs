using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Production
{
    public partial class WorkOrderInsertForm : KryptonForm
    {
        public WorkOrderInsertForm()
        {
            InitializeComponent();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
