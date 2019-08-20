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
using PCBVI.Data;
using ComponentFactory.Krypton.Toolkit;

namespace PCBVI.Forms.Basic
{
    public partial class SubjectInsertNewForm : KryptonForm
    {
        public SubjectInsertNewForm()
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
           // bdsItem.DataSource =
           //     DB.Item.GetAll();
            bdsSecond.DataSource =
                DB.SecondItemDivision.GetAll();
            bdsPlace.DataSource =
                DB.WorkPlace.GetAll();

        }
        

        private void GrvItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // dgvList.Rows[e.RowIndex].ErrorText = "";


            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.
            //정체 아직 모름.

            
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            
            

            //최소한의 입력셀의 개수 체크 하기위한 변수.


            //if (!int.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger < 0)
            //{
            //    e.Cancel = true;
            //    dgvList.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            //}

            ////이름, 부서,코드, 사원, 입사일,퇴사일,등급,아이디,비번
            ///
            //이름 란 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("품목구분"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("품목구분을 선택해주세요.");
                    e.Cancel = true;
                }
            }

            
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("코드"))
            {
                if (e.FormattedValue.ToString().Length <= 0)
                {
                    MessageBox.Show("코드를 입력해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("품목명"))
            {
                if (e.FormattedValue.ToString().Length <= 0)
                {
                    MessageBox.Show("품목명을 입력해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("품목분류"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("품목분류를 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("수량"))
            {
                int newInteger = 9876;
                //if (e.FormattedValue.ToString().Length > 3)
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger <= 0)
                {


                    MessageBox.Show("숫자만 입력가능합니다");
                    // 유효성 검사에서 실패시 취소시킴

                    e.Cancel = true;

                    // dgvList.Rows[e.RowIndex].ErrorText = "사원이름은 3자리까지 입력가능합니다";

                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("위치정보"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("위치정보를 선택해주세요.");
                    e.Cancel = true;
                }
            }


        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {

                Data.Item item = dgvList.Rows[0].DataBoundItem as Item;
                if (item == null || item.FirstItemDivisionId == 0 || string.IsNullOrWhiteSpace(item.Code) || string.IsNullOrWhiteSpace(item.Name) || item.SecondItemDivisionId == 0 ||
                    item.Quantity <= 0 || item.WorkPlaceId == 0 )
                {
                    MessageBox.Show("등록 할 수있는 회원이 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.Item item = dr.DataBoundItem as Item;

                if (item == null || item.FirstItemDivisionId == 0 || string.IsNullOrWhiteSpace(item.Code) || string.IsNullOrWhiteSpace(item.Name) || item.SecondItemDivisionId == 0 ||
                   item.Quantity <= 0 || item.WorkPlaceId == 0)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                // MessageBox.Show("Test");
                ////이름, 부서,코드, 사원, 입사일,퇴사일,등급,아이디,비번
                //employee.Name = dr.Cells[0].Value.ToString();               
                //employee.DepartmentId = (int)dr.Cells[1].;
                //employee.Code = dr.Cells[2].Value.ToString();
                //employee.EmploymentDate = (DateTime)dr.Cells[3].Value;
                //employee.DepartureDate = (DateTime)dr.Cells[4].Value;
                //employee.Grade = (int)dr.Cells[5].Value;
                //employee.LoginId = dr.Cells[6].Value.ToString();
                //employee.Password = dr.Cells[7].Value.ToString();

                ////employee =  as Employee;


                DB.Item.Insert(item);
            }

            //var list = (from row in dgvList.Rows.Cast<DataGridViewRow>()
            //            from cell in row.Cells.Cast<DataGridViewCell>()
            //            select new
            //            {
            //                Employee = row//project into your new class from the row and cell vars.
            //            }).ToList();
            //MessageBox.Show($"{ dgvList.RowCount}");


            //List<Data.Employee> employees = dgvList.DataSource as List<Data.Employee>;

            MessageBox.Show("입력 완료");
        }

    }
    
}
