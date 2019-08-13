namespace PCBVI.Controls.Facilities
{
    partial class FacilitiesPSC
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
            this.lbProcessName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbProcessName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbFacilitesName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker2);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.txbFacilitesName);
            this.kryptonPanel1.Controls.Add(this.txbProcessName);
            this.kryptonPanel1.Controls.Add(this.lbDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.lbProcessName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(674, 63);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbProcessName
            // 
            this.lbProcessName.Location = new System.Drawing.Point(19, 24);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(57, 20);
            this.lbProcessName.TabIndex = 0;
            this.lbProcessName.Values.Text = "공정 명 :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(151, 25);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "설비 명 :";
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(290, 25);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(69, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Values.Text = "작업 일시 :";
            // 
            // txbProcessName
            // 
            this.txbProcessName.Location = new System.Drawing.Point(79, 24);
            this.txbProcessName.Name = "txbProcessName";
            this.txbProcessName.Size = new System.Drawing.Size(53, 20);
            this.txbProcessName.TabIndex = 3;
            // 
            // txbFacilitesName
            // 
            this.txbFacilitesName.Location = new System.Drawing.Point(214, 25);
            this.txbFacilitesName.Name = "txbFacilitesName";
            this.txbFacilitesName.Size = new System.Drawing.Size(70, 20);
            this.txbFacilitesName.TabIndex = 4;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(365, 24);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(84, 21);
            this.kryptonDateTimePicker1.TabIndex = 5;
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(480, 24);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(80, 21);
            this.kryptonDateTimePicker2.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "검 색";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(455, 25);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // FacilitiesPSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FacilitiesPSC";
            this.Size = new System.Drawing.Size(674, 63);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbFacilitesName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbProcessName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProcessName;
    }
}
