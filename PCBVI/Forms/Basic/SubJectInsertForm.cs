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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //널 값을 체크하고 거부할 수 있는 능력을 배양해야 할 것이다.
            //하나하나 if hasValue를 해야 하나?
            string first = TxbFirst.Text;
            string code = TxbCode.Text;
            string name = TxbName.Text;
            string second = TxbSecond.Text;
            string quantity = TxbQuantity.Text;
            string note = TxbNote.Text;
            string place = TxbWorkPlace.Text;

            
            if(first.Length <= 0 || code.Length <= 0 || name.Length <= 0 || second.Length <= 0 || quantity.Length <= 0 || place.Length <=0)
            {
                MessageBox.Show("입력값을 확인해주세요.");
                return;
            }

            int test = 0;
            bool isNum = int.TryParse(TxbQuantity.Text, out test);

            if(!isNum || test < 0)
            {
                MessageBox.Show("정수만 입력 가능합니다.");

                TxbQuantity.Text = "";
            }

            MessageBox.Show("네 이놈!");

        }

        private void TxbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        
        private void TxbQuantity_Leave(object sender, EventArgs e)
        {
             int test = 0;

            bool isNum = int.TryParse(TxbQuantity.Text, out test);

            if (!isNum || test < 0)
            {
                MessageBox.Show("정수만 입력 가능합니다.");

                TxbQuantity.Text = "";
            }

        }
    }
}
