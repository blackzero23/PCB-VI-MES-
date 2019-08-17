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

namespace PCBVI.Forms.Quality
{
    public partial class FirstInspectionForm : Form
    {
        public FirstInspectionForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Quality.FirstInspectionSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.FirstInspection.Search(e.OutCompanName,e.ItemId,e.FromDate,e.ToDate));
        }
    }
}
