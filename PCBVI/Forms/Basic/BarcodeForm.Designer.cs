namespace PCBVI.Forms.Basic
{
    partial class BarcodeForm
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
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.barcodeSearch1 = new PCBVI.Controls.Basic.BarCode.BarcodeSearch();
            this.SuspendLayout();
            // 
            // topMenubar1
            // 
            this.topMenubar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenubar1.Location = new System.Drawing.Point(0, 0);
            this.topMenubar1.Name = "topMenubar1";
            this.topMenubar1.Size = new System.Drawing.Size(833, 35);
            this.topMenubar1.TabIndex = 0;
            // 
            // barcodeSearch1
            // 
            this.barcodeSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeSearch1.Location = new System.Drawing.Point(0, 35);
            this.barcodeSearch1.Name = "barcodeSearch1";
            this.barcodeSearch1.Size = new System.Drawing.Size(833, 68);
            this.barcodeSearch1.TabIndex = 1;
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.barcodeSearch1);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private Controls.Basic.BarCode.BarcodeSearch barcodeSearch1;
    }
}