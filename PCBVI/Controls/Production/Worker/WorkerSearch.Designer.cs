namespace PCBVI.Controls.Production.Worker
{
    partial class WorkerSearch
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbDepartment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbDepartment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.texbEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbEmployeeNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.txbEmployeeNumber);
            this.kryptonPanel1.Controls.Add(this.texbEmployeeName);
            this.kryptonPanel1.Controls.Add(this.cbbDepartment);
            this.kryptonPanel1.Controls.Add(this.lbNumber);
            this.kryptonPanel1.Controls.Add(this.lbEmployee);
            this.kryptonPanel1.Controls.Add(this.lbDepartment);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(689, 71);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbDepartment
            // 
            this.lbDepartment.Location = new System.Drawing.Point(15, 27);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(54, 20);
            this.lbDepartment.TabIndex = 0;
            this.lbDepartment.Values.Text = "부서명 : ";
            // 
            // lbEmployee
            // 
            this.lbEmployee.Location = new System.Drawing.Point(215, 27);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(54, 20);
            this.lbEmployee.TabIndex = 1;
            this.lbEmployee.Values.Text = "작업자 : ";
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(381, 27);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(66, 20);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Values.Text = "사원번호 :";
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DropDownWidth = 121;
            this.cbbDepartment.Location = new System.Drawing.Point(75, 26);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbbDepartment.TabIndex = 3;
            // 
            // texbEmployeeName
            // 
            this.texbEmployeeName.Location = new System.Drawing.Point(275, 27);
            this.texbEmployeeName.Name = "texbEmployeeName";
            this.texbEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.texbEmployeeName.TabIndex = 4;
            // 
            // txbEmployeeNumber
            // 
            this.txbEmployeeNumber.Location = new System.Drawing.Point(453, 27);
            this.txbEmployeeNumber.Name = "txbEmployeeNumber";
            this.txbEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txbEmployeeNumber.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(582, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Values.Text = "검 색";
            // 
            // WorkerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "WorkerSearch";
            this.Size = new System.Drawing.Size(689, 71);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbEmployeeNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox texbEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
    }
}
