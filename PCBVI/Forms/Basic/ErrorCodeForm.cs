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

        private void UscSearch_SearchClicked(object sender, Controls.Basic.ErrorCode.ErrorCodeSearch.SearchClickedEventArgs e)
        {
            var errorCodes = DB.ErrorCode.Search(e.Code, e.Kind, e.Type);
            
            errorCodeList1.SetDataSource(errorCodes);
        }
    }
}
