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
            uscTopMenu.DeleteAt(facilities);
            uscList.setDataSource(DB.Facilities.Search(_FacilitiesId, _ProcessId));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            uscTopMenu.SaveExcelFile(uscList.GetListView(), "설비 정보");
        }

        private void UscTopMenu_UpdateButtonClicked_1(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.Update(uscSpec.GetUpateInfo());
            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
