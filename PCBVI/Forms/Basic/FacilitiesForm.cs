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
    public partial class FacilitiesForm : Form
    {
        public FacilitiesForm()
        {
            InitializeComponent();
        }
        private int _FacilitiesId;
        private int _ProcessId;

        private void FacilitiesSearch1_SearchButtonClicked(object sender, Controls.Basic.Facilities.FacilitiesSearch.SearchButtonClickedEventArgs e)
        {
            uscList.setDataSource(DB.Facilities.Search(e.FacilitiesId,e.ProcessId));
            _FacilitiesId = e.FacilitiesId;
            _ProcessId = e.ProcessId;
        }
        

        private void UscList_CellContentClicked(object sender, Controls.Basic.Facilities.FacilitiesList.CellContentClickedEventArgs e)
        {
            uscSpec.setDataInfo(e.Facilities);
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new FacilitiesInsertForm());
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.Facility facilities = uscList.GetCurrentLow();
            if (facilities == null)
                return;
            uscTopMenu.DeleteAt(facilities);
            uscList.setDataSource(DB.Facilities.Search(_FacilitiesId, _ProcessId));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                uscTopMenu.SaveExcelFile(data, filePath, fileName);
            }
           
        }

        private void UscTopMenu_UpdateButtonClicked_1(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.Update(uscSpec.GetUpateInfo());
            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
