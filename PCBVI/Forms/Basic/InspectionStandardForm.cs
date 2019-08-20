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


        private int inspectioinType;
        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.InspectionStandard.InspectionStandardSearch.SearchButtonClickedEventArgs e)
        {

            uscList.SetItemDataSource(DB.InspectionStandard.Search(e.InspectionStandardType));
            inspectioinType = e.InspectionStandardType;

        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new InspectionStandardInsertNew());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "검사 기준 정보");
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.InspectionStandard inspection = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(inspection);
            uscList.SetItemDataSource(DB.InspectionStandard.Search(inspectioinType));
            
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }
    }
}
