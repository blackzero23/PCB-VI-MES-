namespace PCBVI.Controls.Basic.SubjectControl
{
    partial class SubjectGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SubjectGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.productBds = new System.Windows.Forms.BindingSource(this.components);
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baecodeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSubjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBds)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectGridView
            // 
            this.SubjectGridView.AutoGenerateColumns = false;
            this.SubjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.baecodeIdDataGridViewTextBoxColumn,
            this.productSubjectIdDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.DetailContents});
            this.SubjectGridView.DataSource = this.productBds;
            this.SubjectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectGridView.Location = new System.Drawing.Point(0, 0);
            this.SubjectGridView.Name = "SubjectGridView";
            this.SubjectGridView.RowTemplate.Height = 23;
            this.SubjectGridView.Size = new System.Drawing.Size(800, 150);
            this.SubjectGridView.TabIndex = 0;
            // 
            // productBds
            // 
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // baecodeIdDataGridViewTextBoxColumn
            // 
            this.baecodeIdDataGridViewTextBoxColumn.DataPropertyName = "BaecodeId";
            this.baecodeIdDataGridViewTextBoxColumn.HeaderText = "BaecodeId";
            this.baecodeIdDataGridViewTextBoxColumn.Name = "baecodeIdDataGridViewTextBoxColumn";
            // 
            // productSubjectIdDataGridViewTextBoxColumn
            // 
            this.productSubjectIdDataGridViewTextBoxColumn.DataPropertyName = "ProductSubjectId";
            this.productSubjectIdDataGridViewTextBoxColumn.HeaderText = "ProductSubjectId";
            this.productSubjectIdDataGridViewTextBoxColumn.Name = "productSubjectIdDataGridViewTextBoxColumn";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // DetailContents
            // 
            this.DetailContents.DataPropertyName = "DetailContents";
            this.DetailContents.HeaderText = "DetailContents";
            this.DetailContents.Name = "DetailContents";
            // 
            // SubjectGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubjectGridView);
            this.Name = "SubjectGrid";
            this.Size = new System.Drawing.Size(800, 150);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView SubjectGridView;
        private System.Windows.Forms.BindingSource productBds;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baecodeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSubjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailContents;
    }
}
