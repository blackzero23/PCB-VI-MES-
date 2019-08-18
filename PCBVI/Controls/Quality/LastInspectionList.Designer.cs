namespace PCBVI.Controls.Quality
{
    partial class LastInspectionList
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
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLastInspection = new System.Windows.Forms.BindingSource(this.components);
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unCheckedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLastInspection)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionDateDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.oCompanyNameDataGridViewTextBoxColumn,
            this.unCheckedQuantityDataGridViewTextBoxColumn,
            this.checkedQuantityDataGridViewTextBoxColumn,
            this.passStateDataGridViewTextBoxColumn,
            this.passQuantityDataGridViewTextBoxColumn,
            this.failQuantityDataGridViewTextBoxColumn,
            this.finalQuantityDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsLastInspection;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1043, 466);
            this.dgvList.TabIndex = 0;
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // bdsLastInspection
            // 
            this.bdsLastInspection.DataSource = typeof(PCBVI.Data.LastInspection);
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "생산일";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.DataSource = this.bdsWorkPlace;
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.workPlaceIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "작업장";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            this.workPlaceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPlaceIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workPlaceIdDataGridViewTextBoxColumn.ValueMember = "WorkPlaceId";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.bdsItem;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "ItemId";
            // 
            // oCompanyNameDataGridViewTextBoxColumn
            // 
            this.oCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "OCompanyName";
            this.oCompanyNameDataGridViewTextBoxColumn.HeaderText = "업체명";
            this.oCompanyNameDataGridViewTextBoxColumn.Name = "oCompanyNameDataGridViewTextBoxColumn";
            // 
            // unCheckedQuantityDataGridViewTextBoxColumn
            // 
            this.unCheckedQuantityDataGridViewTextBoxColumn.DataPropertyName = "UnCheckedQuantity";
            this.unCheckedQuantityDataGridViewTextBoxColumn.HeaderText = "미검사량";
            this.unCheckedQuantityDataGridViewTextBoxColumn.Name = "unCheckedQuantityDataGridViewTextBoxColumn";
            // 
            // checkedQuantityDataGridViewTextBoxColumn
            // 
            this.checkedQuantityDataGridViewTextBoxColumn.DataPropertyName = "CheckedQuantity";
            this.checkedQuantityDataGridViewTextBoxColumn.HeaderText = "검사량";
            this.checkedQuantityDataGridViewTextBoxColumn.Name = "checkedQuantityDataGridViewTextBoxColumn";
            // 
            // passStateDataGridViewTextBoxColumn
            // 
            this.passStateDataGridViewTextBoxColumn.DataPropertyName = "PassState";
            this.passStateDataGridViewTextBoxColumn.HeaderText = "판정";
            this.passStateDataGridViewTextBoxColumn.Name = "passStateDataGridViewTextBoxColumn";
            // 
            // passQuantityDataGridViewTextBoxColumn
            // 
            this.passQuantityDataGridViewTextBoxColumn.DataPropertyName = "PassQuantity";
            this.passQuantityDataGridViewTextBoxColumn.HeaderText = "합격수량";
            this.passQuantityDataGridViewTextBoxColumn.Name = "passQuantityDataGridViewTextBoxColumn";
            // 
            // failQuantityDataGridViewTextBoxColumn
            // 
            this.failQuantityDataGridViewTextBoxColumn.DataPropertyName = "failQuantity";
            this.failQuantityDataGridViewTextBoxColumn.HeaderText = "불합격수량";
            this.failQuantityDataGridViewTextBoxColumn.Name = "failQuantityDataGridViewTextBoxColumn";
            // 
            // finalQuantityDataGridViewTextBoxColumn
            // 
            this.finalQuantityDataGridViewTextBoxColumn.DataPropertyName = "FinalQuantity";
            this.finalQuantityDataGridViewTextBoxColumn.HeaderText = "최종출하량";
            this.finalQuantityDataGridViewTextBoxColumn.Name = "finalQuantityDataGridViewTextBoxColumn";
            // 
            // LastInspectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "LastInspectionList";
            this.Size = new System.Drawing.Size(1043, 466);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLastInspection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.BindingSource bdsLastInspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unCheckedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalQuantityDataGridViewTextBoxColumn;
    }
}
