namespace PCBVI.Controls.Production.Worker
{
    partial class WorkderTopMenu
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
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.WorkerWorkerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.WorkerEmployeeIDTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.WorkerSearchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(29, 30);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(67, 20);
            this.kryptonCheckBox1.TabIndex = 0;
            this.kryptonCheckBox1.Values.Text = "작업자 : ";
            // 
            // WorkerWorkerName
            // 
            this.WorkerWorkerName.Location = new System.Drawing.Point(102, 30);
            this.WorkerWorkerName.Name = "WorkerWorkerName";
            this.WorkerWorkerName.Size = new System.Drawing.Size(100, 20);
            this.WorkerWorkerName.TabIndex = 1;
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(238, 30);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(82, 20);
            this.kryptonCheckBox2.TabIndex = 0;
            this.kryptonCheckBox2.Values.Text = "사원 번호 : ";
            // 
            // WorkerEmployeeIDTxb
            // 
            this.WorkerEmployeeIDTxb.Location = new System.Drawing.Point(326, 30);
            this.WorkerEmployeeIDTxb.Name = "WorkerEmployeeIDTxb";
            this.WorkerEmployeeIDTxb.Size = new System.Drawing.Size(100, 20);
            this.WorkerEmployeeIDTxb.TabIndex = 1;
            // 
            // WorkerSearchBtn
            // 
            this.WorkerSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerSearchBtn.Location = new System.Drawing.Point(707, 25);
            this.WorkerSearchBtn.Name = "WorkerSearchBtn";
            this.WorkerSearchBtn.Size = new System.Drawing.Size(90, 25);
            this.WorkerSearchBtn.TabIndex = 2;
            this.WorkerSearchBtn.Values.Text = "검색";
            // 
            // WorkderTopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WorkerSearchBtn);
            this.Controls.Add(this.WorkerEmployeeIDTxb);
            this.Controls.Add(this.WorkerWorkerName);
            this.Controls.Add(this.kryptonCheckBox2);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Name = "WorkderTopMenu";
            this.Size = new System.Drawing.Size(800, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox WorkerWorkerName;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox WorkerEmployeeIDTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonButton WorkerSearchBtn;
    }
}
