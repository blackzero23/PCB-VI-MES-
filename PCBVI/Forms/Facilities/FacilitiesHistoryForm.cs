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

namespace PCBVI.Forms.Facilities
{
    public partial class FacilitiesHistoryForm : Form
    {
        public FacilitiesHistoryForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Facilities.FacilitiesHSC.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.FacilitiesHistory.Search(e.FacilitiesId,e.WorkPlaceId,e.WorkPlaceId
                ,e.FromDate,e.ToDate));

        }
    }
}
