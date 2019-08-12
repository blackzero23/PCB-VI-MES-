using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data;

namespace PCBVI.Controls.Basic.BarCode
{
    public partial class BarcodeSearch : UserControl
    {
        public BarcodeSearch()
        {
            InitializeComponent();
        }

        public void SetProcessDataSource(List<Process> list)
        {
            cbbProcess.DataSource = list;
        }
    }
}
