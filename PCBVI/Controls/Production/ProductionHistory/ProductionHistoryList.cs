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

namespace PCBVI.Controls.Production.ProductionHistory
{
    public partial class ProductionHistoryList : UserControl
    {
        public ProductionHistoryList()
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
            bdsProductionHistory.DataSource = DB.ProductionHistory.GetAll().OrderByDescending(x=>x.ProductionDate);
            bdsItem.DataSource = DB.Item.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
        }

        public void SetDataSource(List<Data.ProductionHistory> list)
        {
            bdsProductionHistory.DataSource = list;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }
    }
}
