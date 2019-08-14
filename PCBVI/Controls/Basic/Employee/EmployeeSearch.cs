using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data;

namespace PCBVI.Controls.Basic.Employee
{
    public partial class EmployeeSearch : UserControl
    {
        public EmployeeSearch()
        {
            InitializeComponent();
        }

        public void SetDepartmentSource(List<Department> list)
        {
            cbbDepartment.DataSource = list;
        }


        #region SearchCliked event things for C# 3.0
        public event EventHandler<SearchClikedEventArgs> SearchCliked;

        protected virtual void OnSearchCliked(SearchClikedEventArgs e)
        {
            if (SearchCliked != null)
                SearchCliked(this, e);
        }

        private SearchClikedEventArgs OnSearchCliked(string department, string employee)
        {
            SearchClikedEventArgs args = new SearchClikedEventArgs(department, employee);
            OnSearchCliked(args);

            return args;
        }

        private SearchClikedEventArgs OnSearchClikedForOut()
        {
            SearchClikedEventArgs args = new SearchClikedEventArgs();
            OnSearchCliked(args);

            return args;
        }

        public class SearchClikedEventArgs : EventArgs
        {
            public string Department { get; set; }
            public string Employee { get; set; }

            public SearchClikedEventArgs()
            {
            }

            public SearchClikedEventArgs(string department, string employee)
            {
                Department = department;
                Employee = employee;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string department = cbbDepartment.SelectedItem.ToString();
            string name = txbName.Text;

            OnSearchCliked(department, name);
        }
    }
}
