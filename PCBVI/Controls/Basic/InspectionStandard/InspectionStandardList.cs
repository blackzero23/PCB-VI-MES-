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

namespace PCBVI.Controls.Basic.InspectionStandard
{
    public partial class InspectionStandardList : UserControl
    {
        public InspectionStandardList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            //bdsInspectionStandard.DataSource = DB.InspectionStandardType.GetAll();

            bdsInspectionStandardType.DataSource =
                DB.InspectionStandardType.GetAll();
            
        }

        public List<Data.InspectionStandardType> GetUpateList()
        {
            return (List<Data.InspectionStandardType>)dgvList.DataSource;
        }
        

        public void SetItemDataSource(List<Data.InspectionStandard> list)
        {
            dgvList.DataSource = list;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

    }
}
