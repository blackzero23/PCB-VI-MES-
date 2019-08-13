namespace PCBVI.Forms.Basic
{
    partial class FacilitiesForm
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
            this.naviEmployee = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageEmployee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.facilitiesList1 = new PCBVI.Controls.Basic.Facilities.FacilitiesList();
            this.facilitiesSpec1 = new PCBVI.Controls.Basic.Facilities.FacilitiesSpec();
            this.facilitiesSearch1 = new PCBVI.Controls.Basic.Facilities.FacilitiesSearch();
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).BeginInit();
            this.naviEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).BeginInit();
            this.pageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
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
            // naviEmployee
            // 
            this.naviEmployee.Bar.BarMapExtraText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None;
            this.naviEmployee.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviEmployee.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviEmployee.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.naviEmployee.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameHeight;
            this.naviEmployee.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium;
            this.naviEmployee.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.HighProfile;
            this.naviEmployee.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.Context;
            this.naviEmployee.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviEmployee.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviEmployee.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviEmployee.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small;
            this.naviEmployee.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.naviEmployee.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviEmployee.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviEmployee.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviEmployee.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviEmployee.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.naviEmployee.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.naviEmployee.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.naviEmployee.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.naviEmployee.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.naviEmployee.Location = new System.Drawing.Point(0, 35);
            this.naviEmployee.Name = "naviEmployee";
            this.naviEmployee.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.naviEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.naviEmployee.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.naviEmployee.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageEmployee});
            this.naviEmployee.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviEmployee.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.naviEmployee.SelectedIndex = 0;
            this.naviEmployee.Size = new System.Drawing.Size(800, 415);
            this.naviEmployee.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviEmployee.StateCommon.Tab.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.naviEmployee.StateCommon.Tab.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.naviEmployee.TabIndex = 3;
            this.naviEmployee.Text = "navi";
            // 
            // pageEmployee
            // 
            this.pageEmployee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageEmployee.Controls.Add(this.kryptonSplitContainer1);
            this.pageEmployee.Controls.Add(this.facilitiesSearch1);
            this.pageEmployee.Flags = 65534;
            this.pageEmployee.LastVisibleSet = true;
            this.pageEmployee.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageEmployee.Name = "pageEmployee";
            this.pageEmployee.Size = new System.Drawing.Size(798, 384);
            this.pageEmployee.Text = "설비정보";
            this.pageEmployee.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.pageEmployee.ToolTipTitle = "Page ToolTip";
            this.pageEmployee.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 66);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.facilitiesList1);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.facilitiesSpec1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(798, 318);
            this.kryptonSplitContainer1.SplitterDistance = 396;
            this.kryptonSplitContainer1.TabIndex = 3;
            // 
            // facilitiesList1
            // 
            this.facilitiesList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilitiesList1.Location = new System.Drawing.Point(0, 0);
            this.facilitiesList1.Name = "facilitiesList1";
            this.facilitiesList1.Size = new System.Drawing.Size(396, 318);
            this.facilitiesList1.TabIndex = 0;
            // 
            // facilitiesSpec1
            // 
            this.facilitiesSpec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilitiesSpec1.Location = new System.Drawing.Point(0, 0);
            this.facilitiesSpec1.Name = "facilitiesSpec1";
            this.facilitiesSpec1.Size = new System.Drawing.Size(397, 318);
            this.facilitiesSpec1.TabIndex = 0;
            // 
            // facilitiesSearch1
            // 
            this.facilitiesSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.facilitiesSearch1.Location = new System.Drawing.Point(0, 0);
            this.facilitiesSearch1.Name = "facilitiesSearch1";
            this.facilitiesSearch1.Size = new System.Drawing.Size(798, 66);
            this.facilitiesSearch1.TabIndex = 0;
            // 
            // FacilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviEmployee);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacilitiesForm";
            this.Text = "EquipmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviEmployee)).EndInit();
            this.naviEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageEmployee)).EndInit();
            this.pageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviEmployee;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageEmployee;
        private Controls.Basic.Facilities.FacilitiesSearch facilitiesSearch1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Controls.Basic.Facilities.FacilitiesList facilitiesList1;
        private Controls.Basic.Facilities.FacilitiesSpec facilitiesSpec1;
    }
}