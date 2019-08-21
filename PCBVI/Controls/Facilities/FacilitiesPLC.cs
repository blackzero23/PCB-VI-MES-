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

namespace PCBVI.Controls.Facilities
{
    public partial class FacilitiesPLC : UserControl
    {
        public FacilitiesPLC()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Data.FacilitiesPower> list)
        {
            dgvList.DataSource = list;
        }

        
        #region CellMouceClicked event things for C# 3.0
        public event EventHandler<CellMouceClickedEventArgs> CellMouceClicked;

        protected virtual void OnCellMouceClicked(CellMouceClickedEventArgs e)
        {
            if (CellMouceClicked != null)
                CellMouceClicked(this, e);
        }

        private CellMouceClickedEventArgs OnCellMouceClicked(FacilitiesPower facilities)
        {
            CellMouceClickedEventArgs args = new CellMouceClickedEventArgs(facilities);
            OnCellMouceClicked(args);

            return args;
        }

        private CellMouceClickedEventArgs OnCellMouceClickedForOut()
        {
            CellMouceClickedEventArgs args = new CellMouceClickedEventArgs();
            OnCellMouceClicked(args);

            return args;
        }

        public class CellMouceClickedEventArgs : EventArgs
        {
            public FacilitiesPower Facilities { get; set; }

            public CellMouceClickedEventArgs()
            {
            }

            public CellMouceClickedEventArgs(FacilitiesPower facilities)
            {
                Facilities = facilities;
            }
        }
        #endregion

        private void DgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvList.CurrentRow != null)
                OnCellMouceClicked(dgvList.CurrentRow.DataBoundItem as FacilitiesPower);
        }
    }
}
