namespace PCBVI.Forms.Basic
{
    partial class ErrorcodeInsertForm
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
            this.errorCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bdsErrorType = new System.Windows.Forms.BindingSource(this.components);
            this.bdsErrorKind = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.errorKindIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorKind)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.errorTypeIdDataGridViewTextBoxColumn,
            this.errorKindIdDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.errorCodeBindingSource;
            this.dgvList.Location = new System.Drawing.Point(58, 46);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(696, 267);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // errorCodeBindingSource
            // 
            this.errorCodeBindingSource.DataSource = typeof(PCBVI.Data.ErrorCode);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 395);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 55);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(664, 18);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "취 소";
            this.kryptonButton2.Click += new System.EventHandler(this.KryptonButton2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(533, 18);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // bdsErrorType
            // 
            this.bdsErrorType.DataSource = typeof(PCBVI.Data.ErrorType);
            // 
            // bdsErrorKind
            // 
            this.bdsErrorKind.DataSource = typeof(PCBVI.Data.ErrorKind);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "에러코드";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // errorTypeIdDataGridViewTextBoxColumn
            // 
            this.errorTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ErrorTypeId";
            this.errorTypeIdDataGridViewTextBoxColumn.DataSource = this.bdsErrorType;
            this.errorTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.errorTypeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.errorTypeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorTypeIdDataGridViewTextBoxColumn.HeaderText = "에러유형";
            this.errorTypeIdDataGridViewTextBoxColumn.Name = "errorTypeIdDataGridViewTextBoxColumn";
            this.errorTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.errorTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.errorTypeIdDataGridViewTextBoxColumn.ValueMember = "ErrorTypeId";
            // 
            // errorKindIdDataGridViewTextBoxColumn
            // 
            this.errorKindIdDataGridViewTextBoxColumn.DataPropertyName = "ErrorKindId";
            this.errorKindIdDataGridViewTextBoxColumn.DataSource = this.bdsErrorKind;
            this.errorKindIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.errorKindIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.errorKindIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorKindIdDataGridViewTextBoxColumn.HeaderText = "에러군";
            this.errorKindIdDataGridViewTextBoxColumn.Name = "errorKindIdDataGridViewTextBoxColumn";
            this.errorKindIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.errorKindIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.errorKindIdDataGridViewTextBoxColumn.ValueMember = "ErrorKindId";
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "설명";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            // 
            // ErrorcodeInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "ErrorcodeInsertForm";
            this.Text = "ErrorcodeInsertForm";
            this.Load += new System.EventHandler(this.ErrorcodeInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsErrorKind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource errorCodeBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn errorTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsErrorType;
        private System.Windows.Forms.DataGridViewComboBoxColumn errorKindIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsErrorKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
    }
}