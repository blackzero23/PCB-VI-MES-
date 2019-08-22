using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using PCBVI.Data;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Facilities
{
    public partial class FacilitiesPowerForm : Form
    {
        public FacilitiesPowerForm()
        {
            InitializeComponent();
        }

        private void FacilitiesPowerForm_Load(object sender, EventArgs e)
        {
            List<FacilitiesPower> todayFacilitiesList = DB.FacilitiesPower.TodayFacilitiesList();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Facilities.FacilitiesPSC.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.FacilitiesPower.Search(e.ProcessId,e.FacilitiesId,e.FromDate,e.ToDate));
        }



        private void UscList_CellMouceClicked(object sender, Controls.Facilities.FacilitiesPLC.CellMouceClickedEventArgs e)
        {
            double power = (e.Facilities.WorkTime.TotalHours / 24) * 1.0;
            double nonPower = ((24 - e.Facilities.WorkTime.TotalHours) / 24 ) * 1.0;

            

            chartCircle.Series["Series1"].Points.Clear();
            chartCircle.Series["Series1"].Points.AddXY("가동률",power);
            chartCircle.Series["Series1"].Points.AddXY("비가동율", nonPower);

           
            // bdsFacilitiesPower.DataSource = facilitiesPowers;
            //chartCircle.DataSource = e.Facilities;

        }
    }
}
