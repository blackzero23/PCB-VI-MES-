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
            List<Data.FirstInspection> firstInspections = uscList.GetUpateList();

            if (firstInspections == null)
                return;

            uscTopMenu.UpdateAll(firstInspections);

            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);           
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
            Data.FirstInspection firstInspection = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(firstInspection);
            uscList.SetDataSource(DB.FirstInspection.Search(_companyName, _itemId, _fromDate, _toDate));
        }
    }
}
