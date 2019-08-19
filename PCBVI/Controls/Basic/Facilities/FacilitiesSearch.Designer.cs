namespace PCBVI.Controls.Basic.Facilities
{
    partial class FacilitiesSearch
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
            this.cbbProcess = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbFacilities = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.facilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbProcess);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cbbFacilities);
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
            // cbbProcess
            // 
            this.cbbProcess.DataSource = this.processBindingSource;
            this.cbbProcess.DisplayMember = "Name";
            this.cbbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProcess.DropDownWidth = 121;
            this.cbbProcess.Location = new System.Drawing.Point(268, 28);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(105, 21);
            this.cbbProcess.TabIndex = 26;
            this.cbbProcess.ValueMember = "ProcessId";
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(PCBVI.Data.Process);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(211, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "공정구분";
            // 
            // cbbFacilities
            // 
            this.cbbFacilities.DataSource = this.facilityBindingSource;
            this.cbbFacilities.DisplayMember = "Name";
            this.cbbFacilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFacilities.DropDownWidth = 121;
            this.cbbFacilities.Location = new System.Drawing.Point(78, 29);
            this.cbbFacilities.Name = "cbbFacilities";
            this.cbbFacilities.Size = new System.Drawing.Size(105, 21);
            this.cbbFacilities.TabIndex = 24;
            this.cbbFacilities.ValueMember = "FacilitiesId";
            // 
            // facilityBindingSource
            // 
            this.facilityBindingSource.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(35, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 23;
            this.kryptonLabel2.Values.Text = "설비명";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(584, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FacilitiesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FacilitiesSearch";
            this.Size = new System.Drawing.Size(703, 75);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbFacilities;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource facilityBindingSource;
        private System.Windows.Forms.BindingSource processBindingSource;
    }
}
