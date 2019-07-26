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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.ptbMin = new System.Windows.Forms.PictureBox();
            this.ptbMinimi = new System.Windows.Forms.PictureBox();
            this.ptbMax = new System.Windows.Forms.PictureBox();
            this.ptbCnacle = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mainMenulistControl1 = new PCBVI.Controls.MainControls.MainMenulistControl();
            this.panelMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCnacle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(175, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 642);
            this.panel2.TabIndex = 2;
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelMainTitle.Controls.Add(this.ptbMin);
            this.panelMainTitle.Controls.Add(this.ptbMinimi);
            this.panelMainTitle.Controls.Add(this.ptbMax);
            this.panelMainTitle.Controls.Add(this.ptbCnacle);
            this.panelMainTitle.Controls.Add(this.textBox1);
            this.panelMainTitle.Controls.Add(this.maskedTextBox1);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.ForeColor = System.Drawing.Color.White;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(800, 33);
            this.panelMainTitle.TabIndex = 1;
            this.panelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMainTitle_MouseDown);
            // 
            // ptbMin
            // 
            this.ptbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMin.Image = global::PCBVI.Properties.Resources.main_res;
            this.ptbMin.Location = new System.Drawing.Point(742, 5);
            this.ptbMin.Name = "ptbMin";
            this.ptbMin.Size = new System.Drawing.Size(20, 20);
            this.ptbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMin.TabIndex = 5;
            this.ptbMin.TabStop = false;
            this.ptbMin.Visible = false;
            this.ptbMin.Click += new System.EventHandler(this.PtbMin_Click);
            // 
            // ptbMinimi
            // 
            this.ptbMinimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimi.Image = global::PCBVI.Properties.Resources.main_minimazar;
            this.ptbMinimi.Location = new System.Drawing.Point(716, 5);
            this.ptbMinimi.Name = "ptbMinimi";
            this.ptbMinimi.Size = new System.Drawing.Size(20, 20);
            this.ptbMinimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimi.TabIndex = 4;
            this.ptbMinimi.TabStop = false;
            this.ptbMinimi.Click += new System.EventHandler(this.PtbMinimi_Click);
            // 
            // ptbMax
            // 
            this.ptbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMax.Image = global::PCBVI.Properties.Resources.main_maxi;
            this.ptbMax.Location = new System.Drawing.Point(742, 5);
            this.ptbMax.Name = "ptbMax";
            this.ptbMax.Size = new System.Drawing.Size(20, 20);
            this.ptbMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMax.TabIndex = 3;
            this.ptbMax.TabStop = false;
            this.ptbMax.Click += new System.EventHandler(this.PtbMax_Click);
            // 
            // ptbCnacle
            // 
            this.ptbCnacle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCnacle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCnacle.Image = global::PCBVI.Properties.Resources.main_cerrar;
            this.ptbCnacle.Location = new System.Drawing.Point(768, 5);
            this.ptbCnacle.Name = "ptbCnacle";
            this.ptbCnacle.Size = new System.Drawing.Size(20, 20);
            this.ptbCnacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCnacle.TabIndex = 1;
            this.ptbCnacle.TabStop = false;
            this.ptbCnacle.Click += new System.EventHandler(this.PtbCnacle_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("배달의민족 주아", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "PK Vision";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(610, 5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Text = "나중에 로그인 처리";
            // 
            // mainMenulistControl1
            // 
            this.mainMenulistControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenulistControl1.Location = new System.Drawing.Point(0, 33);
            this.mainMenulistControl1.Name = "mainMenulistControl1";
            this.mainMenulistControl1.Size = new System.Drawing.Size(175, 642);
            this.mainMenulistControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainMenulistControl1);
            this.Controls.Add(this.panelMainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCnacle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MainControls.MainMenulistControl mainMenulistControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.PictureBox ptbMin;
        private System.Windows.Forms.PictureBox ptbMinimi;
        private System.Windows.Forms.PictureBox ptbMax;
        private System.Windows.Forms.PictureBox ptbCnacle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}