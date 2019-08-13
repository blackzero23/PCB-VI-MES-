namespace PCBVI.Controls.Quality
{
    partial class FirstInspectionSearch
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
            this.lbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbEnterDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbProductName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProductName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cbbProductName);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker2);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.txbCompanyName);
            this.kryptonPanel1.Controls.Add(this.lbEnterDate);
            this.kryptonPanel1.Controls.Add(this.lbProductName);
            this.kryptonPanel1.Controls.Add(this.lbCompanyName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(732, 60);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Location = new System.Drawing.Point(15, 23);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(54, 20);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Values.Text = "업체명 :";
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(181, 23);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(45, 20);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Values.Text = "품 명 :";
            // 
            // lbEnterDate
            // 
            this.lbEnterDate.Location = new System.Drawing.Point(343, 23);
            this.lbEnterDate.Name = "lbEnterDate";
            this.lbEnterDate.Size = new System.Drawing.Size(69, 20);
            this.lbEnterDate.TabIndex = 2;
            this.lbEnterDate.Values.Text = "입고 날짜 :";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(75, 23);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txbCompanyName.TabIndex = 4;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(418, 22);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(78, 21);
            this.kryptonDateTimePicker1.TabIndex = 5;
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(527, 23);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(81, 21);
            this.kryptonDateTimePicker2.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(624, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "검 색";
            // 
            // cbbProductName
            // 
            this.cbbProductName.DropDownWidth = 105;
            this.cbbProductName.Location = new System.Drawing.Point(232, 22);
            this.cbbProductName.Name = "cbbProductName";
            this.cbbProductName.Size = new System.Drawing.Size(105, 21);
            this.cbbProductName.TabIndex = 8;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(502, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // FirstInspectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FirstInspectionSearch";
            this.Size = new System.Drawing.Size(732, 60);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProductName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEnterDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
