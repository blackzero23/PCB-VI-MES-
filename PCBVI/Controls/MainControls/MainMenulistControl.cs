using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Properties;

namespace PCBVI.Controls.MainControls
{
    enum category//메터정보,생산,자재,설비,품질,모니터링,통계
    {
        Basic, Production, Materials, Facilities, Quality, Monitoring, Statistics
    }
    public partial class MainMenulistControl : UserControl
    {
        //접힘 묻는 상태들
        private bool[] isCollapsed = { true, true, true, true, true, true, true};
        public MainMenulistControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 드롭 다운 관련 타이머 함수
        /// 매개변수  타이머 판넬 버튼 카테고리
        /// </summary>    
        private void TimerDropDown(Timer timer,Panel panel, Button button ,int category)
        {
            if(isCollapsed[category])
            {
                button.Image = Resources.Collapse_Arrow_20px;
                panel.Height += 10;
                if(panel.Size == panel.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed[category] = false;
                }
            }
            else
            {
                button.Image = Resources.Expand_Arrow_20px;
                panel.Height -= 10;
                if (panel.Size == panel.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed[category] = true;
                }

            }
        }


      

        private void TimerBasicDropDown_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerBasicDropDown, panelBasicInfo, btnBasicInfo, (int)category.Basic);
        }
        private void BtnBasicInfo_Click(object sender, EventArgs e)
        {
            timerBasicDropDown.Start();
        }

        private void TimerProduction_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerProduction, panelProduction, btnProduction, (int)category.Production);
        }

        private void BtnProduction_Click(object sender, EventArgs e)
        {
            timerProduction.Start();
        }
        private void TimerMaterials_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerMaterials, panelMaterials, btnMaterials, (int)category.Materials);
        }

        private void BtnMaterials_Click(object sender, EventArgs e)
        {
            timerMaterials.Start();
        }

        private void TimerFacilities_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerFacilities, panelFacilities, btnFacilities, (int)category.Facilities);
        }

        private void BtnFacilities_Click(object sender, EventArgs e)
        {
            timerFacilities.Start();
        }

        private void TimerQuality_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerQuality, panelQuality, btnQuality, (int)category.Quality);
        }

        private void BtnQuality_Click(object sender, EventArgs e)
        {
            timerQuality.Start();
        }

        private void TimerMonitering_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerMonitering, panelMonitering, btnMonitering, (int)category.Monitoring);
        }
        private void BtnMonitering_Click(object sender, EventArgs e)
        {
            timerMonitering.Start();
        }
        private void TimerStatistics_Tick(object sender, EventArgs e)
        {
            TimerDropDown(timerStatistics, panelStatistics, btnStatistics, (int)category.Statistics);
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            timerStatistics.Start();
        }
    }
}
