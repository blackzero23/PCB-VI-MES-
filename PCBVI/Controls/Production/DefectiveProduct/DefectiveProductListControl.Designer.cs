namespace PCBVI.Controls.Production.DefectiveProduct
{
    partial class DefectiveProductListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.lotIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsLot = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsBarcode = new System.Windows.Forms.BindingSource(this.components);
            this.errorCodeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsErrorCode = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDefectiveProduction = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDefectiveProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processIdDataGridViewTextBoxColumn,
            this.lotIdDataGridViewTextBoxColumn,
            this.barcodeIdDataGridViewTextBoxColumn,
            this.errorCodeIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.workDateDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsDefectiveProduction;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(800, 150);
            this.dgvList.TabIndex = 0;
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.DataSource = this.bdsProcess;
            this.processIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.processIdDataGridViewTextBoxColumn.HeaderText = "공정명";
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.processIdDataGridViewTextBoxColumn.ValueMember = "ProcessId";
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // lotIdDataGridViewTextBoxColumn
            // 
            this.lotIdDataGridViewTextBoxColumn.DataPropertyName = "LotId";
            this.lotIdDataGridViewTextBoxColumn.DataSource = this.bdsLot;
            this.lotIdDataGridViewTextBoxColumn.DisplayMember = "LotCode";
            this.lotIdDataGridViewTextBoxColumn.HeaderText = "LOT.No";
            this.lotIdDataGridViewTextBoxColumn.Name = "lotIdDataGridViewTextBoxColumn";
            this.lotIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lotIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lotIdDataGridViewTextBoxColumn.ValueMember = "LotId";
            // 
            // bdsLot
            // 
            this.bdsLot.DataSource = typeof(PCBVI.Data.Lot);
            // 
            // barcodeIdDataGridViewTextBoxColumn
            // 
            this.barcodeIdDataGridViewTextBoxColumn.DataPropertyName = "BarcodeId";
            this.barcodeIdDataGridViewTextBoxColumn.DataSource = this.bdsBarcode;
            this.barcodeIdDataGridViewTextBoxColumn.DisplayMember = "BarcodeCode";
            this.barcodeIdDataGridViewTextBoxColumn.HeaderText = "바코드명";
            this.barcodeIdDataGridViewTextBoxColumn.Name = "barcodeIdDataGridViewTextBoxColumn";
            this.barcodeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.barcodeIdDataGridViewTextBoxColumn.ValueMember = "BarcodeId";
            // 
            // bdsBarcode
            // 
            this.bdsBarcode.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // errorCodeIdDataGridViewTextBoxColumn
            // 
            this.errorCodeIdDataGridViewTextBoxColumn.DataPropertyName = "ErrorCodeId";
            this.errorCodeIdDataGridViewTextBoxColumn.DataSource = this.bdsErrorCode;
            this.errorCodeIdDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.errorCodeIdDataGridViewTextBoxColumn.HeaderText = "불량명";
            this.errorCodeIdDataGridViewTextBoxColumn.Name = "errorCodeIdDataGridViewTextBoxColumn";
            this.errorCodeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.errorCodeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.errorCodeIdDataGridViewTextBoxColumn.ValueMember = "ErrorCodeId";
            // 
            // bdsErrorCode
            // 
            this.bdsErrorCode.DataSource = typeof(PCBVI.Data.ErrorCode);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.DataSource = this.bdsEmployee;
            this.employeeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "직원명";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIdDataGridViewTextBoxColumn.ValueMember = "EmployeeId";
            // 
            // bdsEmployee
            // 
            this.bdsEmployee.DataSource = typeof(PCBVI.Data.Employee);
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "작업자";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            // 
            // bdsDefectiveProduction
            // 
            this.bdsDefectiveProduction.DataSource = typeof(PCBVI.Data.DefectiveProduct);
            // 
            // DefectiveProductListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "DefectiveProductListControl";
            this.Size = new System.Drawing.Size(800, 150);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDefectiveProduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsDefectiveProduction;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.DataGridViewComboBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lotIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsLot;
        private System.Windows.Forms.DataGridViewComboBoxColumn barcodeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsBarcode;
        private System.Windows.Forms.DataGridViewComboBoxColumn errorCodeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsErrorCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
    }
}
