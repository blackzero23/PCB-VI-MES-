namespace PCBVI.Forms.Production
{
    partial class DefectiveProductPopUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReWorkChb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.JobsDone = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BarCodeConfirmTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BarCodeNoTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.WorkContentsTxb = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // ReWorkChb
            // 
            this.ReWorkChb.Location = new System.Drawing.Point(99, 62);
            this.ReWorkChb.Name = "ReWorkChb";
            this.ReWorkChb.Size = new System.Drawing.Size(23, 20);
            this.ReWorkChb.TabIndex = 12;
            this.ReWorkChb.Values.Text = " ";
            // 
            // JobsDone
            // 
            this.JobsDone.Location = new System.Drawing.Point(303, 305);
            this.JobsDone.Name = "JobsDone";
            this.JobsDone.Size = new System.Drawing.Size(90, 25);
            this.JobsDone.TabIndex = 11;
            this.JobsDone.Values.Text = "작업 완료";
            // 
            // BarCodeConfirmTxb
            // 
            this.BarCodeConfirmTxb.Location = new System.Drawing.Point(293, 22);
            this.BarCodeConfirmTxb.Name = "BarCodeConfirmTxb";
            this.BarCodeConfirmTxb.Size = new System.Drawing.Size(100, 20);
            this.BarCodeConfirmTxb.TabIndex = 9;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 96);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "작업 내용 : ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(205, 22);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "바코드 확인 : ";
            // 
            // BarCodeNoTxb
            // 
            this.BarCodeNoTxb.Location = new System.Drawing.Point(99, 22);
            this.BarCodeNoTxb.Name = "BarCodeNoTxb";
            this.BarCodeNoTxb.Size = new System.Drawing.Size(100, 20);
            this.BarCodeNoTxb.TabIndex = 10;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(19, 61);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "재작업 유무";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(19, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "바코드 No : ";
            // 
            // WorkContentsTxb
            // 
            this.WorkContentsTxb.Location = new System.Drawing.Point(44, 122);
            this.WorkContentsTxb.Name = "WorkContentsTxb";
            this.WorkContentsTxb.Size = new System.Drawing.Size(349, 151);
            this.WorkContentsTxb.TabIndex = 13;
            this.WorkContentsTxb.Text = "";
            // 
            // DefectiveProductPopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 342);
            this.Controls.Add(this.WorkContentsTxb);
            this.Controls.Add(this.ReWorkChb);
            this.Controls.Add(this.JobsDone);
            this.Controls.Add(this.BarCodeConfirmTxb);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.BarCodeNoTxb);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "DefectiveProductPopUpForm";
            this.Text = "DefectiveProductPopUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ReWorkChb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton JobsDone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BarCodeConfirmTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BarCodeNoTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox WorkContentsTxb;
    }
}