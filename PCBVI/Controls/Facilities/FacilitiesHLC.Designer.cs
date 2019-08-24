namespace PCBVI.Controls.Facilities
{
    partial class FacilitiesHLC
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bdsFacilities = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFHistoryDivision = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFacilitiesHistory = new System.Windows.Forms.BindingSource(this.components);
            this.workDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.facilitiesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fHistoryDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.historyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFHistoryDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
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
            this.oCompanyEmployeeDataGridViewTextBoxColumn,
            this.oCompanyPhoneNumDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsFacilitiesHistory;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(832, 495);
            this.dgvList.TabIndex = 0;
            // 
            // bdsFacilities
            // 
            this.bdsFacilities.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsFHistoryDivision
            // 
            this.bdsFHistoryDivision.DataSource = typeof(PCBVI.Data.FHistoryDivision);
            // 
            // bdsFacilitiesHistory
            // 
            this.bdsFacilitiesHistory.DataSource = typeof(PCBVI.Data.FacilitiesHistory);
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.Checked = false;
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "일 자";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workDateDataGridViewTextBoxColumn.Width = 99;
            // 
            // facilitiesIdDataGridViewTextBoxColumn
            // 
            this.facilitiesIdDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesId";
            this.facilitiesIdDataGridViewTextBoxColumn.DataSource = this.bdsFacilities;
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.facilitiesIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.facilitiesIdDataGridViewTextBoxColumn.HeaderText = "설비명";
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
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "설치 장소";
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
            this.oCompanyNameDataGridViewTextBoxColumn.HeaderText = "담당 업체";
            this.oCompanyNameDataGridViewTextBoxColumn.Name = "oCompanyNameDataGridViewTextBoxColumn";
            // 
            // oCompanyEmployeeDataGridViewTextBoxColumn
            // 
            this.oCompanyEmployeeDataGridViewTextBoxColumn.DataPropertyName = "OCompanyEmployee";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.HeaderText = "담당자 이름";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.Name = "oCompanyEmployeeDataGridViewTextBoxColumn";
            // 
            // oCompanyPhoneNumDataGridViewTextBoxColumn
            // 
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "OCompanyPhoneNum";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.HeaderText = "담당자 번호";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.Name = "oCompanyPhoneNumDataGridViewTextBoxColumn";
            // 
            // FacilitiesHLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvList);
            this.Name = "FacilitiesHLC";
            this.Size = new System.Drawing.Size(832, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFHistoryDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsFacilities;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsFHistoryDivision;
        private System.Windows.Forms.BindingSource bdsFacilitiesHistory;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn facilitiesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fHistoryDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyPhoneNumDataGridViewTextBoxColumn;
    }
}
