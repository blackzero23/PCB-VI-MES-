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

namespace PCBVI.Forms.Materials
{
    public partial class MaterialsHistoryForm : Form
    {
        public MaterialsHistoryForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Materials.MaterialsHSC.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.MaterialHistory.Search(e.LotId));
        }
    }
}
