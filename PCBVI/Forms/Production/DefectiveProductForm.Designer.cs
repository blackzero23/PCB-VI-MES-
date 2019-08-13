namespace PCBVI.Forms.Production
{
    partial class DefectiveProductForm
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
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.defectiveProductSearchMenu1 = new PCBVI.Controls.Production.DefectiveProduct.DefectiveProductSearchMenu();
            this.defectiveProductGridView1 = new PCBVI.Controls.Production.DefectiveProduct.DefectiveProductGridView();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenubar1
            // 
            this.topMenubar1.BackColor = System.Drawing.Color.White;
            this.topMenubar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenubar1.Location = new System.Drawing.Point(0, 0);
            this.topMenubar1.Name = "topMenubar1";
            this.topMenubar1.Size = new System.Drawing.Size(800, 35);
            this.topMenubar1.TabIndex = 0;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 35);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(800, 415);
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPage1.Controls.Add(this.defectiveProductGridView1);
            this.kryptonPage1.Controls.Add(this.defectiveProductSearchMenu1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(798, 388);
            this.kryptonPage1.Text = "불량관리";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "76FA1DE2846C469AB288F7A6D2590FBB";
            // 
            // defectiveProductSearchMenu1
            // 
            this.defectiveProductSearchMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defectiveProductSearchMenu1.Location = new System.Drawing.Point(0, 0);
            this.defectiveProductSearchMenu1.Name = "defectiveProductSearchMenu1";
            this.defectiveProductSearchMenu1.Size = new System.Drawing.Size(798, 75);
            this.defectiveProductSearchMenu1.TabIndex = 0;
            // 
            // defectiveProductGridView1
            // 
            this.defectiveProductGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defectiveProductGridView1.Location = new System.Drawing.Point(0, 75);
            this.defectiveProductGridView1.Name = "defectiveProductGridView1";
            this.defectiveProductGridView1.Size = new System.Drawing.Size(798, 313);
            this.defectiveProductGridView1.TabIndex = 1;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(35, 111);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(511, 20);
            this.kryptonTextBox1.TabIndex = 2;
            this.kryptonTextBox1.Text = "공정명 LOT No 시리얼 No 불량명 작업자 작업일자 제품사진 [재작업]";
            // 
            // DefectiveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefectiveProductForm";
            this.Text = "DefectiveProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private Controls.Production.DefectiveProduct.DefectiveProductSearchMenu defectiveProductSearchMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Controls.Production.DefectiveProduct.DefectiveProductGridView defectiveProductGridView1;
    }
}