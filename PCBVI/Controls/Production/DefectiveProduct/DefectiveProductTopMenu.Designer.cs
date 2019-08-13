namespace PCBVI.Controls.Production.DefectiveProduct
{
    partial class DefectiveProductTopMenu
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
            this.ProcesseCkb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.ProcessTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SearchDateCkb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SearchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // ProcesseCkb
            // 
            this.ProcesseCkb.Location = new System.Drawing.Point(24, 25);
            this.ProcesseCkb.Name = "ProcesseCkb";
            this.ProcesseCkb.Size = new System.Drawing.Size(67, 20);
            this.ProcesseCkb.TabIndex = 0;
            this.ProcesseCkb.Values.Text = "공정명 : ";
            // 
            // ProcessTxb
            // 
            this.ProcessTxb.Location = new System.Drawing.Point(97, 25);
            this.ProcessTxb.Name = "ProcessTxb";
            this.ProcessTxb.Size = new System.Drawing.Size(100, 20);
            this.ProcessTxb.TabIndex = 1;
            // 
            // SearchDateCkb
            // 
            this.SearchDateCkb.Location = new System.Drawing.Point(216, 25);
            this.SearchDateCkb.Name = "SearchDateCkb";
            this.SearchDateCkb.Size = new System.Drawing.Size(82, 20);
            this.SearchDateCkb.TabIndex = 2;
            this.SearchDateCkb.Values.Text = "검색 일자 : ";
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(304, 25);
            this.FromDate.Name = "FromDate";
            this.FromDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.FromDate.Size = new System.Drawing.Size(88, 21);
            this.FromDate.TabIndex = 3;
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(423, 26);
            this.ToDate.Name = "ToDate";
            this.ToDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.ToDate.Size = new System.Drawing.Size(86, 21);
            this.ToDate.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(398, 26);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "~";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(692, 26);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 25);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Values.Text = "조회";
            // 
            // DefectiveProductTopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.SearchDateCkb);
            this.Controls.Add(this.ProcessTxb);
            this.Controls.Add(this.ProcesseCkb);
            this.Name = "DefectiveProductTopMenu";
            this.Size = new System.Drawing.Size(800, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ProcesseCkb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ProcessTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox SearchDateCkb;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SearchBtn;
    }
}
