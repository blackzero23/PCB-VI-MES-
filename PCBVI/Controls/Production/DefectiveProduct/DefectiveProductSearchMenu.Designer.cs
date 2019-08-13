namespace PCBVI.Controls.Production.DefectiveProduct
{
    partial class DefectiveProductSearchMenu
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
            this.ProcessLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ProcessCbb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ProcessSearchLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.InquireBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessCbb)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessLb
            // 
            this.ProcessLb.Location = new System.Drawing.Point(17, 26);
            this.ProcessLb.Name = "ProcessLb";
            this.ProcessLb.Size = new System.Drawing.Size(54, 20);
            this.ProcessLb.TabIndex = 0;
            this.ProcessLb.Values.Text = "공정명 : ";
            // 
            // ProcessCbb
            // 
            this.ProcessCbb.DropDownWidth = 121;
            this.ProcessCbb.Location = new System.Drawing.Point(77, 26);
            this.ProcessCbb.Name = "ProcessCbb";
            this.ProcessCbb.Size = new System.Drawing.Size(121, 21);
            this.ProcessCbb.TabIndex = 1;
            // 
            // ProcessSearchLb
            // 
            this.ProcessSearchLb.Location = new System.Drawing.Point(204, 26);
            this.ProcessSearchLb.Name = "ProcessSearchLb";
            this.ProcessSearchLb.Size = new System.Drawing.Size(69, 20);
            this.ProcessSearchLb.TabIndex = 0;
            this.ProcessSearchLb.Values.Text = "검색 일자 : ";
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(279, 26);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(88, 21);
            this.FromDate.TabIndex = 2;
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(398, 26);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(89, 21);
            this.ToDate.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(373, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // InquireBtn
            // 
            this.InquireBtn.Location = new System.Drawing.Point(561, 26);
            this.InquireBtn.Name = "InquireBtn";
            this.InquireBtn.Size = new System.Drawing.Size(90, 25);
            this.InquireBtn.TabIndex = 4;
            this.InquireBtn.Values.Text = "조회";
            // 
            // DefectiveProductSearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InquireBtn);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ProcessCbb);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.ProcessSearchLb);
            this.Controls.Add(this.ProcessLb);
            this.Name = "DefectiveProductSearchMenu";
            this.Size = new System.Drawing.Size(800, 75);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessCbb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel ProcessLb;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ProcessCbb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel ProcessSearchLb;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InquireBtn;
    }
}
