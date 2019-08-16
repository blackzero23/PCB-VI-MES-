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

        private List<Data.Employee> _employees = new List<Data.Employee>();

        public void SetEmployeeDataSource(List<Data.Employee> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.Employee> GetUpateList()
        {
            return (List<Data.Employee>)dgvList.DataSource;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.Employee GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.Employee;
        }


        /// <summary>
        /// 에러 처리 못하면 이 함수는 쓸수없는함수.
        /// </summary>       
        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Data.Employee employee)
            {
                _employees.Add(employee);
            }           
        }
    }
}
