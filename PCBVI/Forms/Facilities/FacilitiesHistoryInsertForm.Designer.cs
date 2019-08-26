namespace PCBVI.Forms.Facilities
{
    partial class FacilitiesHistoryInsertForm
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
            this.bdsFHistoryDivision = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFacilities = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFacilitiesHistory = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.workDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.facilitiesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fHistoryDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.historyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFHistoryDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workDateDataGridViewTextBoxColumn,
            this.facilitiesIdDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn,
            this.fHistoryDivisionIdDataGridViewTextBoxColumn,
            this.historyContentDataGridViewTextBoxColumn,
            this.oCompanyNameDataGridViewTextBoxColumn,
            this.oCompanyPhoneNumDataGridViewTextBoxColumn,
            this.oCompanyEmployeeDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsFacilitiesHistory;
            this.dgvList.Location = new System.Drawing.Point(25, 26);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(744, 318);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // bdsFHistoryDivision
            // 
            this.bdsFHistoryDivision.DataSource = typeof(PCBVI.Data.FHistoryDivision);
            // 
            // bdsFacilities
            // 
            this.bdsFacilities.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsFacilitiesHistory
            // 
            this.bdsFacilitiesHistory.DataSource = typeof(PCBVI.Data.FacilitiesHistory);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancle);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 402);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 48);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(679, 11);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Values.Text = "취 소";
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(550, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.Checked = false;
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "일 자";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workDateDataGridViewTextBoxColumn.Width = 88;
            // 
            // facilitiesIdDataGridViewTextBoxColumn
            // 
            this.facilitiesIdDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesId";
            this.facilitiesIdDataGridViewTextBoxColumn.DataSource = this.bdsFacilities;
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.facilitiesIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.facilitiesIdDataGridViewTextBoxColumn.HeaderText = "설 비";
            this.facilitiesIdDataGridViewTextBoxColumn.Name = "facilitiesIdDataGridViewTextBoxColumn";
            this.facilitiesIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facilitiesIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.facilitiesIdDataGridViewTextBoxColumn.ValueMember = "FacilitiesId";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.DataSource = this.bdsWorkPlace;
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.workPlaceIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "장 소";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            this.workPlaceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPlaceIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workPlaceIdDataGridViewTextBoxColumn.ValueMember = "WorkPlaceId";
            // 
            // fHistoryDivisionIdDataGridViewTextBoxColumn
            // 
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.DataPropertyName = "FHistoryDivisionId";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.DataSource = this.bdsFHistoryDivision;
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.HeaderText = "구 분";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.Name = "fHistoryDivisionIdDataGridViewTextBoxColumn";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.ValueMember = "FHistoryDivisionId";
            // 
            // historyContentDataGridViewTextBoxColumn
            // 
            this.historyContentDataGridViewTextBoxColumn.DataPropertyName = "HistoryContent";
            this.historyContentDataGridViewTextBoxColumn.HeaderText = "내 용";
            this.historyContentDataGridViewTextBoxColumn.Name = "historyContentDataGridViewTextBoxColumn";
            // 
            // oCompanyNameDataGridViewTextBoxColumn
            // 
            this.oCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "OCompanyName";
            this.oCompanyNameDataGridViewTextBoxColumn.HeaderText = "업 체";
            this.oCompanyNameDataGridViewTextBoxColumn.Name = "oCompanyNameDataGridViewTextBoxColumn";
            // 
            // oCompanyPhoneNumDataGridViewTextBoxColumn
            // 
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "OCompanyPhoneNum";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.HeaderText = "업체 번호";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.Name = "oCompanyPhoneNumDataGridViewTextBoxColumn";
            // 
            // oCompanyEmployeeDataGridViewTextBoxColumn
            // 
            this.oCompanyEmployeeDataGridViewTextBoxColumn.DataPropertyName = "OCompanyEmployee";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.HeaderText = "업체 직원";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.Name = "oCompanyEmployeeDataGridViewTextBoxColumn";
            // 
            // FacilitiesHistoryInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "FacilitiesHistoryInsertForm";
            this.Text = "FacilitiesHistoryInsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFHistoryDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private System.Windows.Forms.BindingSource bdsFacilitiesHistory;
        private System.Windows.Forms.BindingSource bdsFacilities;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsFHistoryDivision;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn facilitiesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fHistoryDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyEmployeeDataGridViewTextBoxColumn;
    }
}