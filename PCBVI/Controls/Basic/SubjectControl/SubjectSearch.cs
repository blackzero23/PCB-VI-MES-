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

namespace PCBVI.Controls.Basic.SubjectControl
{
    public partial class SubjectSearch : UserControl
    {
        public SubjectSearch()
        {
            InitializeComponent();
        }

        //USC가 로드될때 이용하는곳.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            InitDatasource();
        }


        //초기화
        public void InitDatasource()
        {
            var items = DB.Item.GetAll();
            items.Insert(0, new Item(""));
            bdsItem.DataSource = items;

            var firstDivisions = DB.FirstItemDivision.GetAll();
            firstDivisions.Insert(0, new FirstItemDivision(""));
            bdsFirstDivision.DataSource = firstDivisions;

            var secondDivisions = DB.SecondItemDivision.GetAll();
            secondDivisions.Insert(0, new SecondItemDivision(""));
            bdsSecondDivision.DataSource = secondDivisions;


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            int itemName = (int)cbbName.SelectedValue;
            int firstDivision = (int)cbbFirstDivision.SelectedValue;
            int secondDivision = (int)
                cbbSecondDivision.SelectedValue;

            OnSearchButtonClicked( itemName, firstDivision, secondDivision);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int itemName, int firstDivision, int secondDivision)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs( itemName, firstDivision, secondDivision);
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
           
            public int ItemName { get; set; }
            public int FirstDivision { get; set; }
            public int SecondDivision { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int itemName, int firstDivision, int secondDivision)
            {
                ItemName = itemName;
                FirstDivision = firstDivision;
                SecondDivision = secondDivision;
            }
        }
        #endregion
    }
}
