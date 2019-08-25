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
    public partial class DefectiveProductForm : Form
    {
        public DefectiveProductForm()
        {
            InitializeComponent();

            uscTopMenu.BtnInsert_FalseVisible();
            uscTopMenu.BtnDelete_FalseVisible();
        }

        private int _lotId;
        private DateTime _fromDate;
        private DateTime _toDate;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Production.DefectiveProduct.DefectiveProductSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.BarCode.SearchFail(e.LotId, e.FromDate, e.ToDate));
            _lotId = e.LotId;
            _fromDate = e.FromDate;
            _toDate = e.ToDate;
        }


        private void UscTopmenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.Barcode> barcodes = uscList.GetUpateList();

            if (barcodes == null)
                return;

            uscTopMenu.UpdateAll(barcodes);

            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopmenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            //올필요 없지.
        }

        private void UscTopmenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            //올필요 없지.
        }       


        private void UscTopmenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
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
