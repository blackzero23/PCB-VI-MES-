namespace PCBVI.Forms.Basic
{
    partial class InspectionStForm
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
            this.naviEmployee = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageEmployee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.inspectionStandardSearch1 = new PCBVI.Controls.Basic.InspectionStandard.InspectionStandardSearch();
            this.topMenubar1 = new PCBVI.Controls.CommonControl.TopMenubar();
            this.inspectionStandardList1 = new PCBVI.Controls.Basic.InspectionStandard.InspectionStandardList();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).BeginInit();
            this.naviEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).BeginInit();
            this.pageEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviEmployee
            // 
            this.naviEmployee.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviEmployee.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviEmployee.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviEmployee.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviEmployee.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviEmployee.Location = new System.Drawing.Point(0, 35);
            this.naviEmployee.Name = "naviEmployee";
            this.naviEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.naviEmployee.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageEmployee});
            this.naviEmployee.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviEmployee.SelectedIndex = 0;
            this.naviEmployee.Size = new System.Drawing.Size(800, 415);
            this.naviEmployee.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviEmployee.TabIndex = 2;
            this.naviEmployee.Text = "navi";
            // 
            // pageEmployee
            // 
            this.pageEmployee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEmployee.Controls.Add(this.inspectionStandardList1);
            this.pageEmployee.Controls.Add(this.inspectionStandardSearch1);
            this.pageEmployee.Flags = 65534;
            this.pageEmployee.LastVisibleSet = true;
            this.pageEmployee.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEmployee.Name = "pageEmployee";
            this.pageEmployee.Size = new System.Drawing.Size(798, 384);
            this.pageEmployee.Text = "검사기준정보";
            this.pageEmployee.ToolTipTitle = "Page ToolTip";
            this.pageEmployee.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // inspectionStandardSearch1
            // 
            this.inspectionStandardSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.inspectionStandardSearch1.Location = new System.Drawing.Point(0, 0);
            this.inspectionStandardSearch1.Name = "inspectionStandardSearch1";
            this.inspectionStandardSearch1.Size = new System.Drawing.Size(798, 69);
            this.inspectionStandardSearch1.TabIndex = 0;
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
            // inspectionStandardList1
            // 
            this.inspectionStandardList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionStandardList1.Location = new System.Drawing.Point(0, 69);
            this.inspectionStandardList1.Name = "inspectionStandardList1";
            this.inspectionStandardList1.Size = new System.Drawing.Size(798, 315);
            this.inspectionStandardList1.TabIndex = 1;
            // 
            // InspectionStForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviEmployee);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionStForm";
            this.Text = "InspectionStForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).EndInit();
            this.naviEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).EndInit();
            this.pageEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviEmployee;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEmployee;
        private Controls.Basic.InspectionStandard.InspectionStandardSearch inspectionStandardSearch1;
        private Controls.Basic.InspectionStandard.InspectionStandardList inspectionStandardList1;
    }
}