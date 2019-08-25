namespace PCBVI.Controls.Production.WorkLog
{
    partial class WorkLogListControl
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
            this.rotationGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsRotationGroup = new System.Windows.Forms.BindingSource(this.components);
            this.facilitiesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsFacility = new System.Windows.Forms.BindingSource(this.components);
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.workDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.WorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsWorkLog = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotationGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rotationGroupIdDataGridViewTextBoxColumn,
            this.facilitiesIdDataGridViewTextBoxColumn,
            this.processIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.workDateDataGridViewTextBoxColumn,
            this.WorkerName,
            this.sartTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.productionQuantityDataGridViewTextBoxColumn,
            this.errorQuantityDataGridViewTextBoxColumn,
            this.targetQuantityDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsWorkLog;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(978, 574);
            this.dgvList.TabIndex = 0;
            // 
            // rotationGroupIdDataGridViewTextBoxColumn
            // 
            this.rotationGroupIdDataGridViewTextBoxColumn.DataPropertyName = "RotationGroupId";
            this.rotationGroupIdDataGridViewTextBoxColumn.DataSource = this.bdsRotationGroup;
            this.rotationGroupIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.rotationGroupIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rotationGroupIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotationGroupIdDataGridViewTextBoxColumn.HeaderText = "근무조";
            this.rotationGroupIdDataGridViewTextBoxColumn.Name = "rotationGroupIdDataGridViewTextBoxColumn";
            this.rotationGroupIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rotationGroupIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rotationGroupIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rotationGroupIdDataGridViewTextBoxColumn.ValueMember = "RotationGroupId";
            // 
            // bdsRotationGroup
            // 
            this.bdsRotationGroup.DataSource = typeof(PCBVI.Data.RotationGroup);
            // 
            // facilitiesIdDataGridViewTextBoxColumn
            // 
            this.facilitiesIdDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesId";
            this.facilitiesIdDataGridViewTextBoxColumn.DataSource = this.bdsFacility;
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.facilitiesIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.facilitiesIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.facilitiesIdDataGridViewTextBoxColumn.HeaderText = "설비명";
            this.facilitiesIdDataGridViewTextBoxColumn.Name = "facilitiesIdDataGridViewTextBoxColumn";
            this.facilitiesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilitiesIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facilitiesIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.facilitiesIdDataGridViewTextBoxColumn.ValueMember = "FacilitiesId";
            // 
            // bdsFacility
            // 
            this.bdsFacility.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.DataSource = this.bdsProcess;
            this.processIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.processIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.processIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.processIdDataGridViewTextBoxColumn.HeaderText = "공정명";
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.processIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.processIdDataGridViewTextBoxColumn.ValueMember = "ProcessId";
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.bdsItem;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "품목명";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "ItemId";
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.Checked = false;
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "작업일";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // WorkerName
            // 
            this.WorkerName.DataPropertyName = "WorkerName";
            this.WorkerName.HeaderText = "작업자";
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.ReadOnly = true;
            // 
            // sartTimeDataGridViewTextBoxColumn
            // 
            this.sartTimeDataGridViewTextBoxColumn.DataPropertyName = "SartTime";
            this.sartTimeDataGridViewTextBoxColumn.HeaderText = "시작시간";
            this.sartTimeDataGridViewTextBoxColumn.Name = "sartTimeDataGridViewTextBoxColumn";
            this.sartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "종료시간";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionQuantityDataGridViewTextBoxColumn
            // 
            this.productionQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductionQuantity";
            this.productionQuantityDataGridViewTextBoxColumn.HeaderText = "생산수량";
            this.productionQuantityDataGridViewTextBoxColumn.Name = "productionQuantityDataGridViewTextBoxColumn";
            this.productionQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorQuantityDataGridViewTextBoxColumn
            // 
            this.errorQuantityDataGridViewTextBoxColumn.DataPropertyName = "ErrorQuantity";
            this.errorQuantityDataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.errorQuantityDataGridViewTextBoxColumn.Name = "errorQuantityDataGridViewTextBoxColumn";
            this.errorQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetQuantityDataGridViewTextBoxColumn
            // 
            this.targetQuantityDataGridViewTextBoxColumn.DataPropertyName = "TargetQuantity";
            this.targetQuantityDataGridViewTextBoxColumn.HeaderText = "목표수량";
            this.targetQuantityDataGridViewTextBoxColumn.Name = "targetQuantityDataGridViewTextBoxColumn";
            this.targetQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsWorkLog
            // 
            this.bdsWorkLog.DataSource = typeof(PCBVI.Data.WorkLog);
            // 
            // WorkLogListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "WorkLogListControl";
            this.Size = new System.Drawing.Size(978, 574);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotationGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsWorkLog;
        private System.Windows.Forms.BindingSource bdsRotationGroup;
        private System.Windows.Forms.BindingSource bdsFacility;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn rotationGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn facilitiesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetQuantityDataGridViewTextBoxColumn;
    }
}
