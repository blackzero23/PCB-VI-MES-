namespace PCBVI.Controls.Production.WorkOrder
{
    partial class WorkOrderListControl
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
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsRotationGroup = new System.Windows.Forms.BindingSource(this.components);
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkOrder = new System.Windows.Forms.BindingSource(this.components);
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rotationGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotationGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // bdsRotationGroup
            // 
            this.bdsRotationGroup.DataSource = typeof(PCBVI.Data.RotationGroup);
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsWorkOrder
            // 
            this.bdsWorkOrder.DataSource = typeof(PCBVI.Data.WorkOrder);
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.FillWeight = 99.75554F;
            this.noteDataGridViewTextBoxColumn.HeaderText = "비고";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.DataSource = this.bdsWorkPlace;
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.workPlaceIdDataGridViewTextBoxColumn.FillWeight = 99.75554F;
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "위치";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            this.workPlaceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPlaceIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workPlaceIdDataGridViewTextBoxColumn.ValueMember = "WorkPlaceId";
            // 
            // targetQuantityDataGridViewTextBoxColumn
            // 
            this.targetQuantityDataGridViewTextBoxColumn.DataPropertyName = "TargetQuantity";
            this.targetQuantityDataGridViewTextBoxColumn.FillWeight = 99.75554F;
            this.targetQuantityDataGridViewTextBoxColumn.HeaderText = "목표수량";
            this.targetQuantityDataGridViewTextBoxColumn.Name = "targetQuantityDataGridViewTextBoxColumn";
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.DataSource = this.bdsProcess;
            this.processIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.processIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.processIdDataGridViewTextBoxColumn.FillWeight = 99.75554F;
            this.processIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.processIdDataGridViewTextBoxColumn.HeaderText = "공정명";
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.processIdDataGridViewTextBoxColumn.ValueMember = "ProcessId";
            // 
            // rotationGroupIdDataGridViewTextBoxColumn
            // 
            this.rotationGroupIdDataGridViewTextBoxColumn.DataPropertyName = "RotationGroupId";
            this.rotationGroupIdDataGridViewTextBoxColumn.DataSource = this.bdsRotationGroup;
            this.rotationGroupIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.rotationGroupIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rotationGroupIdDataGridViewTextBoxColumn.FillWeight = 99.75554F;
            this.rotationGroupIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotationGroupIdDataGridViewTextBoxColumn.HeaderText = "근무조";
            this.rotationGroupIdDataGridViewTextBoxColumn.Name = "rotationGroupIdDataGridViewTextBoxColumn";
            this.rotationGroupIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rotationGroupIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rotationGroupIdDataGridViewTextBoxColumn.ValueMember = "RotationGroupId";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.Checked = false;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderDateDataGridViewTextBoxColumn.Width = 129;
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
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "ItemId";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.rotationGroupIdDataGridViewTextBoxColumn,
            this.processIdDataGridViewTextBoxColumn,
            this.targetQuantityDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsWorkOrder;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(946, 458);
            this.dgvList.TabIndex = 0;
            // 
            // WorkOrderListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "WorkOrderListControl";
            this.Size = new System.Drawing.Size(946, 458);
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotationGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.BindingSource bdsRotationGroup;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsWorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rotationGroupIdDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
    }
}
