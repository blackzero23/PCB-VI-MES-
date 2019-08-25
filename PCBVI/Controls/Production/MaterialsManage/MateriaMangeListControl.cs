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
            List<Data.MaterialsManage> materialsManages = null;

            try
            {
                materialsManages = (List<Data.MaterialsManage>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("수정할 목록이 없습니다.");
            }

            return materialsManages;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.MaterialsManage GetCurrentLow()
        {
            Data.MaterialsManage materialsManage = null;
            try
            {
                materialsManage = dgvList.CurrentRow.DataBoundItem as Data.MaterialsManage;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return materialsManage;
        }
    }
}
