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
using PCBVI.Data.Data;

namespace PCBVI.Controls.Basic.Employee
{
    public partial class EmployeeSearch : UserControl
    {
        public EmployeeSearch()
        {
            InitializeComponent();
        }

        //초기화         
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitDatasource();
        }

        private void InitDatasource()
        {
            List<Department> departments = DB.Department.GetAll();
            departments.Insert(0, new Department(""));
            cbbDepartment.DataSource = departments;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int departmentId = (int)cbbDepartment.SelectedValue;
            string name = txbName.Text;

            OnSearchButtonClicked(departmentId, name);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int departmentId, string name)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(departmentId, name);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public int DepartmentId { get; set; }
            public string Name { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int departmentId, string name)
            {
                DepartmentId = departmentId;
                Name = name;
            }
        }
        #endregion
    }
}
