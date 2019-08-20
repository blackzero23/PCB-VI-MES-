using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data;
using PCBVI.Data.Data;

namespace PCBVI.Controls.CommonControl
{
    public partial class TopMenubar: UserControl  
    {
        public TopMenubar()
        {
            InitializeComponent();
        }
                
        //입력 신규 폼 열기.
        public void OpenInsertForm(Form form)
        {
            form.ShowDialog();
        }

        //변경사항 저장
        public void UpdateAll<T>(List<T> entities) where T : class
        {            //var wType = entities.GetType();
            using (var context = new PCBVIEntities())
            {
                foreach (var entity in entities)
                {                    
                    context.Entry(entity).State = EntityState.Modified;                    

                    context.SaveChanges();
                }
            }
        }

        public void Update<T>(T entity) where T : class
        {
            using (var context = new PCBVIEntities())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //변경사항 삭제
        public void DeleteAt<T>(T entity) where T : class
        {
            using(var context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// 엑셀 파일 저장 그리드뷰 객체, 파일이름, 파일 경로
        /// </summary>
        public void SaveExcelFile(DataGridView dgv, string fileName)
        {
            // creating Excel Application 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program 
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1. 
            // store its reference to worksheet 
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet 
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel 
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet 
            //변경사항 dgvList 의 로우수 -1 인것을 삭제
            //해당 셀값이 null경우의 조건을 추가.
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if(dgv.Rows[i].Cells[j].Value != null)
                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application 
            workbook.SaveAs($@"D:\{fileName}.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application 
            app.Quit();         
        }


        #region 각 버튼 Visible처리
        public void BtnInsert_FalseVisible()
        {
            btnInsert.Visible = false;
        }
        public void BtnUpdate_FalseVisible()
        {
            btnUpdate.Visible = false;
        }

        public void BtnDelete_FalseVisible()
        {
            btnDelete.Visible = false;
        }

        public void BtnExcel_FalseVisible()
        {
            btnExcel.Visible = false;
        }

        public void BtnExcel_OnlyShowVisible()
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnInsert.Visible = false;
        }
        #endregion

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            OnInsertButtonClicked();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClicked();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateButtonClicked();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            OnExcelButtonClicked();
        }

        #region InsertButtonClicked event things for C# 3.0
        public event EventHandler<InsertButtonClickedEventArgs> InsertButtonClicked;

        protected virtual void OnInsertButtonClicked(InsertButtonClickedEventArgs e)
        {
            if (InsertButtonClicked != null)
                InsertButtonClicked(this, e);
        }

        private InsertButtonClickedEventArgs OnInsertButtonClicked()
        {
            InsertButtonClickedEventArgs args = new InsertButtonClickedEventArgs();
            OnInsertButtonClicked(args);

            return args;
        }

        /*private InsertButtonClickedEventArgs OnInsertButtonClickedForOut()
        {
            InsertButtonClickedEventArgs args = new InsertButtonClickedEventArgs();
            OnInsertButtonClicked(args);

            return args;
        }*/

        public class InsertButtonClickedEventArgs : EventArgs
        {


            /*public InsertButtonClickedEventArgs()
            {
            }

            public InsertButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
        #region DeleteButtonClicked event things for C# 3.0
        public event EventHandler<DeleteButtonClickedEventArgs> DeleteButtonClicked;

        protected virtual void OnDeleteButtonClicked(DeleteButtonClickedEventArgs e)
        {
            if (DeleteButtonClicked != null)
                DeleteButtonClicked(this, e);
        }

        private DeleteButtonClickedEventArgs OnDeleteButtonClicked()
        {
            DeleteButtonClickedEventArgs args = new DeleteButtonClickedEventArgs();
            OnDeleteButtonClicked(args);

            return args;
        }

        /*private DeleteButtonClickedEventArgs OnDeleteButtonClickedForOut()
        {
            DeleteButtonClickedEventArgs args = new DeleteButtonClickedEventArgs();
            OnDeleteButtonClicked(args);

            return args;
        }*/

        public class DeleteButtonClickedEventArgs : EventArgs
        {


            /*public DeleteButtonClickedEventArgs()
            {
            }

            public DeleteButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
        #region ExcelButtonClicked event things for C# 3.0
        public event EventHandler<ExcelButtonClickedEventArgs> ExcelButtonClicked;

        protected virtual void OnExcelButtonClicked(ExcelButtonClickedEventArgs e)
        {
            if (ExcelButtonClicked != null)
                ExcelButtonClicked(this, e);
        }

        private ExcelButtonClickedEventArgs OnExcelButtonClicked()
        {
            ExcelButtonClickedEventArgs args = new ExcelButtonClickedEventArgs();
            OnExcelButtonClicked(args);

            return args;
        }

        /*private ExcelButtonClickedEventArgs OnExcelButtonClickedForOut()
        {
            ExcelButtonClickedEventArgs args = new ExcelButtonClickedEventArgs();
            OnExcelButtonClicked(args);

            return args;
        }*/

        public class ExcelButtonClickedEventArgs : EventArgs
        {


            /*public ExcelButtonClickedEventArgs()
            {
            }

            public ExcelButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
        #region UpdateButtonClicked event things for C# 3.0
        public event EventHandler<UpdateButtonClickedEventArgs> UpdateButtonClicked;

        protected virtual void OnUpdateButtonClicked(UpdateButtonClickedEventArgs e)
        {
            if (UpdateButtonClicked != null)
                UpdateButtonClicked(this, e);
        }

        private UpdateButtonClickedEventArgs OnUpdateButtonClicked()
        {
            UpdateButtonClickedEventArgs args = new UpdateButtonClickedEventArgs();
            OnUpdateButtonClicked(args);

            return args;
        }

        /*private UpdateButtonClickedEventArgs OnUpdateButtonClickedForOut()
        {
            UpdateButtonClickedEventArgs args = new UpdateButtonClickedEventArgs();
            OnUpdateButtonClicked(args);

            return args;
        }*/

        public class UpdateButtonClickedEventArgs : EventArgs
        {


            /*public UpdateButtonClickedEventArgs()
            {
            }

            public UpdateButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
    }
}
