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
    public partial class ErrorCodeForm : Form
    {
        public ErrorCodeForm()
        {
            InitializeComponent();
        }

        private int _code;
        private int _kind;
        private int _type;

        private void UscSearch_SearchClicked(object sender, Controls.Basic.ErrorCode.ErrorCodeSearch.SearchClickedEventArgs e)
        {
            uscList.SetDataSource(DB.ErrorCode.Search(e.ErrorCodeId, e.ErrorTypeId, e.ErrorKindId));
            _code = e.ErrorCodeId;
            _type = e.ErrorTypeId;
            _kind = e.ErrorKindId;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new ErrorcodeInsertForm());
            uscSearch.InitSetDataSource();
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            uscTopMenu.SaveExcelFile(uscList.GetListView(), "불량 정보");
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.ErrorCode errorCodes = uscList.GetCurrentLow();
            uscTopMenu.DeleteAt(errorCodes);
            uscList.SetDataSource(DB.ErrorCode.Search(_code, _kind, _type));
            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
