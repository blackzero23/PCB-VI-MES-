using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Basic
{
    public partial class ErrorcodeInsertForm : Form
    {
        public ErrorcodeInsertForm()
        {
            InitializeComponent();
        }

        private void KryptonButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //유효성 검사
        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            //이름 란 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("에러코드"))
            {
                string errorCodeName = e.FormattedValue.ToString();
                char[] charArr = errorCodeName.ToCharArray();
                foreach (char c in charArr)
                {
                    if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                    {
                        MessageBox.Show("영어와 숫자만 입력해주세요");
                        e.Cancel = true;
                    }
                }

                if (e.FormattedValue.ToString().Length > 7)
                {
                    MessageBox.Show("7글자 이하로만 입력가능.");
                    e.Cancel = true;
                }

                //중복체크
                ErrorCode errorCode = DB.ErrorCode.CheckErroCode(errorCodeName);
                if (errorCode != null)
                {
                    MessageBox.Show("중복된 코드 입니다.");
                    e.Cancel = true;
                }



            }
            
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("에러유형"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("에러유형을 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("에러군"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("에러군을 선택해주세요.");
                    e.Cancel = true;
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                Data.ErrorCode errorCode = dgvList.Rows[0].DataBoundItem as ErrorCode;
                if (errorCode == null || string.IsNullOrWhiteSpace(errorCode.Code) || errorCode.ErrorKindId == null ||
                    errorCode.ErrorTypeId == null)
                {
                    MessageBox.Show("등록 할 수있는 에러코드가 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.ErrorCode errorCode = dgvList.Rows[0].DataBoundItem as ErrorCode;

                if (errorCode == null || string.IsNullOrWhiteSpace(errorCode.Code) || errorCode.ErrorKindId == null ||
                    errorCode.ErrorTypeId == null)

                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                DB.ErrorCode.Insert(errorCode);
            }
        }
    }
}
