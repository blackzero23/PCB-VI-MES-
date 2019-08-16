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
            //데이터 바인딩 곳에 데이터를 불러와서 넣는다.
            bdsFirstDivision.DataSource = DB.FirstItemDivision.GetAll();

            bdsSecondDivision.DataSource =
                DB.SecondItemDivision.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string itemCode = txbItemCode.Text;
            string itemName = txbItemName.Text;
            int firstDivision = (int)cbbFirstDivision.SelectedValue;
            int secondDivision = (int)
                cbbSecondDivision.SelectedValue;

            OnSearchButtonClicked(itemCode, itemName, firstDivision, secondDivision);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string itemCode, string itemName, int firstDivision, int secondDivision)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(itemCode, itemName, firstDivision, secondDivision);
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
            public string ItemCode { get; set; }
            public string ItemName { get; set; }
            public int FirstDivision { get; set; }
            public int SecondDivision { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string itemCode, string itemName, int firstDivision, int secondDivision)
            {
                ItemCode = itemCode;
                ItemName = itemName;
                FirstDivision = firstDivision;
                SecondDivision = secondDivision;
            }
        }
        #endregion
    }
}
