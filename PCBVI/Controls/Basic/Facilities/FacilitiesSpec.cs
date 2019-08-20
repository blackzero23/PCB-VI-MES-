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
    public partial class facilitiesSpec : UserControl
    {
        public facilitiesSpec()
        {
            InitializeComponent();
        }

        Facility _facility;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            List<Process> processes=DB.Process.GetAll();
            processes.Insert(0, new Process(""));
            bdsProcess.DataSource = processes;

        }
        public void setDataInfo(Facility facilities)
        {
            _facility = facilities;
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
        
        public Facility GetUpateInfo()
        {

            _facility.FacilitiesNo = int.Parse(txbNo.Text);
            _facility.Name = txbName.Text;
            _facility.ProcessId = (int)cbbProcess.SelectedValue;
            if (txbState.Text == "검사")
                _facility.InspectionState = true;
            else if(txbState.Text=="미검사")
                _facility.InspectionState = false;
            if (txbUseState.Text == "사용")
                _facility.UseState = true;
            else if (txbUseState.Text == "미사용")
                _facility.UseState = false;
            _facility.Width = double.Parse(txbWidth.Text);
            _facility.length= double.Parse(txbLength.Text);
            _facility.Height= double.Parse(txbHeight.Text);
            _facility.Weight= double.Parse(txbWeight.Text);
            _facility.volume= double.Parse(txbvolume.Text);

            return _facility;
        }

       
    }
}
