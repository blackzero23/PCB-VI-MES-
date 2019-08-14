using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PCBVI.Controls.Basic.ErrorCode
{
    public partial class ErrorCodeList : UserControl
    {
        public ErrorCodeList()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Data.ErrorCode> errorCodes)
        {
            errorCodeBindingSource.DataSource = errorCodes;
        }
    }
}
