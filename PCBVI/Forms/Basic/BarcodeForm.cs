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

namespace PCBVI.Forms.Basic
{
    public partial class BarcodeForm : Form
    {
        public BarcodeForm()
        {
            InitializeComponent();
        }
       
        private int _lotId;

        private void BarcodeSearch1_SearchButtonClicked(object sender, Controls.Basic.BarCode.BarcodeSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetBarcodeDataSource(DB.BarCode.Search(e.LotId));          
            _lotId = e.LotId;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
           // uscTopMenu.OpenInsertForm(new BarCodeInsertForm());
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
            MessageBox.Show("저장이 완료되었습니다.","알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
                

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            //에러 익셉션 처리 꼭해야됨.
            //고치고싶다.
            
            Data.Barcode barcode = uscList.GetCurrentLow();
            //uscTopMenu.DeleteAt(barcode.LotBarCodes);
            uscTopMenu.DeleteAt(barcode);
            uscList.SetBarcodeDataSource(DB.BarCode.Search(_lotId));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            uscTopMenu.SaveExcelFile(uscList.GetListView(), "바코드 정보");
        }
    }
}
