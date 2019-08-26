using PCBVI.Data.Data;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PCBVI.Forms.Basic
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private int _departmentid;
        private string _name;


        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.Employee.EmployeeSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetEmployeeDataSource(DB.Employee.SeachEmployeeInfo(e.DepartmentId, e.Name));
            _departmentid = e.DepartmentId;
            _name = e.Name;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new EmployeeInsertForm());
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.Employee> employees = uscList.GetUpateList();

            if (employees == null)
                return;

            uscTopMenu.UpdateAll(uscList.GetUpateList());

            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();

            string fileName = null;
            string filePath = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "저장경로 지정하세요.";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "Excle 통합 문서(*.xlsx)| *.xlsx | Excel97 - 2003 통합문서(*.xls) | *.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                filePath = Path.GetFullPath(saveFileDialog.FileName);
                uscTopMenu.SaveExcelFile(data, filePath, fileName);
            }
            
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
           
            Data.Employee employee = uscList.GetCurrentLow();
            if (employee == null)
                return;
            uscTopMenu.DeleteAt(employee);

            uscList.SetEmployeeDataSource(DB.Employee.SeachEmployeeInfo(_departmentid, _name));

            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
