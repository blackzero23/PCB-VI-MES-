namespace PCBVI.Forms.Basic
{
    partial class FacilitiesInsertForm
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
            this.facilitiesNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdnFacility = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFacility)).BeginInit();
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
            this.facilitiesNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.processIdDataGridViewTextBoxColumn,
            this.inspectionStateDataGridViewCheckBoxColumn,
            this.useStateDataGridViewCheckBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdnFacility;
            this.dgvList.Location = new System.Drawing.Point(41, 29);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(736, 310);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvList_CellValidating);
            // 
            // facilitiesNoDataGridViewTextBoxColumn
            // 
            this.facilitiesNoDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesNo";
            this.facilitiesNoDataGridViewTextBoxColumn.HeaderText = "설비 번호";
            this.facilitiesNoDataGridViewTextBoxColumn.Name = "facilitiesNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "설비명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.DataSource = this.bdsProcess;
            this.processIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.processIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.processIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.processIdDataGridViewTextBoxColumn.HeaderText = "공정구분";
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.processIdDataGridViewTextBoxColumn.ValueMember = "ProcessId";
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // inspectionStateDataGridViewCheckBoxColumn
            // 
            this.inspectionStateDataGridViewCheckBoxColumn.DataPropertyName = "InspectionState";
            this.inspectionStateDataGridViewCheckBoxColumn.HeaderText = "검사 여부";
            this.inspectionStateDataGridViewCheckBoxColumn.Name = "inspectionStateDataGridViewCheckBoxColumn";
            // 
            // useStateDataGridViewCheckBoxColumn
            // 
            this.useStateDataGridViewCheckBoxColumn.DataPropertyName = "UseState";
            this.useStateDataGridViewCheckBoxColumn.HeaderText = "사용여부";
            this.useStateDataGridViewCheckBoxColumn.Name = "useStateDataGridViewCheckBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "폭";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "높이";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "길이";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "부피";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "무게";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // bdnFacility
            // 
            this.bdnFacility.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancle);
            this.kryptonPanel1.Controls.Add(this.btnInsert);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 401);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 49);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(660, 12);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Values.Text = "취 소";
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(549, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Values.Text = "등 록";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FacilitiesInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "FacilitiesInsertForm";
            this.Text = "FacilitiesInsertForm";
            this.Load += new System.EventHandler(this.FacilitiesInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdnFacility;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitiesNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inspectionStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    }
}