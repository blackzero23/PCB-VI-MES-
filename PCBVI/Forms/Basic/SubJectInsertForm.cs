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
            
            string first = TxbFirst.Text;
            string code = TxbCode.Text;
            string name = TxbName.Text;
            string second = TxbSecond.Text;
            int quantity = Convert.ToInt32(TxbQuantity.Text);
            string note = TxbNote.Text;
            string place = TxbWorkPlace.Text;

        }
    }
}
