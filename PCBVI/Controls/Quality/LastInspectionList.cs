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
    public partial class LastInspectionList : UserControl
    {
        public LastInspectionList()
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

        public void SetDataSource(List<Data.LastInspection> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.LastInspection> GetUpateList()
        {
            List<Data.LastInspection> lastInspections = null;
            try
            {
                lastInspections = (List<Data.LastInspection>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(@"수정할 목록이 없습니다.");
            }

            return lastInspections;                       
        }

        public LastInspection GetCurrentLow()
        {
            Data.LastInspection lastInspection = null;
            try
            {
                lastInspection = dgvList.CurrentRow.DataBoundItem as Data.LastInspection;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return lastInspection;           
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }
    }
}
