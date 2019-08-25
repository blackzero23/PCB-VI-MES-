namespace PCBVI.Controls.Quality
{
    partial class LastInspectionSearch
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProductCode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProductionDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txbWorker = new System.Windows.Forms.TextBox();
            this.cbbItemCode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.cbbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpProductionToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpProductionFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWorkPlace
            // 
            this.lbWorkPlace.Location = new System.Drawing.Point(193, 59);
            this.lbWorkPlace.Name = "lbWorkPlace";
            this.lbWorkPlace.Size = new System.Drawing.Size(54, 20);
            this.lbWorkPlace.TabIndex = 0;
            this.lbWorkPlace.Values.Text = "작업장 :";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Location = new System.Drawing.Point(14, 18);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(54, 20);
            this.lbCompanyName.TabIndex = 1;
            this.lbCompanyName.Values.Text = "업체명 :";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Location = new System.Drawing.Point(193, 18);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(57, 20);
            this.lbEmployeeName.TabIndex = 2;
            this.lbEmployeeName.Values.Text = "검사자  :";
            // 
            // lbProductCode
            // 
            this.lbProductCode.Location = new System.Drawing.Point(14, 59);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(45, 20);
            this.lbProductCode.TabIndex = 3;
            this.lbProductCode.Values.Text = "품 목 :";
            // 
            // lbProductionDate
            // 
            this.lbProductionDate.Location = new System.Drawing.Point(384, 17);
            this.lbProductionDate.Name = "lbProductionDate";
            this.lbProductionDate.Size = new System.Drawing.Size(54, 20);
            this.lbProductionDate.TabIndex = 6;
            this.lbProductionDate.Values.Text = "생산일 :";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txbWorker);
            this.kryptonPanel1.Controls.Add(this.cbbItemCode);
            this.kryptonPanel1.Controls.Add(this.cbbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dtpProductionToDate);
            this.kryptonPanel1.Controls.Add(this.dtpProductionFromDate);
            this.kryptonPanel1.Controls.Add(this.txbCompanyName);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.lbProductionDate);
            this.kryptonPanel1.Controls.Add(this.lbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.lbCompanyName);
            this.kryptonPanel1.Controls.Add(this.lbEmployeeName);
            this.kryptonPanel1.Controls.Add(this.lbProductCode);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(826, 90);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // txbWorker
            // 
            this.txbWorker.Location = new System.Drawing.Point(267, 19);
            this.txbWorker.Name = "txbWorker";
            this.txbWorker.Size = new System.Drawing.Size(92, 21);
            this.txbWorker.TabIndex = 19;
            // 
            // cbbItemCode
            // 
            this.cbbItemCode.DataSource = this.bdsItem;
            this.cbbItemCode.DisplayMember = "Name";
            this.cbbItemCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItemCode.DropDownWidth = 100;
            this.cbbItemCode.Location = new System.Drawing.Point(75, 59);
            this.cbbItemCode.Name = "cbbItemCode";
            this.cbbItemCode.Size = new System.Drawing.Size(100, 21);
            this.cbbItemCode.TabIndex = 18;
            this.cbbItemCode.ValueMember = "ItemId";
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // cbbWorkPlace
            // 
            this.cbbWorkPlace.DataSource = this.bdsWorkPlace;
            this.cbbWorkPlace.DisplayMember = "Name";
            this.cbbWorkPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWorkPlace.DropDownWidth = 121;
            this.cbbWorkPlace.Location = new System.Drawing.Point(267, 59);
            this.cbbWorkPlace.Name = "cbbWorkPlace";
            this.cbbWorkPlace.Size = new System.Drawing.Size(101, 21);
            this.cbbWorkPlace.TabIndex = 17;
            this.cbbWorkPlace.ValueMember = "WorkPlaceId";
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(354, 59);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "~";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(541, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // dtpProductionToDate
            // 
            this.dtpProductionToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductionToDate.Location = new System.Drawing.Point(566, 15);
            this.dtpProductionToDate.Name = "dtpProductionToDate";
            this.dtpProductionToDate.Size = new System.Drawing.Size(86, 21);
            this.dtpProductionToDate.TabIndex = 11;
            // 
            // dtpProductionFromDate
            // 
            this.dtpProductionFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductionFromDate.Location = new System.Drawing.Point(445, 15);
            this.dtpProductionFromDate.Name = "dtpProductionFromDate";
            this.dtpProductionFromDate.Size = new System.Drawing.Size(90, 21);
            this.dtpProductionFromDate.TabIndex = 10;
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(75, 19);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 23);
            this.txbCompanyName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(720, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LastInspectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "LastInspectionSearch";
            this.Size = new System.Drawing.Size(826, 90);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbWorkPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProductCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProductionDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpProductionToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpProductionFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbWorkPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbItemCode;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.TextBox txbWorker;
    }
}
