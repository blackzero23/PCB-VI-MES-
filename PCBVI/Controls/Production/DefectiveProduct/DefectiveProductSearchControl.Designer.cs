namespace PCBVI.Controls.Production.DefectiveProduct
{
    partial class DefectiveProductSearchControl
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
            this.lbLot = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbProcess = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ProcessSearchLb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bdsLot = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLot
            // 
            this.lbLot.Location = new System.Drawing.Point(17, 26);
            this.lbLot.Name = "lbLot";
            this.lbLot.Size = new System.Drawing.Size(57, 20);
            this.lbLot.TabIndex = 0;
            this.lbLot.Values.Text = "LOT.No : ";
            // 
            // cbbProcess
            // 
            this.cbbProcess.DataSource = this.bdsLot;
            this.cbbProcess.DisplayMember = "LotCode";
            this.cbbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProcess.DropDownWidth = 121;
            this.cbbProcess.Location = new System.Drawing.Point(77, 26);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(121, 21);
            this.cbbProcess.TabIndex = 1;
            this.cbbProcess.ValueMember = "LotId";
            // 
            // ProcessSearchLb
            // 
            this.ProcessSearchLb.Location = new System.Drawing.Point(204, 26);
            this.ProcessSearchLb.Name = "ProcessSearchLb";
            this.ProcessSearchLb.Size = new System.Drawing.Size(69, 20);
            this.ProcessSearchLb.TabIndex = 0;
            this.ProcessSearchLb.Values.Text = "검색 일자 : ";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(279, 26);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(88, 21);
            this.dtpFromDate.TabIndex = 2;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(398, 26);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(89, 21);
            this.dtpToDate.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(373, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(695, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // bdsLot
            // 
            this.bdsLot.DataSource = typeof(PCBVI.Data.Lot);
            // 
            // DefectiveProductSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cbbProcess);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.ProcessSearchLb);
            this.Controls.Add(this.lbLot);
            this.Name = "DefectiveProductSearchControl";
            this.Size = new System.Drawing.Size(800, 75);
            ((System.ComponentModel.ISupportInitialize)(this.cbbProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbLot;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel ProcessSearchLb;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource bdsLot;
    }
}
