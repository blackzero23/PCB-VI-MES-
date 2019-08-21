using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using PCBVI.Data;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Basic
{
    public partial class FacilitiesInsertForm : KryptonForm
    {
        public FacilitiesInsertForm()
        {
            InitializeComponent();
        }

        private void FacilitiesInsertForm_Load(object sender, EventArgs e)
        {
            bdsProcess.DataSource = DB.Process.GetAll();
        }

       

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            //설비번호 란 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("설비번호"))
            {
                int facilitiesNo;
                //if (e.FormattedValue.ToString().Length > 3)
                if (!int.TryParse(e.FormattedValue.ToString(), out facilitiesNo))
                {
                    MessageBox.Show("숫자만 입력가능");
                 
                    e.Cancel = true;
                }


                if (e.FormattedValue.ToString().Length > 7)
                {
                    MessageBox.Show("7글자 이하로만 입력가능.");
                    e.Cancel = true;
                }

                Facility facility = DB.Facilities.CheckFacilitiesNo(facilitiesNo);

                if (facility != null)
                {
                    MessageBox.Show("중복된 설비 번호 입니다.");
                    e.Cancel = true;
                }

                if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("공정구분"))
                {
                    if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("공정을 선택해주세요.");
                        e.Cancel = true;
                    }
                }


            }

            ///부서 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("부서"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("부서를 선택해주세요.");
                    e.Cancel = true;
                }
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //processId 만 NullAble 형태로 만들어주면된다.
            if (dgvList.Rows.Count > 0)
            {
                Data.Facility facilities = dgvList.Rows[0].DataBoundItem as Facility;
                if (facilities == null || facilities.FacilitiesNo == 0 || string.IsNullOrWhiteSpace(facilities.Name)
                    || facilities.ProcessId == null)
                {
                    MessageBox.Show("등록 할 수있는 설비가 없습니다.");
                    return;
                }

            }

            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.Facility facilities = dgvList.Rows[0].DataBoundItem as Facility;
                if (facilities == null || facilities.FacilitiesNo == 0 || string.IsNullOrWhiteSpace(facilities.Name)
                    || facilities.ProcessId == null)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                DB.Facilities.Insert(facilities);
            }

        }

    }
}
