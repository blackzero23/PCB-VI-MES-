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

namespace PCBVI.Forms.Production
{
    public partial class MaterialsManageForm : Form
    {
        public MaterialsManageForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Production.MaterialsManage.MaterialManageSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.MaterialsManage.Search(e.LotId, e.ProcessId, e.WorkPlaceId));
        }
    }
}
