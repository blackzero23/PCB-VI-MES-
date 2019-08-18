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
    public partial class InspectionStForm : Form
    {
        public InspectionStForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.InspectionStandard.InspectionStandardSearch.SearchButtonClickedEventArgs e)
        {

            uscList.SetItemDataSource(DB.InspectionStandard.Search(e.InspectionStandardType));

        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new InspectionStandardInsertForm());
        }
    }
}
