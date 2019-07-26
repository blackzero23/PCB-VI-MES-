using PCBVI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PtbMinimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void PtbCnacle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PtbMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMin.Visible = true;
            ptbMax.Visible = false;
        }

        private void PtbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbMin.Visible = false;
            ptbMax.Visible = true;
        }
    }
}
