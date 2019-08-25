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
    public partial class WorkLogForm : Form
    {
        public WorkLogForm()
        {
            InitializeComponent();
            uscTopMenu.BtnExcel_OnlyShowVisible();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            uscTopMenu.BtnExcel_OnlyShowVisible();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Production.WorkLog.WorkLogSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.WorkLog.Search(e.ItemId, e.RotationId, e.FromDate, e.ToDate));
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
