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

namespace PCBVI.Controls.Basic.SubjectControl
{
    public partial class SubjectList : UserControl
    {
        public SubjectList()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
             return;

            bdsFirstDivision.DataSource = DB.FirstItemDivision.GetAll();
            bdsSecondDivision.DataSource = DB.SecondItemDivision.GetAll();
            bdsWorkPlace.DataSource =
                DB.WorkPlace.GetAll();
            
        }

        //바인딩된 데이터 리스트 반환.
        public List<Data.Item> GetUpateList()
        {
            return (List<Data.Item>)dgvList.DataSource;
        }
        //private void 

        public void SetItemDataSource(List<Data.Item> list)
        {
            dgvList.DataSource = list;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.Item GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.Item;
        }


        private List<Data.Item> _itemes = new List<Data.Item>();

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Data.Item item)
            {
                _itemes.Add(item);
            }
        }
    }
}
