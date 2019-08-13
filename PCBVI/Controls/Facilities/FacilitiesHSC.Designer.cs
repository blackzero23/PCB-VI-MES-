namespace PCBVI.Controls.Facilities
{
    partial class FacilitiesHSC
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
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProcess = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker2);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.lbProcess);
            this.kryptonPanel1.Controls.Add(this.lbDate);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(644, 68);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(30, 21);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(69, 20);
            this.lbDate.TabIndex = 0;
            this.lbDate.Values.Text = "생산 일자 :";
            // 
            // lbProcess
            // 
            this.lbProcess.Location = new System.Drawing.Point(324, 23);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(41, 20);
            this.lbProcess.TabIndex = 1;
            this.lbProcess.Values.Text = "공정 :";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(516, 23);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "검 색";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(371, 23);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBox1.TabIndex = 3;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(105, 21);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(87, 21);
            this.kryptonDateTimePicker1.TabIndex = 4;
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(226, 22);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(89, 21);
            this.kryptonDateTimePicker2.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(198, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = " ~";
            // 
            // FacilitiesHSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FacilitiesHSC";
            this.Size = new System.Drawing.Size(644, 68);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDate;
    }
}
