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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            uscSearch.SetDepartmentSource(DB.Department.GetAll());
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.Employee.EmployeeSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetEmployeeDataSource(DB.Employee.SeachEmployeeInfo(e.DepartmentId,e.Name));
            _departmentid = e.DepartmentId;
            _name = e.Name;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new EmployeeInsertForm());
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            uscTopMenu.UpdateAll(uscList.GetUpateList());
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            uscTopMenu.SaveExcelFile(uscList.GetListView(), "사원 정보");            
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
           //에러 익셉션 처리 꼭해야됨.
           //고치고싶다.
           Data.Employee employee =  uscList.GetCurrentLow();
           uscTopMenu.DeleteAt(employee);
           uscList.SetEmployeeDataSource(DB.Employee.SeachEmployeeInfo(_departmentid, _name));
        }
    }
}
