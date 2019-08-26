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

namespace PCBVI.Controls.Facilities
{
    public partial class FacilitiesHLC : UserControl
    {
        public FacilitiesHLC()
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
        public void InitSetDataSource()
        {
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
            bdsFacilities.DataSource = DB.Facilities.GetAll();
            bdsFHistoryDivision.DataSource = DB.FHistoryDivision.GetAll();
        }

        public void SetDataSource(List<Data.FacilitiesHistory> list)
        {
            dgvList.DataSource = list;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public List<Data.FacilitiesHistory> GetUpateList()
        {
            List<Data.FacilitiesHistory> facilitiesHistories = null;
            try
            {
                facilitiesHistories = (List<Data.FacilitiesHistory>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(@"수정할 목록이 없습니다.");
            }

            return facilitiesHistories;
           
        }

        public FacilitiesHistory GetCurrentLow()
        {
            Data.FacilitiesHistory facilities = null;

            try
            {
                facilities = dgvList.CurrentRow.DataBoundItem as Data.FacilitiesHistory;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return facilities;
            
        }
    }
}
