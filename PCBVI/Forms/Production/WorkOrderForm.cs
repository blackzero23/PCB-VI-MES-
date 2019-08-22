using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Production
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
        }

        private void WorkOrderSearchControl1_SearchButtonClicked(object sender, Controls.Production.WorkOrder.WorkOrderSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.WorkOrder.Search(e.ItemId,e.RotationId,e.FromDate,e.ToDate));
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new WorkOrderInsertForm());
            uscList.InitSetDataSource();
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            uscTopMenu.SaveExcelFile(uscList.GetListView(), "작업 지시 목록");
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            uscTopMenu.DeleteAt(uscList.GetCurrentLow());
        }
    }
}
