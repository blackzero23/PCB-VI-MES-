namespace PCBVI.Forms.Production
{
    partial class MaterialsManageInsertForm
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.materialsManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialStateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsManageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotIdDataGridViewTextBoxColumn,
            this.processIdDataGridViewTextBoxColumn,
            this.materialStateIdDataGridViewTextBoxColumn,
            this.passQuantityDataGridViewTextBoxColumn,
            this.errorQuantityDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.materialsManageBindingSource;
            this.dgvList.Location = new System.Drawing.Point(31, 28);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(727, 337);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 399);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 51);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(560, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(668, 14);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "취 소";
            this.kryptonButton1.Click += new System.EventHandler(this.KryptonButton1_Click);
            // 
            // materialsManageBindingSource
            // 
            this.materialsManageBindingSource.DataSource = typeof(PCBVI.Data.MaterialsManage);
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(PCBVI.Data.Lot);
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(PCBVI.Data.Process);
            // 
            // materialStateBindingSource
            // 
            this.materialStateBindingSource.DataSource = typeof(PCBVI.Data.MaterialState);
            // 
            // lotIdDataGridViewTextBoxColumn
            // 
            this.lotIdDataGridViewTextBoxColumn.DataPropertyName = "LotId";
            this.lotIdDataGridViewTextBoxColumn.DataSource = this.lotBindingSource;
            this.lotIdDataGridViewTextBoxColumn.DisplayMember = "LotCode";
            this.lotIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lotIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lotIdDataGridViewTextBoxColumn.HeaderText = "LOT.No";
            this.lotIdDataGridViewTextBoxColumn.Name = "lotIdDataGridViewTextBoxColumn";
            this.lotIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lotIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lotIdDataGridViewTextBoxColumn.ValueMember = "LotId";
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.DataSource = this.processBindingSource;
            this.processIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.processIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.processIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.processIdDataGridViewTextBoxColumn.HeaderText = "공 정";
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.processIdDataGridViewTextBoxColumn.ValueMember = "ProcessId";
            // 
            // materialStateIdDataGridViewTextBoxColumn
            // 
            this.materialStateIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialStateId";
            this.materialStateIdDataGridViewTextBoxColumn.DataSource = this.materialStateBindingSource;
            this.materialStateIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.materialStateIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialStateIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialStateIdDataGridViewTextBoxColumn.HeaderText = "상 태";
            this.materialStateIdDataGridViewTextBoxColumn.Name = "materialStateIdDataGridViewTextBoxColumn";
            this.materialStateIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialStateIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialStateIdDataGridViewTextBoxColumn.ValueMember = "MaterialStateId";
            // 
            // passQuantityDataGridViewTextBoxColumn
            // 
            this.passQuantityDataGridViewTextBoxColumn.DataPropertyName = "PassQuantity";
            this.passQuantityDataGridViewTextBoxColumn.HeaderText = "양품수량";
            this.passQuantityDataGridViewTextBoxColumn.Name = "passQuantityDataGridViewTextBoxColumn";
            // 
            // errorQuantityDataGridViewTextBoxColumn
            // 
            this.errorQuantityDataGridViewTextBoxColumn.DataPropertyName = "ErrorQuantity";
            this.errorQuantityDataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.errorQuantityDataGridViewTextBoxColumn.Name = "errorQuantityDataGridViewTextBoxColumn";
            // 
            // MaterialsManageInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "MaterialsManageInsertForm";
            this.Text = "MaterialsManageInsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsManageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.BindingSource materialsManageBindingSource;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.Windows.Forms.BindingSource materialStateBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn lotIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialStateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorQuantityDataGridViewTextBoxColumn;
    }
}