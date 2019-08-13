namespace PCBVI.Controls.Production.ProcessDefect
{
    partial class ProcessDefectSearch
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.WorkProcessNameTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.SearchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 27);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "공정명 : ";
            // 
            // WorkProcessNameTxb
            // 
            this.WorkProcessNameTxb.Location = new System.Drawing.Point(77, 28);
            this.WorkProcessNameTxb.Name = "WorkProcessNameTxb";
            this.WorkProcessNameTxb.Size = new System.Drawing.Size(100, 20);
            this.WorkProcessNameTxb.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(183, 28);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "검색 일자 : ";
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(258, 28);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(88, 21);
            this.FromDate.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(352, 29);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "~";
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(377, 29);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(88, 21);
            this.ToDate.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(571, 27);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 25);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Values.Text = "조회";
            // 
            // ProcessDefectSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.WorkProcessNameTxb);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "ProcessDefectSearch";
            this.Size = new System.Drawing.Size(800, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox WorkProcessNameTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SearchBtn;
    }
}
