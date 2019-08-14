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

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            OnInsertButtonClicked();
        }

        //입력 신규 폼 열기.
        public void OpenInsertForm(Form form)
        {
            form.ShowDialog();
        }

        public void UpdateAll<T>(List<T> entities) where T : class
        {
            var wType = entities.GetType();
            using (var context = new PCBVIEntities())
            {
                foreach (var entity in entities)
                {
                    context.Entry(entity).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
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
