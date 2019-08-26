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

namespace PCBVI.Forms.Facilities
{
    public partial class FacilitiesHistoryInsertForm : KryptonForm
    {
        public FacilitiesHistoryInsertForm()
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
            bdsFacilities.DataSource = DB.Facilities.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
            bdsFHistoryDivision.DataSource = DB.FHistoryDivision.GetAll();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                Data.FacilitiesHistory facilitiesHistory = dgvList.Rows[0].DataBoundItem as Data.FacilitiesHistory;

                if (facilitiesHistory == null || facilitiesHistory.FacilitiesId == null || facilitiesHistory.WorkPlaceId == null || facilitiesHistory.FHistoryDivisionId == null)
                {
                    MessageBox.Show("등록 할 수있는 설비이력이 없습니다.");
                    return;
                }

            }

            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.FacilitiesHistory facilitiesHistory = dr.DataBoundItem as Data.FacilitiesHistory;

                if (facilitiesHistory == null || facilitiesHistory.FacilitiesId == null || facilitiesHistory.WorkPlaceId == null || facilitiesHistory.FHistoryDivisionId == null || string.IsNullOrWhiteSpace(facilitiesHistory.HistoryContent)) 
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                DB.FacilitiesHistory.Insert(facilitiesHistory);
            }
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


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("설 비"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("설비를 선택해주세요.");
                    e.Cancel = true;
                }
            }

           
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("장 소"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("장소를 선택해주세요.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("구 분"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("장소를 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("내 용"))
            {
                if (e.FormattedValue.ToString().Length < 5)
                {
                    MessageBox.Show("내용은 5글자 이상 입력 해주세요.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("업 체"))
            {
                if (e.FormattedValue.ToString().Length < 0)
                {
                    MessageBox.Show("업체명을 입력 해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("업체 번호"))
            {
                if (e.FormattedValue.ToString().Length < 0)
                {
                    MessageBox.Show("업체명을 입력 해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("업체 직원"))
            {
                if (e.FormattedValue.ToString().Length < 0)
                {
                    MessageBox.Show("업체직원을 입력 해주세요.");
                    e.Cancel = true;
                }
            }

           
        }
    }
}
