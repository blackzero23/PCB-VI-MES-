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

namespace PCBVI.Forms.Production
{
    public partial class MaterialsManageForm : Form
    {
        public MaterialsManageForm()
        {
            InitializeComponent();
        }

        private int _lotId;
        private int _processId;
        private int _materalStateId;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Production.MaterialsManage.MaterialManageSearch.SearchButtonClickedEventArgs e)
        {
            //workPlaceId -> materialId 임 시간나면 바꾸자.
            uscList.SetDataSource(DB.MaterialsManage.Search(e.LotId, e.ProcessId, e.WorkPlaceId));

            //장소 -> 상태 바꾸자.
            _lotId = e.LotId;
            _processId = e.ProcessId;
            _materalStateId = e.WorkPlaceId;
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.MaterialsManage> materialsManages = uscList.GetUpateList();

            if (materialsManages == null)
                return;
            
            uscTopMenu.UpdateAll(materialsManages);
            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.MaterialsManage materialsManage = uscList.GetCurrentLow();
            if (materialsManage == null)
                return;
            uscTopMenu.DeleteAt(materialsManage);
            uscList.SetDataSource(DB.MaterialsManage.Search(_lotId,_processId,_materalStateId));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new MaterialsManageInsertForm());
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
    }
}
