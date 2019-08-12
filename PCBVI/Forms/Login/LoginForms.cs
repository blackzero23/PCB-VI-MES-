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
using PCBVI.Data;
using PCBVI.Data.Data;
using PCBVI.Forms.Main;

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
                txbId.ForeColor = Color.DarkGray;
            }
        }

        private void TxbId_Leave(object sender, EventArgs e)
        {
            if (txbId.Text == "")
            {
                txbId.Text = "아이디";
                txbId.ForeColor = Color.DarkGray;
            }
        }

        private void TxbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "비밀 번호")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.DarkGray;
                txbPassword.UseSystemPasswordChar = true;

            }
        }

        private void TxbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "비밀 번호";
                txbPassword.ForeColor = Color.DarkGray;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbId.Text) || txbId.Text.Equals("아이디"))
            {
                MessageBox.Show("ID를 입력해주세요");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbPassword.Text) || txbPassword.Text.Equals("비밀 번호"))
            {
                MessageBox.Show("Password를 입력해주세요");
                return;
            }

            Employee employee = DB.Employee.IsCorrectEmployee(txbId.Text, txbPassword.Text);

            if (employee != null)
            {
                //싱글톤 적용 생각.
                MainForm loginSuccess = new MainForm(employee);
                loginSuccess.FormClosed += new FormClosedEventHandler(LoginSuccessFormClosed);
                loginSuccess.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID 혹은 Password가 옳지 않습니다.");
                return;
            }

            //LogOut 했을시 NULL.

        }

    private void LoginSuccessFormClosed(object sender, FormClosedEventArgs e)
        {
            //이창이 닫힐때가 아닌 로그아웃 을했을때.
            this.Show();
            //this.Close();
            //this.ParentForm?.Show();
        }
    }
}
