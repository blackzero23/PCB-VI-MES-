using PCBVI.Data;
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
    public partial class InspectionStandardInsertNew : Form
    {
        public InspectionStandardInsertNew()
        {
            InitializeComponent();
        }

        private void KryptonButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvInspection_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
              
                if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("검사유형명"))
                {
                int compareTest = 0;

                    if (e.FormattedValue.ToString().Length <= 0 || int.TryParse(e.FormattedValue.ToString(), out compareTest))
                    {
                        MessageBox.Show("검사유형명을 입력해주세요. 숫자는 당연히 안 되겠지?");
                        e.Cancel = true;
                    }
                }

                if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("코드"))
                {
                int compareTest = 0;
                    if (e.FormattedValue.ToString().Length <= 0 || int.TryParse
                   ( e.FormattedValue.ToString(), out compareTest))
                    {
                        MessageBox.Show("품목명을 입력해주세요. 숫자는 당연히 안 되겠지?");
                        e.Cancel = true;
                    }
                }

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {

                Data.InspectionStandardType inspectionStandardType = dgvList.Rows[0].DataBoundItem as InspectionStandardType;
                if (inspectionStandardType == null || inspectionStandardType.InspectionStandardTypeId == 0 || string.IsNullOrWhiteSpace(inspectionStandardType.Name) || string.IsNullOrWhiteSpace(inspectionStandardType.Code))
                {
                    MessageBox.Show("등록 할 수있는 검사유형이 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.InspectionStandardType inspectionStandardType = dr.DataBoundItem as InspectionStandardType;

                if (inspectionStandardType == null || inspectionStandardType.InspectionStandardTypeId == 0 || string.IsNullOrWhiteSpace(inspectionStandardType.Name) || string.IsNullOrWhiteSpace(inspectionStandardType.Code))
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


                DB.InspectionStandardType.Insert(inspectionStandardType);
                //StandardId랑 연결이 안 되있어서 검색은 안 되지만 올라가긴 올라감
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

        private void InspectionStandardInsertNew_Load(object sender, EventArgs e)
        {
            Test.DataSource = DB.InspectionStandard.GetAll();
        }
    }
    
}
