namespace PCBVI.Controls.Materials
{
    partial class MaterialsHLC
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
            this.bdsMaterialHistory = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLot = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBarcode = new System.Windows.Forms.BindingSource(this.components);
            this.lotIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.barcodeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMaterialHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotIdDataGridViewTextBoxColumn,
            this.barcodeIdDataGridViewTextBoxColumn,
            this.materialStateDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn,
            this.enterQuantityDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsMaterialHistory;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(630, 305);
            this.dgvList.TabIndex = 0;
            // 
            // bdsMaterialHistory
            // 
            this.bdsMaterialHistory.DataSource = typeof(PCBVI.Data.MaterialHistory);
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsLot
            // 
            this.bdsLot.DataSource = typeof(PCBVI.Data.Lot);
            // 
            // bdsBarcode
            // 
            this.bdsBarcode.DataSource = typeof(PCBVI.Data.Barcode);
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
            // materialStateDataGridViewTextBoxColumn
            // 
            this.materialStateDataGridViewTextBoxColumn.DataPropertyName = "MaterialState";
            this.materialStateDataGridViewTextBoxColumn.HeaderText = "입.출고";
            this.materialStateDataGridViewTextBoxColumn.Name = "materialStateDataGridViewTextBoxColumn";
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "입고일";
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            // 
            // enterQuantityDataGridViewTextBoxColumn
            // 
            this.enterQuantityDataGridViewTextBoxColumn.DataPropertyName = "EnterQuantity";
            this.enterQuantityDataGridViewTextBoxColumn.HeaderText = "입고 수량";
            this.enterQuantityDataGridViewTextBoxColumn.Name = "enterQuantityDataGridViewTextBoxColumn";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.DataSource = this.bdsWorkPlace;
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "현재 위치";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            this.workPlaceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPlaceIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workPlaceIdDataGridViewTextBoxColumn.ValueMember = "WorkPlaceId";
            // 
            // MaterialsHLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "MaterialsHLC";
            this.Size = new System.Drawing.Size(630, 305);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMaterialHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsMaterialHistory;
        private System.Windows.Forms.DataGridViewComboBoxColumn lotIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsLot;
        private System.Windows.Forms.DataGridViewComboBoxColumn barcodeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
    }
}
