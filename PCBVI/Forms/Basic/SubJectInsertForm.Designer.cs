namespace PCBVI.Forms.Basic
{
    partial class SubJectInsertForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubJectInsertForm));
            this.bdsFirst = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSecond = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbSecond = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbFirst = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbPlace = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstItemDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondItemDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsFirst
            // 
            this.bdsFirst.DataSource = typeof(PCBVI.Data.FirstItemDivision);
            // 
            // bdsSecond
            // 
            this.bdsSecond.DataSource = typeof(PCBVI.Data.SecondItemDivision);
            // 
            // bdsPlace
            // 
            this.bdsPlace.DataSource = typeof(PCBVI.Data.WorkPlace);
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(800, 450);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPage1.Controls.Add(this.kryptonPanel1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(798, 423);
            this.kryptonPage1.Text = "품목 신규 등록";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "3ECD653E7DE644B28A9A616A26ED1AA0";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnConfirm);
            this.kryptonPanel1.Controls.Add(this.txbNote);
            this.kryptonPanel1.Controls.Add(this.txbQuantity);
            this.kryptonPanel1.Controls.Add(this.txbPlace);
            this.kryptonPanel1.Controls.Add(this.txbSecond);
            this.kryptonPanel1.Controls.Add(this.txbName);
            this.kryptonPanel1.Controls.Add(this.txbCode);
            this.kryptonPanel1.Controls.Add(this.txbFirst);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 75);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(83, 43);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(100, 20);
            this.txbQuantity.TabIndex = 5;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbQuantity_KeyPress_1);
            this.txbQuantity.Leave += new System.EventHandler(this.TxbQuantity_Leave_1);
            // 
            // txbSecond
            // 
            this.txbSecond.Location = new System.Drawing.Point(594, 13);
            this.txbSecond.Name = "txbSecond";
            this.txbSecond.Size = new System.Drawing.Size(100, 20);
            this.txbSecond.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(416, 13);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 3;
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(240, 13);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(100, 20);
            this.txbCode.TabIndex = 2;
            // 
            // txbFirst
            // 
            this.txbFirst.Location = new System.Drawing.Point(83, 13);
            this.txbFirst.Name = "txbFirst";
            this.txbFirst.Size = new System.Drawing.Size(100, 20);
            this.txbFirst.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(522, 13);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel5.TabIndex = 0;
            this.kryptonLabel5.Values.Text = "품목분류 : ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(346, 13);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "품 목  명 : ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(189, 13);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "코 드 : ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "품목구분 : ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 43);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "수       량 : ";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(189, 43);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel6.TabIndex = 0;
            this.kryptonLabel6.Values.Text = "비 고 : ";
            // 
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(240, 43);
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(100, 20);
            this.txbNote.TabIndex = 6;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(346, 43);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel7.TabIndex = 0;
            this.kryptonLabel7.Values.Text = "위치정보 : ";
            // 
            // txbPlace
            // 
            this.txbPlace.Location = new System.Drawing.Point(416, 43);
            this.txbPlace.Name = "txbPlace";
            this.txbPlace.Size = new System.Drawing.Size(100, 20);
            this.txbPlace.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(604, 43);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 25);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Values.Text = "등록";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click_1);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.firstItemDivisionIdDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.secondItemDivisionIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.workPlaceIdDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.bdsItem;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 75);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(798, 348);
            this.kryptonDataGridView1.TabIndex = 1;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // firstItemDivisionIdDataGridViewTextBoxColumn
            // 
            this.firstItemDivisionIdDataGridViewTextBoxColumn.DataPropertyName = "FirstItemDivisionId";
            this.firstItemDivisionIdDataGridViewTextBoxColumn.DataSource = this.bdsFirst;
            this.firstItemDivisionIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.firstItemDivisionIdDataGridViewTextBoxColumn.HeaderText = "품목구분";
            this.firstItemDivisionIdDataGridViewTextBoxColumn.Name = "firstItemDivisionIdDataGridViewTextBoxColumn";
            this.firstItemDivisionIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.firstItemDivisionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.firstItemDivisionIdDataGridViewTextBoxColumn.ValueMember = "FirstItemDivisionId";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "코드";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "품목명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // secondItemDivisionIdDataGridViewTextBoxColumn
            // 
            this.secondItemDivisionIdDataGridViewTextBoxColumn.DataPropertyName = "SecondItemDivisionId";
            this.secondItemDivisionIdDataGridViewTextBoxColumn.DataSource = this.bdsSecond;
            this.secondItemDivisionIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.secondItemDivisionIdDataGridViewTextBoxColumn.HeaderText = "품목분류";
            this.secondItemDivisionIdDataGridViewTextBoxColumn.Name = "secondItemDivisionIdDataGridViewTextBoxColumn";
            this.secondItemDivisionIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secondItemDivisionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secondItemDivisionIdDataGridViewTextBoxColumn.ValueMember = "SecondItemDivisionId";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "수량";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "비고";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // workPlaceIdDataGridViewTextBoxColumn
            // 
            this.workPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkPlaceId";
            this.workPlaceIdDataGridViewTextBoxColumn.DataSource = this.bdsPlace;
            this.workPlaceIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.workPlaceIdDataGridViewTextBoxColumn.HeaderText = "위치정보";
            this.workPlaceIdDataGridViewTextBoxColumn.Name = "workPlaceIdDataGridViewTextBoxColumn";
            this.workPlaceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPlaceIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workPlaceIdDataGridViewTextBoxColumn.ValueMember = "WorkPlaceId";
            // 
            // SubJectInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubJectInsertForm";
            this.Text = "품목 신규 등록";
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsFirst;
        private System.Windows.Forms.BindingSource bdsSecond;
        private System.Windows.Forms.BindingSource bdsPlace;
        private System.Windows.Forms.BindingSource bdsItem;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbFirst;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbSecond;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbCode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbNote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn firstItemDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secondItemDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
    }
}