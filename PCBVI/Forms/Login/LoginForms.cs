using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace PCBVI.Forms.Login
{
    public partial class LoginForms : KryptonForm
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        //폼이 고정되어있어서 고정 풀어주고 움직여 주는 역활.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TxbId_Enter(object sender, EventArgs e)
        {
            if (txbId.Text == "아이디")
            {
                txbId.Text = "";
                txbId.ForeColor = Color.DimGray;
            }
        }

        private void TxbId_Leave(object sender, EventArgs e)
        {
            if (txbId.Text == "")
            {
                txbId.Text = "아이디";
                txbId.ForeColor = Color.DimGray;
            }
        }

        private void TxbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "비밀 번호")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.DimGray;
                txbPassword.UseSystemPasswordChar = true;

            }
        }

        private void TxbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "비밀 번호";
                txbPassword.ForeColor = Color.DimGray;
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForms_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
