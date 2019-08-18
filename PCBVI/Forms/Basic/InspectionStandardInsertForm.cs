using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Basic
{
    public partial class InspectionStandardInsertForm : Form
    {
        public InspectionStandardInsertForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bdsStandard.DataSource =
                DB.InspectionStandard.GetAll();
            bdsType.DataSource =
                DB.InspectionStandardType.GetAll();

        }
    }
}
