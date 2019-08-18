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
            int newInteger;

            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }


            //if (!int.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger < 0)
            //{
            //    e.Cancel = true;
            //    dgvList.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            //}


            // col1 에 대한 유효성 검사
            
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("사원번호"))
            {


                //if (e.FormattedValue.ToString().Length > 3)
                if(!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    // 유효성 검사에서 실패시 취소시킴

                    e.Cancel = true;

                   // dgvList.Rows[e.RowIndex].ErrorText = "사원이름은 3자리까지 입력가능합니다";

                }



            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //List<Data.Employee> newEmployees = dgvList.DataSource as List<Data.Employee>;


            //DB.Employee.InsertALL(newEmployees);


            //List<Data.Employee> newEmployees = new List<Employee>();
            //foreach (DataGridViewRow dr in dgvList.Rows)
            //{
            //    Data.Employee employee = new Data.Employee();

            //   //employee =  as Employee;

            //    employee.Name = dgvList.Rows.cell

            //    DB.Employee.Insert(employee);
            //}

            //var list = (from row in dgvList.Rows.Cast<DataGridViewRow>()
            //    from cell in row.Cells.Cast<DataGridViewCell>()
            //    select new
            //    {
            //        Employee = row//project into your new class from the row and cell vars.
            //    }).ToList();


            List<Data.Employee> employees = dgvList.DataSource as List<Data.Employee>;

            MessageBox.Show("입력 완료");
        }

        
    }
}
