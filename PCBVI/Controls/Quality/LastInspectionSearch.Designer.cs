﻿namespace PCBVI.Controls.Quality
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
            this.lbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProductCode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbInspectionDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbProductionDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpInspectionTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpInspectionFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpProductionTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpProductionFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txbCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployeeName)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWorkPlace
            // 
            this.lbWorkPlace.Location = new System.Drawing.Point(14, 95);
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
            this.lbEmployeeName.Location = new System.Drawing.Point(181, 18);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(69, 20);
            this.lbEmployeeName.TabIndex = 2;
            this.lbEmployeeName.Values.Text = "검사 직원 :";
            // 
            // lbProductCode
            // 
            this.lbProductCode.Location = new System.Drawing.Point(2, 58);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(66, 20);
            this.lbProductCode.TabIndex = 3;
            this.lbProductCode.Values.Text = "품목코드 :";
            // 
            // lbInspectionDate
            // 
            this.lbInspectionDate.Location = new System.Drawing.Point(196, 58);
            this.lbInspectionDate.Name = "lbInspectionDate";
            this.lbInspectionDate.Size = new System.Drawing.Size(54, 20);
            this.lbInspectionDate.TabIndex = 4;
            this.lbInspectionDate.Values.Text = "검사일 :";
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
            this.kryptonPanel1.Controls.Add(this.cbbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.dtpInspectionTo);
            this.kryptonPanel1.Controls.Add(this.dtpInspectionFrom);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dtpProductionTo);
            this.kryptonPanel1.Controls.Add(this.dtpProductionFrom);
            this.kryptonPanel1.Controls.Add(this.cbbEmployeeName);
            this.kryptonPanel1.Controls.Add(this.txbCompanyName);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.lbProductionDate);
            this.kryptonPanel1.Controls.Add(this.lbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.lbCompanyName);
            this.kryptonPanel1.Controls.Add(this.lbInspectionDate);
            this.kryptonPanel1.Controls.Add(this.lbEmployeeName);
            this.kryptonPanel1.Controls.Add(this.lbProductCode);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(655, 129);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // cbbWorkPlace
            // 
            this.cbbWorkPlace.DropDownWidth = 121;
            this.cbbWorkPlace.Location = new System.Drawing.Point(74, 94);
            this.cbbWorkPlace.Name = "cbbWorkPlace";
            this.cbbWorkPlace.Size = new System.Drawing.Size(101, 21);
            this.cbbWorkPlace.TabIndex = 17;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(354, 59);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "~";
            // 
            // dtpInspectionTo
            // 
            this.dtpInspectionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInspectionTo.Location = new System.Drawing.Point(379, 58);
            this.dtpInspectionTo.Name = "dtpInspectionTo";
            this.dtpInspectionTo.Size = new System.Drawing.Size(86, 21);
            this.dtpInspectionTo.TabIndex = 15;
            // 
            // dtpInspectionFrom
            // 
            this.dtpInspectionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInspectionFrom.Location = new System.Drawing.Point(267, 58);
            this.dtpInspectionFrom.Name = "dtpInspectionFrom";
            this.dtpInspectionFrom.Size = new System.Drawing.Size(92, 21);
            this.dtpInspectionFrom.TabIndex = 14;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(74, 58);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBox1.TabIndex = 13;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(541, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // dtpProductionTo
            // 
            this.dtpProductionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductionTo.Location = new System.Drawing.Point(566, 15);
            this.dtpProductionTo.Name = "dtpProductionTo";
            this.dtpProductionTo.Size = new System.Drawing.Size(86, 21);
            this.dtpProductionTo.TabIndex = 11;
            // 
            // dtpProductionFrom
            // 
            this.dtpProductionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductionFrom.Location = new System.Drawing.Point(445, 15);
            this.dtpProductionFrom.Name = "dtpProductionFrom";
            this.dtpProductionFrom.Size = new System.Drawing.Size(90, 21);
            this.dtpProductionFrom.TabIndex = 10;
            // 
            // cbbEmployeeName
            // 
            this.cbbEmployeeName.DropDownWidth = 121;
            this.cbbEmployeeName.Location = new System.Drawing.Point(257, 17);
            this.cbbEmployeeName.Name = "cbbEmployeeName";
            this.cbbEmployeeName.Size = new System.Drawing.Size(121, 21);
            this.cbbEmployeeName.TabIndex = 9;
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(75, 19);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txbCompanyName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(553, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "검 색";
            // 
            // LastInspectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "LastInspectionSearch";
            this.Size = new System.Drawing.Size(655, 129);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployeeName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbWorkPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProductCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbInspectionDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProductionDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpProductionTo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpProductionFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpInspectionTo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpInspectionFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbWorkPlace;
    }
}