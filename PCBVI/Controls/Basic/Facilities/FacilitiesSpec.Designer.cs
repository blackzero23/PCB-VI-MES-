namespace PCBVI.Controls.Basic.Facilities
{
    partial class FacilitiesSpec
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
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txbWeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbLength = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbvolume = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbHeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbWidth = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbProcess = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txbNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bdsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.txbState = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbUseState = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(410, 322);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kryptonPanel1.TabIndex = 24;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txbUseState);
            this.kryptonPanel3.Controls.Add(this.txbState);
            this.kryptonPanel3.Controls.Add(this.txbName);
            this.kryptonPanel3.Controls.Add(this.txbNo);
            this.kryptonPanel3.Controls.Add(this.txbWeight);
            this.kryptonPanel3.Controls.Add(this.txbLength);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel3.Controls.Add(this.txbvolume);
            this.kryptonPanel3.Controls.Add(this.txbHeight);
            this.kryptonPanel3.Controls.Add(this.txbWidth);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel3.Controls.Add(this.cbbProcess);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(410, 322);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kryptonPanel3.TabIndex = 25;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(272, 193);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(78, 20);
            this.txbWeight.TabIndex = 22;
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(272, 167);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(78, 20);
            this.txbLength.TabIndex = 21;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(231, 193);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel11.TabIndex = 20;
            this.kryptonLabel11.Values.Text = "중량";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(231, 167);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel12.TabIndex = 19;
            this.kryptonLabel12.Values.Text = "길이";
            // 
            // txbvolume
            // 
            this.txbvolume.Location = new System.Drawing.Point(272, 219);
            this.txbvolume.Name = "txbvolume";
            this.txbvolume.Size = new System.Drawing.Size(78, 20);
            this.txbvolume.TabIndex = 18;
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(122, 219);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(78, 20);
            this.txbHeight.TabIndex = 17;
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(122, 193);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(78, 20);
            this.txbWidth.TabIndex = 16;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(206, 139);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel9.TabIndex = 12;
            this.kryptonLabel9.Values.Text = "사용여부";
            // 
            // cbbProcess
            // 
            this.cbbProcess.DataSource = this.bdsProcess;
            this.cbbProcess.DisplayMember = "Name";
            this.cbbProcess.DropDownWidth = 170;
            this.cbbProcess.Location = new System.Drawing.Point(122, 136);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(78, 21);
            this.cbbProcess.TabIndex = 10;
            this.cbbProcess.ValueMember = "ProcessId";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(231, 219);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel8.TabIndex = 7;
            this.kryptonLabel8.Values.Text = "부피";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(81, 219);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "높이";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(93, 193);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(23, 20);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "폭";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(56, 166);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "검사여부";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(56, 138);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "공정구분";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(68, 107);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "설비명";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(56, 77);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "설비번호";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "SPEC";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.AllowDrop = true;
            this.kryptonPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(410, 28);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPanel2.TabIndex = 25;
            // 
            // txbNo
            // 
            this.txbNo.Location = new System.Drawing.Point(122, 77);
            this.txbNo.Name = "txbNo";
            this.txbNo.Size = new System.Drawing.Size(228, 20);
            this.txbNo.TabIndex = 23;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(122, 107);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(228, 20);
            this.txbName.TabIndex = 24;
            // 
            // bdsProcess
            // 
            this.bdsProcess.DataSource = typeof(PCBVI.Data.Process);
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(122, 167);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(78, 20);
            this.txbState.TabIndex = 25;
            // 
            // txbUseState
            // 
            this.txbUseState.Location = new System.Drawing.Point(272, 137);
            this.txbUseState.Name = "txbUseState";
            this.txbUseState.Size = new System.Drawing.Size(78, 20);
            this.txbUseState.TabIndex = 26;
            // 
            // FacilitiesSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FacilitiesSpec";
            this.Size = new System.Drawing.Size(410, 322);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbLength;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbvolume;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbHeight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbWidth;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbNo;
        private System.Windows.Forms.BindingSource bdsProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbState;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbUseState;
    }
}
