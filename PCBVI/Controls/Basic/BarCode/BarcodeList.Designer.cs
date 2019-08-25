namespace PCBVI.Controls.Basic.BarCode
{
    partial class BarcodeList
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
            this.barcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspectionDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LotName,
            this.itemNameDataGridViewTextBoxColumn,
            this.barcodeCodeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.errorTypeNameDataGridViewTextBoxColumn,
            this.InspectionDate});
            this.dgvList.DataSource = this.barcodeBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(719, 482);
            this.dgvList.TabIndex = 0;
            // 
            // barcodeBindingSource
            // 
            this.barcodeBindingSource.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // LotName
            // 
            this.LotName.DataPropertyName = "LotName";
            this.LotName.HeaderText = "LOT.No";
            this.LotName.Name = "LotName";
            this.LotName.ReadOnly = true;
            this.LotName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "품목명";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcodeCodeDataGridViewTextBoxColumn
            // 
            this.barcodeCodeDataGridViewTextBoxColumn.DataPropertyName = "BarcodeCode";
            this.barcodeCodeDataGridViewTextBoxColumn.HeaderText = "바코드명";
            this.barcodeCodeDataGridViewTextBoxColumn.Name = "barcodeCodeDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "상태";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorTypeNameDataGridViewTextBoxColumn
            // 
            this.errorTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ErrorCodeId";
            this.errorTypeNameDataGridViewTextBoxColumn.HeaderText = "불량명";
            this.errorTypeNameDataGridViewTextBoxColumn.Name = "errorTypeNameDataGridViewTextBoxColumn";
            this.errorTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorTypeNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // InspectionDate
            // 
            this.InspectionDate.Checked = false;
            this.InspectionDate.DataPropertyName = "InspectionDate";
            this.InspectionDate.HeaderText = "검사 일자";
            this.InspectionDate.Name = "InspectionDate";
            this.InspectionDate.ReadOnly = true;
            this.InspectionDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InspectionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InspectionDate.Width = 113;
            // 
            // BarcodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "BarcodeList";
            this.Size = new System.Drawing.Size(719, 482);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource barcodeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTypeNameDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn InspectionDate;
    }
}
