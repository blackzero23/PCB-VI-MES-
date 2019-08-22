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
    public partial class SubJectForm : Form
    {
        public SubJectForm()
        {
            InitializeComponent();
        }

        private int itemName;
        private int firstDivision;
        private int secondDivision;

        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.SubjectControl.SubjectSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetItemDataSource(DB.Item.Search(e.ItemName, e.FirstDivision, e.SecondDivision));
            itemName = e.ItemName;
            firstDivision = e.FirstDivision;
            secondDivision = e.SecondDivision;
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }


        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            
            uscTopMenu.OpenInsertForm(new SubjectInsertNewForm());
            uscSearch.InitDatasource();
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "품목 정보");
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
           
            Data.Item item = uscList.GetCurrentLow();
            //uscTopMenu.DeleteAt(barcode.LotBarCodes);
            uscTopMenu.DeleteAt(item);
            uscList.SetItemDataSource(DB.Item.Search(itemName,firstDivision,secondDivision));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
