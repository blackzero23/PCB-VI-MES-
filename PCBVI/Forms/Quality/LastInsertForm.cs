using ComponentFactory.Krypton.Toolkit;
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

namespace PCBVI.Forms.Quality
{
    public partial class LastInsertForm : KryptonForm
    {
        public LastInsertForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }

        private void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            if (dgvList.Rows.Count > 0)
            {
                Data.LastInspection lastInspection = dgvList.Rows[0].DataBoundItem as Data.LastInspection;
                if (lastInspection == null || string.IsNullOrWhiteSpace(lastInspection.OCompanyName) || lastInspection.ItemId == null || lastInspection.WorkPlaceId == null)
                {
                    MessageBox.Show("등록 할 수있는 출하검사 목록이 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.LastInspection lastInspection = dr.DataBoundItem as Data.LastInspection;
                if (lastInspection == null || string.IsNullOrWhiteSpace(lastInspection.OCompanyName) || lastInspection.ItemId == null || lastInspection.WorkPlaceId == null)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }
                DB.LastInspection.Insert(lastInspection);
            }
        }

        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("업체명"))
            {
                int newInteger;

                if (int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자는 입력 불가능!");

                    e.Cancel = true;

                }

                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("업체명을 입력해주세요");
                    e.Cancel = true;
                }

                if (e.FormattedValue.ToString().Length > 7)
                {
                    MessageBox.Show("7글자 이하로만 입력가능.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("품목"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("품목을 선택해주세요.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("장 소"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("품목을 선택해주세요.");
                    e.Cancel = true;
                }
            }



            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("미검사량"))
            {
                int newInteger;

                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;

                }

                if (newInteger < 0)
                {
                    MessageBox.Show("음수는 입력이 불가능합니다.");
                    e.Cancel = true;
                }

            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("검사량"))
            {
                int newInteger;

                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;

                }

                if (newInteger < 0)
                {
                    MessageBox.Show("음수는 입력이 불가능합니다.");
                    e.Cancel = true;
                }

            }

        }
    }
}
