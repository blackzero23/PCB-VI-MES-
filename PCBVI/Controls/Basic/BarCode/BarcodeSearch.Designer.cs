namespace PCBVI.Controls.Basic.BarCode
{
    partial class BarcodeSearch
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
            this.txbLOTNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbProcess = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbLOTNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProcessName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbLOTNo
            // 
            this.txbLOTNo.Location = new System.Drawing.Point(114, 24);
            this.txbLOTNo.Name = "txbLOTNo";
            this.txbLOTNo.Size = new System.Drawing.Size(100, 23);
            this.txbLOTNo.TabIndex = 0;
            // 
            // cbbProcess
            // 
            this.cbbProcess.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.processBindingSource, "ProcessId", true));
            this.cbbProcess.DataSource = this.processBindingSource;
            this.cbbProcess.DisplayMember = "Name";
            this.cbbProcess.DropDownWidth = 121;
            this.cbbProcess.Location = new System.Drawing.Point(405, 24);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(121, 21);
            this.cbbProcess.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(722, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Values.Text = "검 색";
            // 
            // lbLOTNo
            // 
            this.lbLOTNo.Location = new System.Drawing.Point(50, 24);
            this.lbLOTNo.Name = "lbLOTNo";
            this.lbLOTNo.Size = new System.Drawing.Size(58, 20);
            this.lbLOTNo.TabIndex = 3;
            this.lbLOTNo.Values.Text = "LOT No :";
            // 
            // lbProcessName
            // 
            this.lbProcessName.Location = new System.Drawing.Point(345, 25);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(54, 20);
            this.lbProcessName.TabIndex = 4;
            this.lbProcessName.Values.Text = "공정명 :";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txbLOTNo);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.cbbProcess);
            this.kryptonPanel1.Controls.Add(this.lbProcessName);
            this.kryptonPanel1.Controls.Add(this.lbLOTNo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(854, 68);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(PCBVI.Data.Process);
            // 
            // BarcodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "BarcodeSearch";
            this.Size = new System.Drawing.Size(854, 68);
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbLOTNo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProcessName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbLOTNo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.BindingSource processBindingSource;
    }
}
