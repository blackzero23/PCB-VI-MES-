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
    public partial class EmployeeInsertForm : KryptonForm
    {
        public EmployeeInsertForm()
        {
            InitializeComponent();
        }

        private void EmployeeInsertForm_Load(object sender, EventArgs e)
        {
            bdsDepartMent.DataSource = DB.Department.GetAll();
        }

        private void DgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int a = int.Parse((string)dgvList.Rows[e.RowIndex].Cells[0].Value);

            //for(e.ColumnIndex.)
            //if(a != 1)
            //    MessageBox.Show("1이 아니야~");

        }

        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("이름"))
            {
                if (e.FormattedValue.ToString().Length > 7)
                {
                    MessageBox.Show("7글자 이하로만 입력가능.");
                    e.Cancel = true;
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

            // 사원번호 에 대한 유효성 검사

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("사원번호"))
            {
                int newInteger;
                //if (e.FormattedValue.ToString().Length > 3)
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    // 유효성 검사에서 실패시 취소시킴

                    e.Cancel = true;

                    // dgvList.Rows[e.RowIndex].ErrorText = "사원이름은 3자리까지 입력가능합니다";

                }
            }
            // 등급에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("등 급"))
            {
                int newInteger;
                //if (e.FormattedValue.ToString().Length > 3)
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    

                    MessageBox.Show("숫자만 입력가능!");
                    // 유효성 검사에서 실패시 취소시킴

                    e.Cancel = true;

                    // dgvList.Rows[e.RowIndex].ErrorText = "사원이름은 3자리까지 입력가능합니다";

                }


                if (newInteger > 7)
                {
                    MessageBox.Show("등급 1~6 까지 설정 가능합니다.");
                    e.Cancel = true;
                }
            }

            //아이디 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("아이디"))
            {
                string id = e.FormattedValue.ToString();
                char[] charArr = id.ToCharArray();
                foreach (char c in charArr)
                {
                    if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                    {
                        MessageBox.Show("영어와 숫자만 입력해주세요");
                        e.Cancel = true;
                    }
                }

            }
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("비밀번호"))
            {
                if (e.FormattedValue.ToString().Length < 5)
                {
                    MessageBox.Show("5글자 이상 입력 해주세요.");
                    e.Cancel = true;
                }
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //List<Data.Employee> newEmployees = dgvList.DataSource as List<Data.Employee>;


            //DB.Employee.InsertALL(newEmployees);


            //List<Data.Employee> newEmployees = new List<Employee>();
            if(dgvList.Rows.Count>0)
            {
                Data.Employee employee = dgvList.Rows[0].DataBoundItem as Employee;
                if (employee == null || string.IsNullOrWhiteSpace(employee.Name) || employee.DepartmentId == 0 || string.IsNullOrWhiteSpace(employee.Code) || employee.Grade == 0 ||
                    string.IsNullOrWhiteSpace(employee.LoginId) || string.IsNullOrWhiteSpace(employee.Password))
                {
                    MessageBox.Show("등록 할 수있는 회원이 없습니다.");
                    return;
                }
                
            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.Employee employee = dr.DataBoundItem as Employee;               
                    
                if (employee == null || string.IsNullOrWhiteSpace(employee.Name) || employee.DepartmentId == 0 || string.IsNullOrWhiteSpace(employee.Code) || employee.Grade == 0 ||
                    string.IsNullOrWhiteSpace(employee.LoginId) || string.IsNullOrWhiteSpace(employee.Password))
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


                DB.Employee.Insert(employee);
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
