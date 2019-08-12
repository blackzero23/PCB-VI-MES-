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
    public partial class ErrorCodeForm : Form
    {
        public ErrorCodeForm()
        {
            InitializeComponent();
        }

        private void ErrorCodeForm_Load(object sender, EventArgs e)
        {
            var cbbErroCode = DB.ErrorCode.GetAll();

            uscSearch.SetErrorcodeDataSource(cbbErroCode);
        }
    }
}
