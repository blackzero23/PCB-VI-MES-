namespace PCBVI.Forms.Basic
{
    partial class EmployeeInsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsDepartMent = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.departureDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsEmployee = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartMent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancle);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 345);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(965, 57);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(781, 11);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(130, 34);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Values.Text = "취 소";
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(603, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 34);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.loginIdDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsEmployee;
            this.dgvList.Location = new System.Drawing.Point(40, 92);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(847, 191);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.DataSource = this.bdsDepartMent;
            this.departmentIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.departmentIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.departmentIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "부서";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departmentIdDataGridViewTextBoxColumn.ValueMember = "DepartmentId";
            // 
            // bdsDepartMent
            // 
            this.bdsDepartMent.DataSource = typeof(PCBVI.Data.Department);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "사원번호";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.employmentDateDataGridViewTextBoxColumn.Checked = false;
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "입사일";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            this.employmentDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employmentDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employmentDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.departureDateDataGridViewTextBoxColumn.Checked = false;
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "퇴사일";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departureDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departureDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "등 급";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // loginIdDataGridViewTextBoxColumn
            // 
            this.loginIdDataGridViewTextBoxColumn.DataPropertyName = "LoginId";
            this.loginIdDataGridViewTextBoxColumn.HeaderText = "아이디";
            this.loginIdDataGridViewTextBoxColumn.Name = "loginIdDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "비밀번호";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // bdsEmployee
            // 
            this.bdsEmployee.DataSource = typeof(PCBVI.Data.Employee);
            // 
            // EmployeeInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 402);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "EmployeeInsertForm";
            this.Text = "EmployeeInsertForm";
            this.Load += new System.EventHandler(this.EmployeeInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartMent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private System.Windows.Forms.BindingSource bdsEmployee;
        private System.Windows.Forms.BindingSource bdsDepartMent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn employmentDateDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}