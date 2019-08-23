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
    public partial class FirstInspectionForm : Form
    {
        public FirstInspectionForm()
        {
            InitializeComponent();
        }

        private string _companyName;
        private int _itemId;
        private DateTime _fromDate;
        private DateTime _toDate;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Quality.FirstInspectionSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.FirstInspection.Search(e.OutCompanName,e.ItemId,e.FromDate,e.ToDate));
            _companyName = e.OutCompanName;
            _itemId = e.ItemId;
            _fromDate = e.FromDate;
            _toDate = e.ToDate;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new FirstInsertForm());
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "수입 검사");
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.FirstInspection firstInspection = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(firstInspection);
            uscList.SetDataSource(DB.FirstInspection.Search(_companyName, _itemId, _fromDate, _toDate));
        }
    }
}
