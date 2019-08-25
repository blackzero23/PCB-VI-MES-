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
            dgvList.DataSource = errorCodes;
        }

        private List<Data.ErrorCode> _errorcodes = new List<Data.ErrorCode>();

        public List<Data.ErrorCode> GetUpateList()
        {
            List<Data.ErrorCode> errorCodes = null;
            try
            {
                errorCodes = (List<Data.ErrorCode>)dgvList.DataSource;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("수정할 목록이 없습니다.");
            }

            return errorCodes;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }

        public Data.ErrorCode GetCurrentLow()
        {
            Data.ErrorCode errorCode = null;
            try
            {
                errorCode = dgvList.CurrentRow.DataBoundItem as Data.ErrorCode;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제할 요소가 없습니다.");
            }

            return errorCode;
        }

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow.DataBoundItem is Data.ErrorCode errorCodes)
            {
                _errorcodes.Add(errorCodes);
            }
        }
    }
}
