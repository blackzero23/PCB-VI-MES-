namespace PCBVI.Forms
{
    partial class MainForm
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
            this.mainMenulistControl1 = new PCBVI.Controls.MainControls.MainMenulistControl();
            this.SuspendLayout();
            // 
            // mainMenulistControl1
            // 
            this.mainMenulistControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenulistControl1.Location = new System.Drawing.Point(0, 0);
            this.mainMenulistControl1.Name = "mainMenulistControl1";
            this.mainMenulistControl1.Size = new System.Drawing.Size(175, 675);
            this.mainMenulistControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.mainMenulistControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MainControls.MainMenulistControl mainMenulistControl1;
    }
}