namespace PCBVI.Controls.Production.Worker
{
    partial class WorkerSearch
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
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbRotation = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbItemName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsRotation = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.dtpToDate);
            this.kryptonPanel1.Controls.Add(this.dtpFromDate);
            this.kryptonPanel1.Controls.Add(this.cbbRotation);
            this.kryptonPanel1.Controls.Add(this.cbbItemName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(864, 71);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(757, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Values.Text = "검 색";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(570, 28);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(19, 20);
            this.kryptonLabel4.TabIndex = 25;
            this.kryptonLabel4.Values.Text = "~";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(595, 26);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(132, 21);
            this.dtpToDate.TabIndex = 24;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(451, 26);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(113, 21);
            this.dtpFromDate.TabIndex = 23;
            // 
            // cbbRotation
            // 
            this.cbbRotation.DisplayMember = "Name";
            this.cbbRotation.DropDownWidth = 121;
            this.cbbRotation.Location = new System.Drawing.Point(267, 28);
            this.cbbRotation.Name = "cbbRotation";
            this.cbbRotation.Size = new System.Drawing.Size(121, 21);
            this.cbbRotation.TabIndex = 22;
            this.cbbRotation.ValueMember = "RotationGroupId";
            // 
            // cbbItemName
            // 
            this.cbbItemName.DisplayMember = "Name";
            this.cbbItemName.DropDownWidth = 121;
            this.cbbItemName.Location = new System.Drawing.Point(80, 27);
            this.cbbItemName.Name = "cbbItemName";
            this.cbbItemName.Size = new System.Drawing.Size(121, 21);
            this.cbbItemName.TabIndex = 21;
            this.cbbItemName.ValueMember = "ItemId";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(404, 28);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel3.TabIndex = 20;
            this.kryptonLabel3.Values.Text = "날짜 :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(207, 28);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "근무조 :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 28);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "품목명 :";
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // bdsRotation
            // 
            this.bdsRotation.DataSource = typeof(PCBVI.Data.RotationGroup);
            // 
            // WorkerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "WorkerSearch";
            this.Size = new System.Drawing.Size(864, 71);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbRotation;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbItemName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.BindingSource bdsRotation;
    }
}
