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
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.MaterialsManage materialsManage = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(materialsManage);
            uscList.SetDataSource(DB.MaterialsManage.Search(_lotId,_processId,_materalStateId));
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new MaterialsManageInsertForm());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();
            uscTopMenu.SaveExcelFile(data, "자재 투입 정보");
        }
    }
}
