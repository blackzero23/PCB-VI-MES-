namespace PCBVI.Controls.SubjectControl
{
    partial class SubjectGrid
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
            this.SubjectGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectGridView
            // 
            this.SubjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectGridView.Location = new System.Drawing.Point(0, 0);
            this.SubjectGridView.Name = "SubjectGridView";
            this.SubjectGridView.RowTemplate.Height = 23;
            this.SubjectGridView.Size = new System.Drawing.Size(800, 150);
            this.SubjectGridView.TabIndex = 0;
            // 
            // SubjectGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubjectGridView);
            this.Name = "SubjectGrid";
            this.Size = new System.Drawing.Size(800, 150);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView SubjectGridView;
    }
}
