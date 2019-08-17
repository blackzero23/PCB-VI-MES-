using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Basic
{
    public partial class FacilitiesForm : Form
    {
        public FacilitiesForm()
        {
            InitializeComponent();
        }

        private void FacilitiesSearch1_SearchButtonClicked(object sender, Controls.Basic.Facilities.FacilitiesSearch.SearchButtonClickedEventArgs e)
        {
            uscList.setDataSource(DB.Facilities.Search(e.FacilitiesId,e.ProcessId));
        }

        private void UscList_CellContentClicked(object sender, Controls.Basic.Facilities.FacilitiesList.CellContentClickedEventArgs e)
        {
            uscSpec.setDataInfo(e.Facilities);
        }
    }
}
