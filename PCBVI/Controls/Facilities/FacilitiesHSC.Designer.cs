namespace PCBVI.Controls.Facilities
{
    partial class FacilitiesHSC
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsWorkPlace = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbFaciliesName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsFacilities = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbDivision = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bdsHistoryDivision = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbLocation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbDivision = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFaciliesName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHistoryDivision)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dtpToDate);
            this.kryptonPanel1.Controls.Add(this.cbbFaciliesName);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.cbbDivision);
            this.kryptonPanel1.Controls.Add(this.dtpFromDate);
            this.kryptonPanel1.Controls.Add(this.lbDate);
            this.kryptonPanel1.Controls.Add(this.lbLocation);
            this.kryptonPanel1.Controls.Add(this.lbDivision);
            this.kryptonPanel1.Controls.Add(this.lbName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(679, 109);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbbWorkPlace
            // 
            this.cbbWorkPlace.DataSource = this.bdsWorkPlace;
            this.cbbWorkPlace.DisplayMember = "Name";
            this.cbbWorkPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWorkPlace.DropDownWidth = 100;
            this.cbbWorkPlace.Location = new System.Drawing.Point(90, 66);
            this.cbbWorkPlace.Name = "cbbWorkPlace";
            this.cbbWorkPlace.Size = new System.Drawing.Size(100, 21);
            this.cbbWorkPlace.TabIndex = 16;
            this.cbbWorkPlace.ValueMember = "WorkPlaceId";
            // 
            // bdsWorkPlace
            // 
            this.bdsWorkPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(374, 30);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "~";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(399, 30);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(87, 21);
            this.dtpToDate.TabIndex = 14;
            // 
            // cbbFaciliesName
            // 
            this.cbbFaciliesName.DataSource = this.bdsFacilities;
            this.cbbFaciliesName.DisplayMember = "Name";
            this.cbbFaciliesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFaciliesName.DropDownWidth = 100;
            this.cbbFaciliesName.Location = new System.Drawing.Point(90, 30);
            this.cbbFaciliesName.Name = "cbbFaciliesName";
            this.cbbFaciliesName.Size = new System.Drawing.Size(100, 21);
            this.cbbFaciliesName.TabIndex = 13;
            this.cbbFaciliesName.ValueMember = "FacilitiesId";
            // 
            // bdsFacilities
            // 
            this.bdsFacilities.DataSource = typeof(PCBVI.Data.Facility);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(576, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Values.Text = "검 색";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbbDivision
            // 
            this.cbbDivision.DataSource = this.bdsHistoryDivision;
            this.cbbDivision.DisplayMember = "Name";
            this.cbbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDivision.DropDownWidth = 99;
            this.cbbDivision.Location = new System.Drawing.Point(281, 65);
            this.cbbDivision.Name = "cbbDivision";
            this.cbbDivision.Size = new System.Drawing.Size(99, 21);
            this.cbbDivision.TabIndex = 10;
            this.cbbDivision.ValueMember = "FHistoryDivisionId";
            // 
            // bdsHistoryDivision
            // 
            this.bdsHistoryDivision.DataSource = typeof(PCBVI.Data.FHistoryDivision);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(281, 30);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(87, 21);
            this.dtpFromDate.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(229, 30);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(45, 20);
            this.lbDate.TabIndex = 4;
            this.lbDate.Values.Text = "날 짜 :";
            // 
            // lbLocation
            // 
            this.lbLocation.Location = new System.Drawing.Point(39, 67);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(45, 20);
            this.lbLocation.TabIndex = 3;
            this.lbLocation.Values.Text = "장 소 :";
            // 
            // lbDivision
            // 
            this.lbDivision.Location = new System.Drawing.Point(229, 67);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(45, 20);
            this.lbDivision.TabIndex = 2;
            this.lbDivision.Values.Text = "구 분 :";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(15, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Values.Text = "설비 이름 :";
            // 
            // FacilitiesHSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FacilitiesHSC";
            this.Size = new System.Drawing.Size(679, 109);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFaciliesName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHistoryDivision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDivision;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDivision;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbFaciliesName;
        private System.Windows.Forms.BindingSource bdsFacilities;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbWorkPlace;
        private System.Windows.Forms.BindingSource bdsWorkPlace;
        private System.Windows.Forms.BindingSource bdsHistoryDivision;
    }
}
