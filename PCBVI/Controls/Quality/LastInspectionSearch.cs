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

namespace PCBVI.Controls.Quality
{
    public partial class LastInspectionSearch : UserControl
    {
        public LastInspectionSearch()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }

        private void InitSetDataSource()
        {
            List<Data.Employee> employees = DB.Employee.GetAll();
            employees.Remove(employees.Select(x=>x).Where(x => x.Name == "관리자").FirstOrDefault());
            bdsEmployee.DataSource = employees;
            bdsItem.DataSource = DB.Item.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            string companyName = txbCompanyName.Text;
            int employeeId = (int)cbbEmployeeName.SelectedValue;
            int itemId = (int)cbbItemCode.SelectedValue;
            int workPlaceId = (int)cbbWorkPlace.SelectedValue;
            DateTime productionFrom = dtpProductionFromDate.Value;
            DateTime productionTo = dtpProductionToDate.Value;
            DateTime InspectionFrom = dtpInspectionFrom.Value;
            DateTime InspectionTo = dtpInspectionTo.Value;

            OnSearchButtonClicked(companyName, employeeId, itemId, workPlaceId, productionFrom, productionTo, InspectionFrom, InspectionTo);
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string companyname, int employeeId, int itemId, int workPlaceId, DateTime productionFrom, DateTime productionTo, DateTime inspectionFrom, DateTime inspectionTo)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(companyname, employeeId, itemId, workPlaceId, productionFrom, productionTo, inspectionFrom, inspectionTo);
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
            public string Companyname { get; set; }
            public int EmployeeId { get; set; }
            public int ItemId { get; set; }
            public int WorkPlaceId { get; set; }
            public DateTime ProductionFrom { get; set; }
            public DateTime ProductionTo { get; set; }
            public DateTime InspectionFrom { get; set; }
            public DateTime InspectionTo { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string companyname, int employeeId, int itemId, int workPlaceId, DateTime productionFrom, DateTime productionTo, DateTime inspectionFrom, DateTime inspectionTo)
            {
                Companyname = companyname;
                EmployeeId = employeeId;
                ItemId = itemId;
                WorkPlaceId = workPlaceId;
                ProductionFrom = productionFrom;
                ProductionTo = productionTo;
                InspectionFrom = inspectionFrom;
                InspectionTo = inspectionTo;
            }
        }
        #endregion
    }
}
