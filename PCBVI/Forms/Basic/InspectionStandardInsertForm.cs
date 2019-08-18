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

namespace PCBVI.Forms.Basic
{
    public partial class InspectionStandardInsertForm : Form
    {
        public InspectionStandardInsertForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bdsStandard.DataSource =
                DB.InspectionStandard.GetAll();
            bdsType.DataSource =
                DB.InspectionStandardType.GetAll();
            
            

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(txbCode.Text.Length <= 0 || txbName.Text.Length <= 0)
            {
                MessageBox.Show("입력 상황을 다시 확인하시기 바랍니다.");
                
                return;
            }
        }
    }
}
