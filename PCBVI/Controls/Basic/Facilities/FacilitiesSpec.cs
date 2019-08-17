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

namespace PCBVI.Controls.Basic.Facilities
{
    public partial class FacilitiesSpec : UserControl
    {
        public FacilitiesSpec()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            bdsProcess.DataSource = DB.Process.GetAll();
        }
        internal void setDataInfo(Facility facilities)
        {
 
            txbNo.Text = facilities.FacilitiesNo.ToString();
            txbName.Text = facilities.Name;
            cbbProcess.SelectedValue = facilities.ProcessId;
            txbState.Text = facilities.InspectionState ? "검사" : "미검사";
            txbUseState.Text = facilities.UseState ? "사용" : "미사용";
            txbWidth.Text = facilities.Width.ToString();
            txbLength.Text = facilities.length.ToString();
            txbHeight.Text = facilities.Height.ToString();
            txbWeight.Text = facilities.Weight.ToString();
            txbvolume.Text = facilities.volume.ToString();

        }
    }
}
