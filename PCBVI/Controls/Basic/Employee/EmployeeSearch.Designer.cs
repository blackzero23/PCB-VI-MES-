namespace PCBVI.Controls.Basic.Employee
{
    partial class EmployeeSearch
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbDepartment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbDepartment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.txbName);
            this.kryptonPanel1.Controls.Add(this.cbbDepartment);
            this.kryptonPanel1.Controls.Add(this.lbName);
            this.kryptonPanel1.Controls.Add(this.lbDepartment);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonPanel1.Size = new System.Drawing.Size(703, 75);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(581, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(337, 27);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 3;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DataSource = this.departmentBindingSource;
            this.cbbDepartment.DisplayMember = "Name";
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.DropDownWidth = 121;
            this.cbbDepartment.Location = new System.Drawing.Point(102, 27);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbbDepartment.TabIndex = 2;
            this.cbbDepartment.ValueMember = "DepartmentId";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(PCBVI.Data.Department);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(277, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Values.Text = "사원명 :";
            // 
            // lbDepartment
            // 
            this.lbDepartment.Location = new System.Drawing.Point(51, 27);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(45, 20);
            this.lbDepartment.TabIndex = 0;
            this.lbDepartment.Values.Text = "부 서 :";
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "EmployeeSearch";
            this.Size = new System.Drawing.Size(703, 75);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}
