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
using PCBVI.Data;

namespace PCBVI.Controls.Production.MaterialsManage
{
    public partial class MateriaMangeListControl : UserControl
    {
        public MateriaMangeListControl()
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
            bdsMaterialState.DataSource = DB.MaterialState.GetAll();
            bdsProcess.DataSource = DB.Process.GetAll();
        }

        public void SetDataSource(List<Data.MaterialsManage> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.MaterialsManage> GetUpateList()
        {
            return (List<Data.MaterialsManage>)dgvList.DataSource;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.MaterialsManage GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.MaterialsManage;
        }
    }
}
