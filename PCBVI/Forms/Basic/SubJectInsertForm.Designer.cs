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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbFirst = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbSecond = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TxbWorkPlace = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsFirst = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSecond = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPlace = new System.Windows.Forms.BindingSource(this.components);
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstItemDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondItemDivisionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(800, 29);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "품목 신규 등록";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "품목 구분 : ";
            // 
            // TxbFirst
            // 
            this.TxbFirst.Location = new System.Drawing.Point(103, 37);
            this.TxbFirst.Name = "TxbFirst";
            this.TxbFirst.Size = new System.Drawing.Size(100, 20);
            this.TxbFirst.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(209, 37);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "코드 : ";
            // 
            // TxbCode
            // 
            this.TxbCode.Location = new System.Drawing.Point(266, 37);
            this.TxbCode.Name = "TxbCode";
            this.TxbCode.Size = new System.Drawing.Size(100, 20);
            this.TxbCode.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(372, 38);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "품  목  명 : ";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(459, 37);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(100, 20);
            this.TxbName.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(565, 37);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "품목분류 : ";
            // 
            // TxbSecond
            // 
            this.TxbSecond.Location = new System.Drawing.Point(652, 36);
            this.TxbSecond.Name = "TxbSecond";
            this.TxbSecond.Size = new System.Drawing.Size(100, 20);
            this.TxbSecond.TabIndex = 4;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 71);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "수        량 : ";
            // 
            // TxbQuantity
            // 
            this.TxbQuantity.Location = new System.Drawing.Point(103, 70);
            this.TxbQuantity.Name = "TxbQuantity";
            this.TxbQuantity.Size = new System.Drawing.Size(100, 20);
            this.TxbQuantity.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(209, 70);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "비고 : ";
            // 
            // TxbNote
            // 
            this.TxbNote.Location = new System.Drawing.Point(266, 71);
            this.TxbNote.Name = "TxbNote";
            this.TxbNote.Size = new System.Drawing.Size(100, 20);
            this.TxbNote.TabIndex = 6;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(372, 72);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(81, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "위치정보 : ";
            // 
            // TxbWorkPlace
            // 
            this.TxbWorkPlace.Location = new System.Drawing.Point(459, 70);
            this.TxbWorkPlace.Name = "TxbWorkPlace";
            this.TxbWorkPlace.Size = new System.Drawing.Size(100, 20);
            this.TxbWorkPlace.TabIndex = 7;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(652, 71);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(100, 25);
            this.BtnConfirm.TabIndex = 8;
            this.BtnConfirm.Values.Text = "확인";
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.TxbFirst);
            this.kryptonPanel1.Controls.Add(this.BtnConfirm);
            this.kryptonPanel1.Controls.Add(this.materialLabel1);
            this.kryptonPanel1.Controls.Add(this.TxbSecond);
            this.kryptonPanel1.Controls.Add(this.materialLabel5);
            this.kryptonPanel1.Controls.Add(this.TxbName);
            this.kryptonPanel1.Controls.Add(this.materialLabel6);
            this.kryptonPanel1.Controls.Add(this.TxbCode);
            this.kryptonPanel1.Controls.Add(this.materialLabel7);
            this.kryptonPanel1.Controls.Add(this.TxbWorkPlace);
            this.kryptonPanel1.Controls.Add(this.materialLabel2);
            this.kryptonPanel1.Controls.Add(this.TxbNote);
            this.kryptonPanel1.Controls.Add(this.materialLabel3);
            this.kryptonPanel1.Controls.Add(this.TxbQuantity);
            this.kryptonPanel1.Controls.Add(this.materialLabel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 29);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 127);
            this.kryptonPanel1.TabIndex = 9;
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
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 156);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(800, 294);
            this.kryptonDataGridView1.TabIndex = 10;
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
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
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "네 이놈";
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
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubJectInsertForm";
            this.Text = "품목 신규 등록";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbFirst;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbSecond;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbQuantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbNote;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxbWorkPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn firstItemDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secondItemDivisionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsPlace;
        private System.Windows.Forms.BindingSource bdsItem;
    }
}