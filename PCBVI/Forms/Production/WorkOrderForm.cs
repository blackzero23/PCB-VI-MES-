using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Production
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
        }

        private void WorkOrderSearchControl1_SearchButtonClicked(object sender, Controls.Production.WorkOrder.WorkOrderSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.WorkOrder.Search(e.ItemId,e.RotationId,e.FromDate,e.ToDate));
        }
    }
}
