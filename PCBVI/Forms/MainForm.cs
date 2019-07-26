using System;
//폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PCBVI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void PanelMainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
