namespace PCBVI.Forms.Production
{
    partial class WorkLogForm
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
            this.WorkLogEnrollment = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.workLogEnrollment1 = new PCBVI.Controls.Production.WorkLog.WorkLogEnrollment();
            this.workLogCommonMenu1 = new PCBVI.Controls.Production.WorkLog.WorkLogCommonMenu();
            this.WorkLogInquire = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.workLogInquire1 = new PCBVI.Controls.Production.WorkLog.WorkLogInquire();
            this.workLogCommonMenu2 = new PCBVI.Controls.Production.WorkLog.WorkLogCommonMenu();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkLogEnrollment)).BeginInit();
            this.WorkLogEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkLogInquire)).BeginInit();
            this.WorkLogInquire.SuspendLayout();
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
            this.kryptonPage1,
            this.WorkLogEnrollment,
            this.WorkLogInquire});
            this.kryptonNavigator1.SelectedIndex = 1;
            this.kryptonNavigator1.Size = new System.Drawing.Size(800, 415);
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Enabled = false;
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(798, 388);
            this.kryptonPage1.Text = "작업일지";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "A39FBF88B0584D7E8F87C787287F24B0";
            // 
            // WorkLogEnrollment
            // 
            this.WorkLogEnrollment.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.WorkLogEnrollment.Controls.Add(this.workLogEnrollment1);
            this.WorkLogEnrollment.Controls.Add(this.workLogCommonMenu1);
            this.WorkLogEnrollment.Flags = 65534;
            this.WorkLogEnrollment.LastVisibleSet = true;
            this.WorkLogEnrollment.MinimumSize = new System.Drawing.Size(50, 50);
            this.WorkLogEnrollment.Name = "WorkLogEnrollment";
            this.WorkLogEnrollment.Size = new System.Drawing.Size(798, 388);
            this.WorkLogEnrollment.Text = "등록";
            this.WorkLogEnrollment.ToolTipTitle = "Page ToolTip";
            this.WorkLogEnrollment.UniqueName = "30631063436B41A1E1AABA2D53F97292";
            // 
            // workLogEnrollment1
            // 
            this.workLogEnrollment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workLogEnrollment1.Location = new System.Drawing.Point(0, 75);
            this.workLogEnrollment1.Name = "workLogEnrollment1";
            this.workLogEnrollment1.Size = new System.Drawing.Size(798, 313);
            this.workLogEnrollment1.TabIndex = 3;
            // 
            // workLogCommonMenu1
            // 
            this.workLogCommonMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.workLogCommonMenu1.Location = new System.Drawing.Point(0, 0);
            this.workLogCommonMenu1.Name = "workLogCommonMenu1";
            this.workLogCommonMenu1.Size = new System.Drawing.Size(798, 75);
            this.workLogCommonMenu1.TabIndex = 2;
            // 
            // WorkLogInquire
            // 
            this.WorkLogInquire.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.WorkLogInquire.Controls.Add(this.workLogInquire1);
            this.WorkLogInquire.Controls.Add(this.workLogCommonMenu2);
            this.WorkLogInquire.Flags = 65534;
            this.WorkLogInquire.LastVisibleSet = true;
            this.WorkLogInquire.MinimumSize = new System.Drawing.Size(50, 50);
            this.WorkLogInquire.Name = "WorkLogInquire";
            this.WorkLogInquire.Size = new System.Drawing.Size(798, 388);
            this.WorkLogInquire.Text = "조회";
            this.WorkLogInquire.ToolTipTitle = "Page ToolTip";
            this.WorkLogInquire.UniqueName = "9A9A8FEB6DFA4B6A539304514B8721ED";
            // 
            // workLogInquire1
            // 
            this.workLogInquire1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workLogInquire1.Location = new System.Drawing.Point(0, 75);
            this.workLogInquire1.Name = "workLogInquire1";
            this.workLogInquire1.Size = new System.Drawing.Size(798, 313);
            this.workLogInquire1.TabIndex = 1;
            // 
            // workLogCommonMenu2
            // 
            this.workLogCommonMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.workLogCommonMenu2.Location = new System.Drawing.Point(0, 0);
            this.workLogCommonMenu2.Name = "workLogCommonMenu2";
            this.workLogCommonMenu2.Size = new System.Drawing.Size(798, 75);
            this.workLogCommonMenu2.TabIndex = 0;
            // 
            // WorkLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkLogForm";
            this.Text = "WorkLogForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkLogEnrollment)).EndInit();
            this.WorkLogEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkLogInquire)).EndInit();
            this.WorkLogInquire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage WorkLogEnrollment;
        private ComponentFactory.Krypton.Navigator.KryptonPage WorkLogInquire;
        private Controls.Production.WorkLog.WorkLogCommonMenu workLogCommonMenu1;
        private Controls.Production.WorkLog.WorkLogCommonMenu workLogCommonMenu2;
        private Controls.Production.WorkLog.WorkLogEnrollment workLogEnrollment1;
        private Controls.Production.WorkLog.WorkLogInquire workLogInquire1;
    }
}