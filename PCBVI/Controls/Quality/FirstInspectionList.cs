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
            bdsItem.DataSource = DB.Item.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        public void SetDataSource(List<Data.FirstInspection> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.FirstInspection> GetUpateList()
        {
            List<Data.FirstInspection> firstInspections = null;
            try
            {
                firstInspections = ((List<Data.FirstInspection>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(@"수정할 목록이 없습니다.");
            }

            return firstInspections;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public FirstInspection GetCurrentLow()
        {
            Data.FirstInspection firstInspection = null;
            try
            {
                firstInspection = dgvList.CurrentRow.DataBoundItem as Data.FirstInspection;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return firstInspection;
           
        }

        
    }
}
