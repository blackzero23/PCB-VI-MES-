using PCBVI.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms.Basic
{
    public partial class SubJectForm : Form
    {
        public SubJectForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.SubjectControl.SubjectSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetItemDataSource(DB.Item.Search(e.ItemCode, e.ItemName, e.FirstDivision, e.SecondDivision));
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.Item> items = uscList.GetUpateList();
            uscTopMenu.UpdateAll(items);
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            //차후 수정이 필요함
            uscTopMenu.OpenInsertForm(new SubJectInsertForm());
        }
    }
}
