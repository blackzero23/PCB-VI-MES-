namespace PCBVI.Forms.Basic
{
    partial class BarCodeInsertForm
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.barcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 350);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 100);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeCodeDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.barcodeBindingSource1;
            this.dgvList.Location = new System.Drawing.Point(51, 91);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(522, 180);
            this.dgvList.TabIndex = 1;
            // 
            // barcodeBindingSource
            // 
            this.barcodeBindingSource.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // barcodeCodeDataGridViewTextBoxColumn
            // 
            this.barcodeCodeDataGridViewTextBoxColumn.DataPropertyName = "BarcodeCode";
            this.barcodeCodeDataGridViewTextBoxColumn.HeaderText = "BarcodeCode";
            this.barcodeCodeDataGridViewTextBoxColumn.Name = "barcodeCodeDataGridViewTextBoxColumn";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // barcodeBindingSource1
            // 
            this.barcodeBindingSource1.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // BarCodeInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "BarCodeInsertForm";
            this.Text = "BarCodeInsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource barcodeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource barcodeBindingSource1;
    }
}