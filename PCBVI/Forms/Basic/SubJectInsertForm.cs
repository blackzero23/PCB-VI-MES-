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
    public partial class SubJectInsertForm : Form
    {
        public SubJectInsertForm()
        {
            InitializeComponent();
          
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bdsFirst.DataSource =
                DB.FirstItemDivision.GetAll();
            bdsItem.DataSource =
                DB.Item.GetAll();
            bdsSecond.DataSource =
                DB.SecondItemDivision.GetAll();
            bdsPlace.DataSource =
                DB.WorkPlace.GetAll();

        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            //널 값을 체크하고 거부할 수 있는 능력을 배양해야 할 것이다.
            //하나하나 if hasValue를 해야 하나?
            string first = txbFirst.Text;
            string code = txbCode.Text;
            string name = txbName.Text;
            string second = txbSecond.Text;
            string quantity = txbQuantity.Text;
            string note = txbNote.Text;
            string place = txbPlace.Text;


            if (first.Length <= 0 || code.Length <= 0 || name.Length <= 0 || second.Length <= 0 || quantity.Length <= 0 || place.Length <= 0)
            {
                MessageBox.Show("입력값을 확인해주세요.");
                return;
            }

            int test = 0;
            bool isNum = int.TryParse(txbQuantity.Text, out test);

            if (!isNum || test < 0)
            {
                MessageBox.Show("정수만 입력 가능합니다.");

                txbQuantity.Text = "";
                return;
            }

            MessageBox.Show("네 이놈!");

            // 여기서 DB에 넣는 작업을 하고 그 후에


            // 다시 DB 내용 다시 싹다 불러오게끔?
            // 가능하다면 방금 넣은 것을 제일 상단에 표시하게끔
        }

        private void TxbQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TxbQuantity_Leave_1(object sender, EventArgs e)
        {
            int test = 0;

            bool isNum = int.TryParse(txbQuantity.Text, out test);

            if (!isNum || test < 0)
            {
                MessageBox.Show("정수만 입력 가능합니다.");

                txbQuantity.Text = "";
            }

        }
    }
}
