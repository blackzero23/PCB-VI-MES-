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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BarCodeNoTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BarCodeConfirmLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BarCodeConfirmTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.YesOrNotReWorkLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.YesOrNotReWorkChb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.WorkContentsLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.JobsDoneBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "바코드 No : ";
            // 
            // BarCodeNoTxb
            // 
            this.BarCodeNoTxb.Location = new System.Drawing.Point(92, 12);
            this.BarCodeNoTxb.Name = "BarCodeNoTxb";
            this.BarCodeNoTxb.Size = new System.Drawing.Size(100, 20);
            this.BarCodeNoTxb.TabIndex = 1;
            // 
            // BarCodeConfirmLb
            // 
            this.BarCodeConfirmLb.Location = new System.Drawing.Point(198, 12);
            this.BarCodeConfirmLb.Name = "BarCodeConfirmLb";
            this.BarCodeConfirmLb.Size = new System.Drawing.Size(82, 20);
            this.BarCodeConfirmLb.TabIndex = 0;
            this.BarCodeConfirmLb.Values.Text = "바코드 확인 : ";
            // 
            // BarCodeConfirmTxb
            // 
            this.BarCodeConfirmTxb.Location = new System.Drawing.Point(286, 12);
            this.BarCodeConfirmTxb.Name = "BarCodeConfirmTxb";
            this.BarCodeConfirmTxb.Size = new System.Drawing.Size(100, 20);
            this.BarCodeConfirmTxb.TabIndex = 1;
            // 
            // YesOrNotReWorkLb
            // 
            this.YesOrNotReWorkLb.Location = new System.Drawing.Point(12, 55);
            this.YesOrNotReWorkLb.Name = "YesOrNotReWorkLb";
            this.YesOrNotReWorkLb.Size = new System.Drawing.Size(82, 20);
            this.YesOrNotReWorkLb.TabIndex = 0;
            this.YesOrNotReWorkLb.Values.Text = "재작업 유무 : ";
            // 
            // YesOrNotReWorkChb
            // 
            this.YesOrNotReWorkChb.Location = new System.Drawing.Point(101, 56);
            this.YesOrNotReWorkChb.Name = "YesOrNotReWorkChb";
            this.YesOrNotReWorkChb.Size = new System.Drawing.Size(23, 20);
            this.YesOrNotReWorkChb.TabIndex = 2;
            this.YesOrNotReWorkChb.Values.Text = " ";
            // 
            // WorkContentsLb
            // 
            this.WorkContentsLb.Location = new System.Drawing.Point(12, 90);
            this.WorkContentsLb.Name = "WorkContentsLb";
            this.WorkContentsLb.Size = new System.Drawing.Size(69, 20);
            this.WorkContentsLb.TabIndex = 0;
            this.WorkContentsLb.Values.Text = "작업 내용 : ";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(24, 116);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(362, 186);
            this.kryptonRichTextBox1.TabIndex = 3;
            this.kryptonRichTextBox1.Text = "\n\n\n회장님께서 지시하신 사항(2018.01.01. 확인 작업에 대해서)을\n\'반드시\' 참조하여 작성하여 주시기 바랍니다.\n이사님이 지속적으로 검열" +
    "을 나오십니다.\n\n문의 : 경영지원팀 내선번호 012 담당자 최해송";
            // 
            // JobsDoneBtn
            // 
            this.JobsDoneBtn.Location = new System.Drawing.Point(296, 325);
            this.JobsDoneBtn.Name = "JobsDoneBtn";
            this.JobsDoneBtn.Size = new System.Drawing.Size(90, 25);
            this.JobsDoneBtn.TabIndex = 4;
            this.JobsDoneBtn.Values.Text = "작업 완료";
            // 
            // DefectiveProductPopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.JobsDoneBtn);
            this.Controls.Add(this.kryptonRichTextBox1);
            this.Controls.Add(this.YesOrNotReWorkChb);
            this.Controls.Add(this.BarCodeConfirmTxb);
            this.Controls.Add(this.BarCodeNoTxb);
            this.Controls.Add(this.BarCodeConfirmLb);
            this.Controls.Add(this.WorkContentsLb);
            this.Controls.Add(this.YesOrNotReWorkLb);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "DefectiveProductPopUpForm";
            this.Text = "DefectiveProductPopUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BarCodeNoTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel BarCodeConfirmLb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BarCodeConfirmTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel YesOrNotReWorkLb;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox YesOrNotReWorkChb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel WorkContentsLb;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton JobsDoneBtn;
    }
}