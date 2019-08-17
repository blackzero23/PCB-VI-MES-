namespace PCBVI.Controls.Basic.SubjectControl
{
    partial class SubjectSearch
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
            this.components = new System.ComponentModel.Container();
            this.SubjectName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SubjectCodeTxb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbSecondDivision = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsSecondDivision = new System.Windows.Forms.BindingSource(this.components);
            this.cbbFirstDivision = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsFirstDivision = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSecondDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecondDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFirstDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirstDivision)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(-256, 29);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(100, 20);
            this.SubjectName.TabIndex = 13;
            // 
            // SubjectCodeTxb
            // 
            this.SubjectCodeTxb.Location = new System.Drawing.Point(-256, 3);
            this.SubjectCodeTxb.Name = "SubjectCodeTxb";
            this.SubjectCodeTxb.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodeTxb.TabIndex = 14;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(-150, 29);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel6.TabIndex = 6;
            this.kryptonLabel6.Values.Text = "품목분류 : ";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(-322, 29);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "품 목 명  : ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(-150, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "품목구분 : ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(-322, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "품목코드 : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(694, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Values.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbbSecondDivision
            // 
            this.cbbSecondDivision.DataSource = this.bdsSecondDivision;
            this.cbbSecondDivision.DisplayMember = "Name";
            this.cbbSecondDivision.DropDownWidth = 121;
            this.cbbSecondDivision.Location = new System.Drawing.Point(472, 28);
            this.cbbSecondDivision.Name = "cbbSecondDivision";
            this.cbbSecondDivision.Size = new System.Drawing.Size(121, 21);
            this.cbbSecondDivision.TabIndex = 27;
            this.cbbSecondDivision.ValueMember = "SecondItemDivisionId";
            // 
            // bdsSecondDivision
            // 
            this.bdsSecondDivision.DataSource = typeof(PCBVI.Data.SecondItemDivision);
            // 
            // cbbFirstDivision
            // 
            this.cbbFirstDivision.DataSource = this.bdsFirstDivision;
            this.cbbFirstDivision.DisplayMember = "Name";
            this.cbbFirstDivision.DropDownWidth = 121;
            this.cbbFirstDivision.Location = new System.Drawing.Point(273, 28);
            this.cbbFirstDivision.Name = "cbbFirstDivision";
            this.cbbFirstDivision.Size = new System.Drawing.Size(121, 21);
            this.cbbFirstDivision.TabIndex = 28;
            this.cbbFirstDivision.ValueMember = "FirstItemDivisionId";
            // 
            // bdsFirstDivision
            // 
            this.bdsFirstDivision.DataSource = typeof(PCBVI.Data.FirstItemDivision);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(400, 29);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "품목분류 : ";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(22, 28);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "품 목 명  : ";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(201, 28);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel10.TabIndex = 20;
            this.kryptonLabel10.Values.Text = "품목구분 : ";
            // 
            // SubjectSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbSecondDivision);
            this.Controls.Add(this.cbbFirstDivision);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.SubjectCodeTxb);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "SubjectSearch";
            this.Size = new System.Drawing.Size(800, 75);
            ((System.ComponentModel.ISupportInitialize)(this.cbbSecondDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecondDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFirstDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirstDivision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SubjectName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SubjectCodeTxb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbSecondDivision;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbFirstDivision;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private System.Windows.Forms.BindingSource bdsFirstDivision;
        private System.Windows.Forms.BindingSource bdsSecondDivision;
    }
}
