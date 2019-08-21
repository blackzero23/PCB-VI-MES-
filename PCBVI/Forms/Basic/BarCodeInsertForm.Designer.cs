namespace PCBVI.Forms.Basic
{
    partial class BarcodeInsertForm
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
            this.lotIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsLot = new System.Windows.Forms.BindingSource(this.components);
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsBarcode = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).BeginInit();
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
            this.lotIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.barcodeCodeDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsBarcode;
            this.dgvList.Location = new System.Drawing.Point(33, 31);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(727, 322);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.KryptonDataGridView1_CellValidating);
            // 
            // lotIdDataGridViewTextBoxColumn
            // 
            this.lotIdDataGridViewTextBoxColumn.DataPropertyName = "LotId";
            this.lotIdDataGridViewTextBoxColumn.DataSource = this.bdsLot;
            this.lotIdDataGridViewTextBoxColumn.DisplayMember = "LotCode";
            this.lotIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lotIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.bdsItem;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "품목";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "ItemId";
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // barcodeCodeDataGridViewTextBoxColumn
            // 
            this.barcodeCodeDataGridViewTextBoxColumn.DataPropertyName = "BarcodeCode";
            this.barcodeCodeDataGridViewTextBoxColumn.HeaderText = "코드";
            this.barcodeCodeDataGridViewTextBoxColumn.Name = "barcodeCodeDataGridViewTextBoxColumn";
            // 
            // bdsBarcode
            // 
            this.bdsBarcode.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancle);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 395);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 55);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(670, 18);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Values.Text = "취 소";
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(551, 18);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BarcodeInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "BarcodeInsertForm";
            this.Text = "BarcodeInsertForm";
            this.Load += new System.EventHandler(this.BarcodeInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsBarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn lotIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsLot;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCodeDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
    }
}