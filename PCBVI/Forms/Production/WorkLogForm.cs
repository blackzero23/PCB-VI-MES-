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
    public partial class WorkLogForm : Form
    {
        public WorkLogForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Production.WorkLog.WorkLogSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.WorkLog.Search
                (e.ItemId, e.RotationId, e.FromDate, e.ToDate));
        }
    }
}
