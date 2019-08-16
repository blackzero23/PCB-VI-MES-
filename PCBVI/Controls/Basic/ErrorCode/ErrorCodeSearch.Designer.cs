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
            this.cbbErrorKind = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.errorKindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbErrorType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.errorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbErrorCode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.errorCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbErrorKind);
            this.kryptonPanel1.Controls.Add(this.cbbErrorType);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cbbErrorCode);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(703, 82);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbbErrorKind
            // 
            this.cbbErrorKind.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.errorKindBindingSource, "ErrorKindId", true));
            this.cbbErrorKind.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.errorKindBindingSource, "Name", true));
            this.cbbErrorKind.DataSource = this.errorKindBindingSource;
            this.cbbErrorKind.DisplayMember = "Name";
            this.cbbErrorKind.DropDownWidth = 121;
            this.cbbErrorKind.Location = new System.Drawing.Point(450, 34);
            this.cbbErrorKind.Name = "cbbErrorKind";
            this.cbbErrorKind.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorKind.TabIndex = 24;
            this.cbbErrorKind.ValueMember = "Name";
            // 
            // errorKindBindingSource
            // 
            this.errorKindBindingSource.DataSource = typeof(PCBVI.Data.ErrorKind);
            // 
            // cbbErrorType
            // 
            this.cbbErrorType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.errorTypeBindingSource, "ErrorTypeId", true));
            this.cbbErrorType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.errorTypeBindingSource, "Name", true));
            this.cbbErrorType.DataSource = this.errorTypeBindingSource;
            this.cbbErrorType.DisplayMember = "Name";
            this.cbbErrorType.DropDownWidth = 121;
            this.cbbErrorType.Location = new System.Drawing.Point(280, 35);
            this.cbbErrorType.Name = "cbbErrorType";
            this.cbbErrorType.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorType.TabIndex = 23;
            this.cbbErrorType.ValueMember = "Name";
            // 
            // errorTypeBindingSource
            // 
            this.errorTypeBindingSource.DataSource = typeof(PCBVI.Data.ErrorType);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(211, 35);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.TabIndex = 22;
            this.kryptonLabel3.Values.Text = "불량유형명";
            // 
            // cbbErrorCode
            // 
            this.cbbErrorCode.DataSource = this.errorCodeBindingSource;
            this.cbbErrorCode.DisplayMember = "Code";
            this.cbbErrorCode.DropDownWidth = 121;
            this.cbbErrorCode.Location = new System.Drawing.Point(87, 35);
            this.cbbErrorCode.Name = "cbbErrorCode";
            this.cbbErrorCode.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorCode.TabIndex = 21;
            this.cbbErrorCode.TabStop = false;
            this.cbbErrorCode.ValueMember = "Code";
            // 
            // errorCodeBindingSource
            // 
            this.errorCodeBindingSource.DataSource = typeof(PCBVI.Data.ErrorCode);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(405, 35);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "불량군";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "불량코드";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(583, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ErrorCodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ErrorCodeSearch";
            this.Size = new System.Drawing.Size(703, 82);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorKind;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource errorCodeBindingSource;
        private System.Windows.Forms.BindingSource errorTypeBindingSource;
        private System.Windows.Forms.BindingSource errorKindBindingSource;
    }
}
