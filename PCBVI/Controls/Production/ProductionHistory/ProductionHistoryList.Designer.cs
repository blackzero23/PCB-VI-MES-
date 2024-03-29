﻿namespace PCBVI.Controls.Production.ProductionHistory
{
    partial class ProductionHistoryList
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
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsProductionHistory = new System.Windows.Forms.BindingSource(this.components);
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionDateDataGridViewTextBoxColumn,
            this.ProcessName,
            this.ItemName,
            this.passQuantityDataGridViewTextBoxColumn,
            this.errorQuantityDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsProductionHistory;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(808, 266);
            this.dgvList.TabIndex = 0;
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // bdsProductionHistory
            // 
            this.bdsProductionHistory.DataSource = typeof(PCBVI.Data.ProductionHistory);
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "생산일자";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProcessName
            // 
            this.ProcessName.DataPropertyName = "ProcessId";
            this.ProcessName.DataSource = this.bdsProcess;
            this.ProcessName.DisplayMember = "Name";
            this.ProcessName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProcessName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProcessName.HeaderText = "공정";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProcessName.ValueMember = "ProcessId";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemId";
            this.ItemName.DataSource = this.bdsItem;
            this.ItemName.DisplayMember = "Name";
            this.ItemName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ItemName.HeaderText = "품목명";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemName.ValueMember = "ItemId";
            // 
            // passQuantityDataGridViewTextBoxColumn
            // 
            this.passQuantityDataGridViewTextBoxColumn.DataPropertyName = "PassQuantity";
            this.passQuantityDataGridViewTextBoxColumn.HeaderText = "양품 수량";
            this.passQuantityDataGridViewTextBoxColumn.Name = "passQuantityDataGridViewTextBoxColumn";
            // 
            // errorQuantityDataGridViewTextBoxColumn
            // 
            this.errorQuantityDataGridViewTextBoxColumn.DataPropertyName = "ErrorQuantity";
            this.errorQuantityDataGridViewTextBoxColumn.HeaderText = "불량 수량";
            this.errorQuantityDataGridViewTextBoxColumn.Name = "errorQuantityDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "작업시작 시간";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "작업종료 시간";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductionHistoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "ProductionHistoryList";
            this.Size = new System.Drawing.Size(808, 266);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsProductionHistory;
        private System.Windows.Forms.BindingSource bdsProcess;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}
