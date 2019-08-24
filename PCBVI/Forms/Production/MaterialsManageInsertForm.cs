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

namespace PCBVI.Forms.Production
{
    public partial class MaterialsManageInsertForm : KryptonForm

    {
        public MaterialsManageInsertForm()
        {
            InitializeComponent();
        }

        private void KryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("LOT.No"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("LOT.No를 선택해주세요.");
                    e.Cancel = true;
                }
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("공 정"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("공정을 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("상 태"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("상태를 선택해주세요.");
                    e.Cancel = true;
                }
            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("양품수량"))
            {
                int newInteger;               
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;
                }

                if (e.FormattedValue.ToString().Length < 0)
                {
                    MessageBox.Show("양품수량 입력해주세요.");
                    e.Cancel = true;
                }

            }

            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("불량수량"))
            {
                int newInteger;
               
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
                {
                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;
                }

                if (e.FormattedValue.ToString().Length < 0)
                {
                    MessageBox.Show("불량수량 입력해주세요.");
                    e.Cancel = true;
                }
            }


            //투입수량 자동으로 저장 양품 , 불량 합?? 이 맞나.
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //

            if (dgvList.Rows.Count > 0)
            {
                Data.MaterialsManage materialsManage = dgvList.Rows[0].DataBoundItem as Data.MaterialsManage;

                if (materialsManage == null || materialsManage.LotId == null || materialsManage.MaterialStateId == null || materialsManage.ProcessId == null || materialsManage.PassQuantity == null ||
                     materialsManage.ErrorQuantity == null || materialsManage.TotalQuantity == null)
                {
                    MessageBox.Show("등록 할 수있는 자재 이력이 없습니다.");
                    return;
                }

            }
            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.MaterialsManage materialsManage = dr.DataBoundItem as Data.MaterialsManage;

                if (materialsManage == null || materialsManage.LotId == null || materialsManage.MaterialStateId == null || materialsManage.ProcessId == null || materialsManage.PassQuantity == null ||
                      materialsManage.ErrorQuantity == null || materialsManage.TotalQuantity == null)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                //투입수량 자동으로 저장 양품 , 불량 합?? 이 맞나.
                materialsManage.TotalQuantity = materialsManage.PassQuantity + materialsManage.ErrorQuantity;
                DB.MaterialsManage.Insert(materialsManage);
                
            }
        }
    }
}
