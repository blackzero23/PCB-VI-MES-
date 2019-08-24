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

        int _facilitiesId;
        int _workPlaceId;
        int _fHistoryDivisionId;
        DateTime _fromDate;
        DateTime _toDate;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Facilities.FacilitiesHSC.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.FacilitiesHistory.Search(e.FacilitiesId,e.WorkPlaceId,e.FHistoryDivisionId
                ,e.FromDate,e.ToDate));

            _facilitiesId = e.FacilitiesId;
            _workPlaceId = e.WorkPlaceId;
            _fHistoryDivisionId = e.FHistoryDivisionId;
            _fromDate = e.FromDate;
            _toDate = e.ToDate;
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.FacilitiesHistory facilitiesHistory = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(facilitiesHistory);
            uscList.SetDataSource(DB.FacilitiesHistory.Search(_facilitiesId,_workPlaceId,_fHistoryDivisionId
                ,_fromDate,_toDate));
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new FacilitiesHistoryInsertForm());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "설비 이력 정보");
        }
    }
}
