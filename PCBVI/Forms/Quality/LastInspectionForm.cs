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

namespace PCBVI.Forms.Quality
{
    public partial class LastInspectionForm : Form
    {
        public LastInspectionForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Quality.LastInspectionSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.LastInspection.Search(e.Companyname, e.EmployeeId,
                e.ProductionFrom, e.ProductionTo, e.ItemId, e.InspectionFrom, e.InspectionTo
                , e.WorkPlaceId));
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new LastInsertForm());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {           
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "출하전 검사");
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            //수정해야됨.
            Data.LastInspection lastInspection = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(lastInspection);
            //uscList.SetDataSource(DB.LastInspection//.Search);
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }
    }
}
