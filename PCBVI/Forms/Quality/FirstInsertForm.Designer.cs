namespace PCBVI.Forms.Quality
{
    partial class FirstInsertForm
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
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.WorkPlaceId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.oCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.enterDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.checkDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.enterQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkQuantiyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.bdnFirstInspection = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFirstInspection)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oCompanyNameDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.WorkPlaceId,
            this.enterDateDataGridViewTextBoxColumn,
            this.checkDateDataGridViewTextBoxColumn,
            this.enterQuantityDataGridViewTextBoxColumn,
            this.checkQuantiyDataGridViewTextBoxColumn,
            this.passQuantityDataGridViewTextBoxColumn,
            this.errorQuantityDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdnFirstInspection;
            this.dgvList.Location = new System.Drawing.Point(27, 27);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(746, 325);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // WorkPlaceId
            // 
            this.WorkPlaceId.DataPropertyName = "WorkPlaceId";
            this.WorkPlaceId.DataSource = this.bdsWorkPlace;
            this.WorkPlaceId.DisplayMember = "Name";
            this.WorkPlaceId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.WorkPlaceId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WorkPlaceId.HeaderText = "장 소";
            this.WorkPlaceId.Name = "WorkPlaceId";
            this.WorkPlaceId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkPlaceId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WorkPlaceId.ValueMember = "WorkPlaceId";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancle);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 399);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 51);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(683, 14);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Values.Text = "취 소";
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(561, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // oCompanyNameDataGridViewTextBoxColumn
            // 
            this.oCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "OCompanyName";
            this.oCompanyNameDataGridViewTextBoxColumn.HeaderText = "업체명";
            this.oCompanyNameDataGridViewTextBoxColumn.Name = "oCompanyNameDataGridViewTextBoxColumn";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.bdsItem;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "품목";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "ItemId";
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.Checked = false;
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "입고일";
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            this.enterDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enterDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enterDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.Checked = false;
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "CheckDate";
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "검사일";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            this.checkDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkDateDataGridViewTextBoxColumn.Width = 71;
            // 
            // enterQuantityDataGridViewTextBoxColumn
            // 
            this.enterQuantityDataGridViewTextBoxColumn.DataPropertyName = "EnterQuantity";
            this.enterQuantityDataGridViewTextBoxColumn.HeaderText = "입고수량";
            this.enterQuantityDataGridViewTextBoxColumn.Name = "enterQuantityDataGridViewTextBoxColumn";
            // 
            // checkQuantiyDataGridViewTextBoxColumn
            // 
            this.checkQuantiyDataGridViewTextBoxColumn.DataPropertyName = "CheckQuantiy";
            this.checkQuantiyDataGridViewTextBoxColumn.HeaderText = "검사수량";
            this.checkQuantiyDataGridViewTextBoxColumn.Name = "checkQuantiyDataGridViewTextBoxColumn";
            // 
            // passQuantityDataGridViewTextBoxColumn
            // 
            this.passQuantityDataGridViewTextBoxColumn.DataPropertyName = "PassQuantity";
            this.passQuantityDataGridViewTextBoxColumn.HeaderText = "합격수량";
            this.passQuantityDataGridViewTextBoxColumn.Name = "passQuantityDataGridViewTextBoxColumn";
            // 
            // errorQuantityDataGridViewTextBoxColumn
            // 
            this.errorQuantityDataGridViewTextBoxColumn.DataPropertyName = "ErrorQuantity";
            this.errorQuantityDataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.errorQuantityDataGridViewTextBoxColumn.Name = "errorQuantityDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.DataSource = this.bdsEmployee;
            this.employeeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.employeeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.employeeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "검사자";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIdDataGridViewTextBoxColumn.ValueMember = "EmployeeId";
            // 
            // bdsEmployee
            // 
            this.bdsEmployee.DataSource = typeof(PCBVI.Data.Employee);
            // 
            // bdnFirstInspection
            // 
            this.bdnFirstInspection.DataSource = typeof(PCBVI.Data.FirstInspection);
            // 
            // FirstInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "FirstInsertForm";
            this.Text = "FirstInsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFirstInspection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private System.Windows.Forms.BindingSource bdnFirstInspection;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.BindingSource bdsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkPlaceId;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn enterDateDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkQuantiyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIdDataGridViewTextBoxColumn;
    }
}