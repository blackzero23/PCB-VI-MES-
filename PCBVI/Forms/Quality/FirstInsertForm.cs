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
    public partial class FirstInsertForm : KryptonForm
    {
        public FirstInsertForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitDataSource();
        }

        private void InitDataSource()
        {
            bdsEmployee.DataSource = DB.Employee.GetAll();
            bdsItem.DataSource = DB.Item.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
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


            
            ///업체명 품목 장소 입고일, 검사일 입고수량 검사수량 합격수량 불량 수량 검사자.            
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("업체명"))
            {
                if (e.FormattedValue.ToString().Length > 7)
                {
                    MessageBox.Show("7글자 이하로만 입력가능.");
                    e.Cancel = true;
                }
            }

            ///품목 에 대한 유효성 검사
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
                    MessageBox.Show("장소를 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("입고수량"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("입고 수량을 입력해주세요.");
                    e.Cancel = true;
                }

                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;

                }

            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("검사자"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("검사자를 선택해주세요.");
                    e.Cancel = true;
                }
            }

           
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                ///업체명 품목 장소 입고일, 검사일 입고수량 검사수량 합격수량 불량 수량 검사자.   

                Data.FirstInspection firstInspection = dgvList.Rows[0].DataBoundItem as Data.FirstInspection;
                if (firstInspection == null || string.IsNullOrWhiteSpace(firstInspection.OCompanyName)
                    || firstInspection.ItemId == null || firstInspection.WorkPlaceId == null || firstInspection.EnterQuantity == null || firstInspection.EmployeeId == null)
                {
                    MessageBox.Show("등록 할 수있는 내용이 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.FirstInspection firstInspection = dgvList.Rows[0].DataBoundItem as Data.FirstInspection;
                if (firstInspection == null || string.IsNullOrWhiteSpace(firstInspection.OCompanyName)
                    || firstInspection.ItemId == null || firstInspection.WorkPlaceId == null || firstInspection.EnterQuantity == null || firstInspection.EmployeeId == null)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                DB.FirstInspection.Insert(firstInspection);
            }
        }
    }
}
