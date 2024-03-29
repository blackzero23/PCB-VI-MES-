﻿namespace PCBVI.Controls.Facilities
{
    partial class FacilitiesPLC
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
            this.bdsFacilitiesPower = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFacilities = new System.Windows.Forms.BindingSource(this.components);
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.FacilitiesName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacilitiesName,
            this.ProcessName,
            this.WorkDate,
            this.workTimeDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsFacilitiesPower;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(613, 388);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvList_CellMouseClick);
            // 
            // bdsFacilitiesPower
            // 
            this.bdsFacilitiesPower.DataSource = typeof(PCBVI.Data.FacilitiesPower);
            // 
            // bdsFacilities
            // 
            this.bdsFacilities.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // FacilitiesName
            // 
            this.FacilitiesName.DataPropertyName = "FacilitiesId";
            this.FacilitiesName.DataSource = this.bdsFacilities;
            this.FacilitiesName.DisplayMember = "Name";
            this.FacilitiesName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.FacilitiesName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FacilitiesName.HeaderText = "설비명";
            this.FacilitiesName.Name = "FacilitiesName";
            this.FacilitiesName.ReadOnly = true;
            this.FacilitiesName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FacilitiesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FacilitiesName.ValueMember = "FacilitiesId";
            // 
            // ProcessName
            // 
            this.ProcessName.DataPropertyName = "ProcessId";
            this.ProcessName.DataSource = this.bdsProcess;
            this.ProcessName.DisplayMember = "Name";
            this.ProcessName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProcessName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProcessName.HeaderText = "공정명";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProcessName.ValueMember = "ProcessId";
            // 
            // WorkDate
            // 
            this.WorkDate.DataPropertyName = "WorkDate";
            this.WorkDate.HeaderText = "작업일";
            this.WorkDate.Name = "WorkDate";
            this.WorkDate.ReadOnly = true;
            // 
            // workTimeDataGridViewTextBoxColumn
            // 
            this.workTimeDataGridViewTextBoxColumn.DataPropertyName = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn.HeaderText = "작업시간";
            this.workTimeDataGridViewTextBoxColumn.Name = "workTimeDataGridViewTextBoxColumn";
            this.workTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FacilitiesPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "FacilitiesPLC";
            this.Size = new System.Drawing.Size(613, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilitiesPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsFacilitiesPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn FacilitiesName;
        private System.Windows.Forms.BindingSource bdsFacilities;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProcessName;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
    }
}
