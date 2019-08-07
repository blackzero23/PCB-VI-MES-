namespace PCBVI.Forms.Monitoring
{
    partial class CCTVURLForm
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
            this.lbDescription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbURL = new System.Windows.Forms.ComboBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = false;
            this.lbDescription.Location = new System.Drawing.Point(13, 13);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(393, 25);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Values.Text = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(247, 104);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 25);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Values.Text = "Cancle";
            // 
            // cbbURL
            // 
            this.cbbURL.FormattingEnabled = true;
            this.cbbURL.Location = new System.Drawing.Point(113, 45);
            this.cbbURL.Name = "cbbURL";
            this.cbbURL.Size = new System.Drawing.Size(224, 20);
            this.cbbURL.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kryptonButton1.Location = new System.Drawing.Point(113, 104);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "O K";
            this.kryptonButton1.Click += new System.EventHandler(this.KryptonButton1_Click);
            // 
            // CCTVURLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 155);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.cbbURL);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.lbDescription);
            this.Name = "CCTVURLForm";
            this.Text = "CCTVURLForm";
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancle;
        private System.Windows.Forms.ComboBox cbbURL;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}