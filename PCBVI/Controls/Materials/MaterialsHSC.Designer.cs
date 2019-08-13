namespace PCBVI.Controls.Materials
{
    partial class MaterialsHSC
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
            this.lbLOTNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lsBarcodeNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bntLOTNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbBarcodeNo = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.txbBarcodeNo);
            this.kryptonPanel1.Controls.Add(this.bntLOTNo);
            this.kryptonPanel1.Controls.Add(this.lsBarcodeNumber);
            this.kryptonPanel1.Controls.Add(this.lbLOTNumber);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(630, 56);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbLOTNumber
            // 
            this.lbLOTNumber.Location = new System.Drawing.Point(28, 16);
            this.lbLOTNumber.Name = "lbLOTNumber";
            this.lbLOTNumber.Size = new System.Drawing.Size(55, 20);
            this.lbLOTNumber.TabIndex = 0;
            this.lbLOTNumber.Values.Text = "LOT No:";
            // 
            // lsBarcodeNumber
            // 
            this.lsBarcodeNumber.Location = new System.Drawing.Point(247, 16);
            this.lsBarcodeNumber.Name = "lsBarcodeNumber";
            this.lsBarcodeNumber.Size = new System.Drawing.Size(66, 20);
            this.lsBarcodeNumber.TabIndex = 1;
            this.lsBarcodeNumber.Values.Text = "Serial No :";
            // 
            // bntLOTNo
            // 
            this.bntLOTNo.Location = new System.Drawing.Point(89, 16);
            this.bntLOTNo.Name = "bntLOTNo";
            this.bntLOTNo.Size = new System.Drawing.Size(100, 20);
            this.bntLOTNo.TabIndex = 2;
            // 
            // txbBarcodeNo
            // 
            this.txbBarcodeNo.Location = new System.Drawing.Point(319, 16);
            this.txbBarcodeNo.Name = "txbBarcodeNo";
            this.txbBarcodeNo.Size = new System.Drawing.Size(100, 20);
            this.txbBarcodeNo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(513, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Values.Text = "검 색";
            // 
            // MaterialsHSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MaterialsHSC";
            this.Size = new System.Drawing.Size(630, 56);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lsBarcodeNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbLOTNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txbBarcodeNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox bntLOTNo;
    }
}
