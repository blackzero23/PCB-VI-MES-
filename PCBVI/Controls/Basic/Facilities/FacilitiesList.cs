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

namespace PCBVI.Controls.Basic.Facilities
{
    public partial class FacilitiesList : UserControl
    {
        public FacilitiesList()
        {
            InitializeComponent();
        }

        internal void setDataSource(List<Facility> list)
        {
            dgvList.DataSource = list;
        }

        #region CellContentClicked event things for C# 3.0
        public event EventHandler<CellContentClickedEventArgs> CellContentClicked;

        protected virtual void OnCellContentClicked(CellContentClickedEventArgs e)
        {
            if (CellContentClicked != null)
                CellContentClicked(this, e);
        }

        private CellContentClickedEventArgs OnCellContentClicked(Facility facilities)
        {
            CellContentClickedEventArgs args = new CellContentClickedEventArgs(facilities);
            OnCellContentClicked(args);

            return args;
        }

        private CellContentClickedEventArgs OnCellContentClickedForOut()
        {
            CellContentClickedEventArgs args = new CellContentClickedEventArgs();
            OnCellContentClicked(args);

            return args;
        }

        public class CellContentClickedEventArgs : EventArgs
        {
            public Facility Facilities { get; set; }

            public CellContentClickedEventArgs()
            {
            }

            public CellContentClickedEventArgs(Facility facilities)
            {
                Facilities = facilities;
            }
        }
        #endregion
      

        private void DgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnCellContentClicked(dgvList.CurrentRow.DataBoundItem as Facility);
        }

        private List<Facility> _facilities = new List<Facility>();

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Facility GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Facility;
        }

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Facility list)
            {
                _facilities.Add(list);
            }
        }
    }
}
