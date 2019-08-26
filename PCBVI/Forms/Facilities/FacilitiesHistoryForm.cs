using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            List<Data.FacilitiesHistory> facilitiesHistories = uscList.GetUpateList();

            if (facilitiesHistories == null)
                return;

            uscTopMenu.UpdateAll(facilitiesHistories);
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.FacilitiesHistory facilitiesHistory = uscList.GetCurrentLow();

            if (facilitiesHistory == null)
                return;

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

            string fileName = null;
            string filePath = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "저장경로 지정하세요.";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "Excle 통합 문서(*.xlsx)| *.xlsx | Excel97 - 2003 통합문서(*.xls) | *.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                filePath = Path.GetFullPath(saveFileDialog.FileName);
                uscTopMenu.SaveExcelFile(data, filePath, fileName);
            }
        }
    }
}
