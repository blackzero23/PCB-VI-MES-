using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Controls.Basic.Employee
{
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private List<Data.Employee> _employees = new List<Data.Employee>();

        public void SetEmployeeDataSource(List<Data.Employee> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.Employee> GetUpateList()
        {
            return _employees;
        }

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Data.Employee employee)
            {
                _employees.Add(employee);
            }
            //var employee = dgvList.CurrentRow.DataBoundItem as Data.Employee;
            //if (employee != null)
            //{
            //    _employees.Add(employee);
            //}
        }
    }
}
