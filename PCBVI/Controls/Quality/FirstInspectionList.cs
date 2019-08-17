using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Controls.Quality
{
    public partial class FirstInspectionList : UserControl
    {
        public FirstInspectionList()
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
           
        }

        public void SetDataSource(List<Data.FirstInspection> list)
        {
            dgvList.DataSource = list;
        }
    }
}
