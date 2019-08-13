namespace PCBVI.Forms.Basic
{
    partial class SubJectForm
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
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.subjectGrid1 = new PCBVI.Controls.Basic.SubjectControl.SubjectGrid();
            this.subjectSearch1 = new PCBVI.Controls.Basic.SubjectControl.SubjectSearch();
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.kryptonNavigator1.Size = new System.Drawing.Size(949, 415);
            this.kryptonNavigator1.TabIndex = 2;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.subjectGrid1);
            this.kryptonPage1.Controls.Add(this.subjectSearch1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(947, 388);
            this.kryptonPage1.Text = "품목정보";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "959E674ED33C4409AA829284582CFFF9";
            // 
            // subjectGrid1
            // 
            this.subjectGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectGrid1.Location = new System.Drawing.Point(0, 75);
            this.subjectGrid1.Name = "subjectGrid1";
            this.subjectGrid1.Size = new System.Drawing.Size(947, 313);
            this.subjectGrid1.TabIndex = 1;
            // 
            // subjectSearch1
            // 
            this.subjectSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subjectSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectSearch1.Location = new System.Drawing.Point(0, 0);
            this.subjectSearch1.Name = "subjectSearch1";
            this.subjectSearch1.Size = new System.Drawing.Size(947, 75);
            this.subjectSearch1.TabIndex = 0;
            // 
            // topMenubar1
            // 
            this.topMenubar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenubar1.Location = new System.Drawing.Point(0, 0);
            this.topMenubar1.Name = "topMenubar1";
            this.topMenubar1.Size = new System.Drawing.Size(949, 35);
            this.topMenubar1.TabIndex = 1;
            // 
            // SubJectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubJectForm";
            this.Text = "SubJectForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Basic.SubjectControl.SubjectSearch subjectSearch1;
        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private Controls.Basic.SubjectControl.SubjectGrid subjectGrid1;
    }
}