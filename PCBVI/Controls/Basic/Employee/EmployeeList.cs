using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Basic.Employee
{
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }
        //dddd

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            departmentBindingSource.DataSource = DB.Department.GetAll();
        }

        

        public void SetEmployeeDataSource(List<Data.Employee> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.Employee> GetUpateList()
        {
            List<Data.Employee> employees = null;
            try
            {
                employees = (List<Data.Employee>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(@"수정할 목록이 없습니다.");    
            }

            return employees;
            
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.Employee GetCurrentLow()
        {
            Data.Employee employee = null;
            try
            {
                employee = dgvList.CurrentRow.DataBoundItem as Data.Employee;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return employee;
        }


        
    }
}
