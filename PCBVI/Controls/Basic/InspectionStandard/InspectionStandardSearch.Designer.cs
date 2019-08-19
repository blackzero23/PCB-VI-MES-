namespace PCBVI.Controls.Basic.InspectionStandard
{
    partial class InspectionStandardSearch
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
            this.cbbErrorCode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsInspectionStandarType = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandarType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbErrorCode);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(703, 75);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbbErrorCode
            // 
            this.cbbErrorCode.DataSource = this.bdsInspectionStandarType;
            this.cbbErrorCode.DisplayMember = "Code";
            this.cbbErrorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbErrorCode.DropDownWidth = 121;
            this.cbbErrorCode.Location = new System.Drawing.Point(85, 26);
            this.cbbErrorCode.Name = "cbbErrorCode";
            this.cbbErrorCode.Size = new System.Drawing.Size(105, 21);
            this.cbbErrorCode.TabIndex = 21;
            this.cbbErrorCode.ValueMember = "InspectionStandardTypeId";
            // 
            // bdsInspectionStandarType
            // 
            this.bdsInspectionStandarType.DataSource = typeof(PCBVI.Data.InspectionStandardType);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(28, 26);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "검사구분";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(583, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // InspectionStandardSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "InspectionStandardSearch";
            this.Size = new System.Drawing.Size(703, 75);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbErrorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandarType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbErrorCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource bdsInspectionStandarType;
    }
}
