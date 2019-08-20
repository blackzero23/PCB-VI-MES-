namespace PCBVI.Forms.Basic
{
    partial class InspectionStandardInsertNew
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
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bdsType = new System.Windows.Forms.BindingSource(this.components);
            this.Test = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionStandardTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspectionStandards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(965, 402);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "신규 검사 기준 정보";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.btnCancle);
            this.kryptonPage1.Controls.Add(this.btnConfirm);
            this.kryptonPage1.Controls.Add(this.kryptonPanel1);
            this.kryptonPage1.Controls.Add(this.dgvList);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(963, 375);
            this.kryptonPage1.Text = "신규 검사 기준 정보";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "7604241ACAE542A5BCACBC17FCED9AA7";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(861, 342);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Values.Text = "취소";
            this.btnCancle.Click += new System.EventHandler(this.KryptonButton2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(765, 342);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 25);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Values.Text = "등록";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 335);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(963, 40);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspectionStandardTypeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.InspectionStandards});
            this.dgvList.DataSource = this.bdsType;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(963, 375);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvInspection_CellValidating);
            // 
            // bdsType
            // 
            this.bdsType.DataSource = typeof(PCBVI.Data.InspectionStandardType);
            // 
            // Test
            // 
            this.Test.DataSource = typeof(PCBVI.Data.InspectionStandard);
            // 
            // inspectionStandardTypeIdDataGridViewTextBoxColumn
            // 
            this.inspectionStandardTypeIdDataGridViewTextBoxColumn.DataPropertyName = "InspectionStandardTypeId";
            this.inspectionStandardTypeIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.inspectionStandardTypeIdDataGridViewTextBoxColumn.Name = "inspectionStandardTypeIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "검사유형명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "코드";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // InspectionStandards
            // 
            this.InspectionStandards.AutoComplete = false;
            this.InspectionStandards.DataPropertyName = "InspectionStandardsId";
            this.InspectionStandards.DataSource = this.Test;
            this.InspectionStandards.DisplayMember = "InspectionStandardId";
            this.InspectionStandards.HeaderText = "InspectionStandards";
            this.InspectionStandards.Name = "InspectionStandards";
            this.InspectionStandards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InspectionStandards.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InspectionStandards.ValueMember = "InspectionStandardId";
            // 
            // InspectionStandardInsertNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 402);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "InspectionStandardInsertNew";
            this.Text = "신규 검사 기준 정보";
            this.Load += new System.EventHandler(this.InspectionStandardInsertNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.BindingSource bdsType;
        private System.Windows.Forms.BindingSource Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionStandardTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InspectionStandards;
    }
}