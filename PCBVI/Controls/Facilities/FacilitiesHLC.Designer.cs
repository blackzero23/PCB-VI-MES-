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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.facilitiesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facilitiesHistoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitiesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHistoryDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCompanyEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilitiesHistoryIdDataGridViewTextBoxColumn,
            this.workDateDataGridViewTextBoxColumn,
            this.facilitiesIdDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.fHistoryDivisionIdDataGridViewTextBoxColumn,
            this.historyContentDataGridViewTextBoxColumn,
            this.oCompanyNameDataGridViewTextBoxColumn,
            this.oCompanyPhoneNumDataGridViewTextBoxColumn,
            this.oCompanyEmployeeDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.facilitiesHistoryBindingSource;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(832, 495);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // facilitiesHistoryBindingSource
            // 
            this.facilitiesHistoryBindingSource.DataSource = typeof(PCBVI.Data.FacilitiesHistory);
            // 
            // facilitiesHistoryIdDataGridViewTextBoxColumn
            // 
            this.facilitiesHistoryIdDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesHistoryId";
            this.facilitiesHistoryIdDataGridViewTextBoxColumn.HeaderText = "FacilitiesHistoryId";
            this.facilitiesHistoryIdDataGridViewTextBoxColumn.Name = "facilitiesHistoryIdDataGridViewTextBoxColumn";
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            // 
            // facilitiesIdDataGridViewTextBoxColumn
            // 
            this.facilitiesIdDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesId";
            this.facilitiesIdDataGridViewTextBoxColumn.HeaderText = "FacilitiesId";
            this.facilitiesIdDataGridViewTextBoxColumn.Name = "facilitiesIdDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // fHistoryDivisionIdDataGridViewTextBoxColumn
            // 
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.DataPropertyName = "FHistoryDivisionId";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.HeaderText = "FHistoryDivisionId";
            this.fHistoryDivisionIdDataGridViewTextBoxColumn.Name = "fHistoryDivisionIdDataGridViewTextBoxColumn";
            // 
            // historyContentDataGridViewTextBoxColumn
            // 
            this.historyContentDataGridViewTextBoxColumn.DataPropertyName = "HistoryContent";
            this.historyContentDataGridViewTextBoxColumn.HeaderText = "HistoryContent";
            this.historyContentDataGridViewTextBoxColumn.Name = "historyContentDataGridViewTextBoxColumn";
            // 
            // oCompanyNameDataGridViewTextBoxColumn
            // 
            this.oCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "OCompanyName";
            this.oCompanyNameDataGridViewTextBoxColumn.HeaderText = "OCompanyName";
            this.oCompanyNameDataGridViewTextBoxColumn.Name = "oCompanyNameDataGridViewTextBoxColumn";
            // 
            // oCompanyPhoneNumDataGridViewTextBoxColumn
            // 
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "OCompanyPhoneNum";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.HeaderText = "OCompanyPhoneNum";
            this.oCompanyPhoneNumDataGridViewTextBoxColumn.Name = "oCompanyPhoneNumDataGridViewTextBoxColumn";
            // 
            // oCompanyEmployeeDataGridViewTextBoxColumn
            // 
            this.oCompanyEmployeeDataGridViewTextBoxColumn.DataPropertyName = "OCompanyEmployee";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.HeaderText = "OCompanyEmployee";
            this.oCompanyEmployeeDataGridViewTextBoxColumn.Name = "oCompanyEmployeeDataGridViewTextBoxColumn";
            // 
            // FacilitiesHLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "FacilitiesHLC";
            this.Size = new System.Drawing.Size(832, 495);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitiesHistoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitiesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHistoryDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facilitiesHistoryBindingSource;
    }
}
