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

namespace PCBVI.Forms.Quality
{
    public partial class LastInspectionForm : Form
    {
        public LastInspectionForm()
        {
            InitializeComponent();
        }

        string _companyName;
        string _employeeName;
        DateTime _fromDate;
        DateTime _toDate;
        int _itemId;
        int _workPlaceId;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Quality.LastInspectionSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.LastInspection.Search(e.CompanyName, e.EmployeeName,
                e.ProductionFrom, e.ProductionTo, e.ItemId,
                e.WorkPlaceId));

            _companyName = e.CompanyName;
            _employeeName = e.EmployeeName;
            _fromDate = e.ProductionFrom;
            _toDate = e.ProductionTo;
            _itemId = e.ItemId;
            _workPlaceId = e.WorkPlaceId;

        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new LastInsertForm());
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

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.LastInspection lastInspection = uscList.GetCurrentLow();
            if (lastInspection == null)
                return;
            uscTopMenu.DeleteAt(lastInspection);
            
            uscList.SetDataSource(DB.LastInspection.Search(_companyName, _employeeName, _fromDate, _toDate
                , _itemId, _workPlaceId));

            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.LastInspection> lastInspections = uscList.GetUpateList();

            if (lastInspections == null)
                return;

            uscTopMenu.UpdateAll(lastInspections);

            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }
    }
}
