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
            uscTopMenu.UpdateAll(uscList.GetUpateList());
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
            uscTopMenu.SaveExcelFile(data, "불량 정보");
        }
    }
}
