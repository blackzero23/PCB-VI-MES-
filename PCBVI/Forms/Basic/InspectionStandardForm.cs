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

            string fileName = null;
            string filePath = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "저장경로 지정하세요.";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = " Excel97 - 2003 통합문서(*.xls) | *.xls | Excle 통합 문서(*.xlsx)| *.xlsx ";
            //saveFileDialog.Filter = "Excle 통합 문서(*.xlsx)| *.xlsx | Excel97 - 2003 통합문서(*.xls) | *.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                filePath = Path.GetFullPath(saveFileDialog.FileName);
            }


            uscTopMenu.SaveExcelFile(data, filePath, fileName);
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.InspectionStandard inspection = uscList.GetCurrentLow();
            if (inspection == null)
                return;
            uscTopMenu.DeleteAt(inspection);
            uscList.SetItemDataSource(DB.InspectionStandard.Search(inspectioinType));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.InspectionStandard> inspectionStandards = uscList.GetUpateList();

            if (inspectionStandards == null)
                return;

            uscTopMenu.UpdateAll(inspectionStandards);

            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
