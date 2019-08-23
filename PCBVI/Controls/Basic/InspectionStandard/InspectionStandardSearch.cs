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

namespace PCBVI.Controls.Basic.InspectionStandard
{
    public partial class InspectionStandardSearch : UserControl
    {
        public InspectionStandardSearch()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitDataSource();

        }

        private void InitDataSource()
        {
            List<Data.InspectionStandardType> inspections = DB.InspectionStandardType.GetAll();
            inspections.Insert(0, new InspectionStandardType(""));
            bdsInspectionStandarType.DataSource = inspections;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int inspectionStandardType = (int)cbbErrorCode.SelectedValue;

            OnSearchButtonClicked(inspectionStandardType);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int inspectionStandardType)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(inspectionStandardType);
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
            public int InspectionStandardType { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int inspectionStandardType)
            {
                InspectionStandardType = inspectionStandardType;
            }
        }
        #endregion
    }
}
