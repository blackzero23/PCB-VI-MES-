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
    public partial class BarcodeInsertForm : KryptonForm
    {
        public BarcodeInsertForm()
        {
            InitializeComponent();
        }



        private void BarcodeInsertForm_Load(object sender, EventArgs e)
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsLot.DataSource = DB.Lot.GetAll();
        }






        //유효성 검사.
        private void KryptonDataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }


            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("LOT.No"))
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("LOT을 선택해주세요.");
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


            //바코드 에 대한 유효성 검사
            if (dgvList.Columns[e.ColumnIndex].HeaderText.Equals("코드"))
            {
                int barCode;
                //if (e.FormattedValue.ToString().Length > 3)
                if (!int.TryParse(e.FormattedValue.ToString(), out barCode))
                {

                    MessageBox.Show("숫자만 입력가능!");

                    e.Cancel = true;

                }

                //중복체크
                Barcode barcode = DB.BarCode.CheckBarcode(barCode);
                if (barcode != null)
                {
                    MessageBox.Show("중복된 코드 입니다.");
                    e.Cancel = true;
                }

            }


        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                Data.Barcode barcode = dgvList.Rows[0].DataBoundItem as Barcode;
                if (barcode == null || barcode.LotId == null || barcode.BarcodeCode == 0 || barcode.ItemId == null)
                {
                    MessageBox.Show("등록 할 수있는 바코드가 없습니다.");
                    return;
                }

            }

            foreach (DataGridViewRow dr in dgvList.Rows)
            {

                Data.Barcode barcode = dr.DataBoundItem as Barcode;

                if (barcode == null || barcode.LotId == null || barcode.BarcodeCode == 0 || barcode.ItemId == null)
                {
                    MessageBox.Show("등록완료!");
                    Close();
                    return;
                }

                DB.BarCode.Insert(barcode);
                LotBarCode lotBarCode = new LotBarCode();
                lotBarCode.LotId = barcode.LotId.GetValueOrDefault();

                barcode = DB.BarCode.CheckBarcode(barcode.BarcodeCode.GetValueOrDefault());
                
                lotBarCode.BarcodeId = barcode.BarcodeId;

                DB.LotBarCode.Insert(lotBarCode);
            }
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
