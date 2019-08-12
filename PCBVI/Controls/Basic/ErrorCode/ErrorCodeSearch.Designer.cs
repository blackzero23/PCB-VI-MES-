namespace PCBVI.Controls.Basic.ErrorCode
{
    partial class ErrorCodeSearch
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
            this.cbbInspectionStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbErrorKind = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbErrorTypeName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbErrorCode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errorCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbInspectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbInspectionStatus);
            this.kryptonPanel1.Controls.Add(this.cbbErrorKind);
            this.kryptonPanel1.Controls.Add(this.cbbErrorTypeName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cbbErrorCode);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(703, 98);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // cbbInspectionStatus
            // 
            this.cbbInspectionStatus.DropDownWidth = 121;
            this.cbbInspectionStatus.Location = new System.Drawing.Point(80, 56);
            this.cbbInspectionStatus.Name = "cbbInspectionStatus";
            this.cbbInspectionStatus.Size = new System.Drawing.Size(105, 21);
            this.cbbInspectionStatus.TabIndex = 18;
            // 
            // cbbErrorKind
            // 
            this.cbbErrorKind.DropDownWidth = 121;
            this.cbbErrorKind.Location = new System.Drawing.Point(443, 21);
            this.cbbErrorKind.Name = "cbbErrorKind";
            this.cbbErrorKind.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorKind.TabIndex = 17;
            // 
            // cbbErrorTypeName
            // 
            this.cbbErrorTypeName.DropDownWidth = 121;
            this.cbbErrorTypeName.Location = new System.Drawing.Point(273, 22);
            this.cbbErrorTypeName.Name = "cbbErrorTypeName";
            this.cbbErrorTypeName.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorTypeName.TabIndex = 16;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(23, 57);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "검사여부";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(204, 22);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "불량유형명";
            // 
            // cbbErrorCode
            // 
            this.cbbErrorCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.errorCodeBindingSource, "ErrorCodeId", true));
            this.cbbErrorCode.DataSource = this.errorCodeBindingSource;
            this.cbbErrorCode.DisplayMember = "Code";
            this.cbbErrorCode.DropDownWidth = 121;
            this.cbbErrorCode.Location = new System.Drawing.Point(80, 22);
            this.cbbErrorCode.Name = "cbbErrorCode";
            this.cbbErrorCode.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorCode.TabIndex = 11;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(398, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "불량군";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 22);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "불량코드";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(580, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Values.Text = "검 색";
            // 
            // errorCodeBindingSource
            // 
            this.errorCodeBindingSource.DataSource = typeof(PCBVI.Data.ErrorCode);
            // 
            // ErrorCodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ErrorCodeSearch";
            this.Size = new System.Drawing.Size(703, 98);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbInspectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbInspectionStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorKind;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorTypeName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorCode;
        private System.Windows.Forms.BindingSource errorCodeBindingSource;
    }
}
