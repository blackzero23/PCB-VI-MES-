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
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbLOTNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbbLotNo = new System.Windows.Forms.ComboBox();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(729, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lbLOTNo
            // 
            this.lbLOTNo.Location = new System.Drawing.Point(32, 27);
            this.lbLOTNo.Name = "lbLOTNo";
            this.lbLOTNo.Size = new System.Drawing.Size(58, 20);
            this.lbLOTNo.TabIndex = 3;
            this.lbLOTNo.Values.Text = "LOT No :";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbLotNo);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.lbLOTNo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(854, 75);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 5;
            // 
            // cbbLotNo
            // 
            this.cbbLotNo.DataSource = this.lotBindingSource;
            this.cbbLotNo.DisplayMember = "LotCode";
            this.cbbLotNo.FormattingEnabled = true;
            this.cbbLotNo.Location = new System.Drawing.Point(96, 27);
            this.cbbLotNo.Name = "cbbLotNo";
            this.cbbLotNo.Size = new System.Drawing.Size(121, 20);
            this.cbbLotNo.TabIndex = 5;
            this.cbbLotNo.ValueMember = "LotId";
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(PCBVI.Data.Lot);
            // 
            // barcodeBindingSource
            // 
            this.barcodeBindingSource.DataSource = typeof(PCBVI.Data.Barcode);
            // 
            // BarcodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "BarcodeSearch";
            this.Size = new System.Drawing.Size(854, 75);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbLOTNo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ComboBox cbbLotNo;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private System.Windows.Forms.BindingSource barcodeBindingSource;
    }
}
