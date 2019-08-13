namespace PCBVI.Forms.Materials
{
    partial class MaterialsHistoryForm
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
            this.naviMaterialHistory = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageMaterialHistory = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.materialsHSC1 = new PCBVI.Controls.Materials.MaterialsHSC();
            this.materialsHLC1 = new PCBVI.Controls.Materials.MaterialsHLC();
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialHistory)).BeginInit();
            this.naviMaterialHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageMaterialHistory)).BeginInit();
            this.pageMaterialHistory.SuspendLayout();
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
            // naviMaterialHistory
            // 
            this.naviMaterialHistory.Bar.BarMapExtraText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None;
            this.naviMaterialHistory.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviMaterialHistory.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviMaterialHistory.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.naviMaterialHistory.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameHeight;
            this.naviMaterialHistory.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium;
            this.naviMaterialHistory.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.HighProfile;
            this.naviMaterialHistory.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.Context;
            this.naviMaterialHistory.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviMaterialHistory.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialHistory.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviMaterialHistory.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviMaterialHistory.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small;
            this.naviMaterialHistory.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.naviMaterialHistory.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviMaterialHistory.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviMaterialHistory.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.naviMaterialHistory.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.naviMaterialHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviMaterialHistory.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.naviMaterialHistory.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.naviMaterialHistory.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.naviMaterialHistory.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.naviMaterialHistory.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.naviMaterialHistory.Location = new System.Drawing.Point(0, 35);
            this.naviMaterialHistory.Name = "naviMaterialHistory";
            this.naviMaterialHistory.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.naviMaterialHistory.Padding = new System.Windows.Forms.Padding(3);
            this.naviMaterialHistory.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.naviMaterialHistory.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageMaterialHistory});
            this.naviMaterialHistory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviMaterialHistory.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.naviMaterialHistory.SelectedIndex = 0;
            this.naviMaterialHistory.Size = new System.Drawing.Size(800, 415);
            this.naviMaterialHistory.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviMaterialHistory.StateCommon.Tab.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.naviMaterialHistory.StateCommon.Tab.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.naviMaterialHistory.TabIndex = 1;
            this.naviMaterialHistory.Text = "navi";
            // 
            // pageMaterialHistory
            // 
            this.pageMaterialHistory.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageMaterialHistory.Controls.Add(this.materialsHLC1);
            this.pageMaterialHistory.Controls.Add(this.materialsHSC1);
            this.pageMaterialHistory.Flags = 65534;
            this.pageMaterialHistory.LastVisibleSet = true;
            this.pageMaterialHistory.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageMaterialHistory.Name = "pageMaterialHistory";
            this.pageMaterialHistory.Size = new System.Drawing.Size(798, 386);
            this.pageMaterialHistory.Text = "자재 이력";
            this.pageMaterialHistory.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.pageMaterialHistory.ToolTipTitle = "Page ToolTip";
            this.pageMaterialHistory.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // materialsHSC1
            // 
            this.materialsHSC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialsHSC1.Location = new System.Drawing.Point(0, 0);
            this.materialsHSC1.Name = "materialsHSC1";
            this.materialsHSC1.Size = new System.Drawing.Size(798, 56);
            this.materialsHSC1.TabIndex = 0;
            // 
            // materialsHLC1
            // 
            this.materialsHLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsHLC1.Location = new System.Drawing.Point(0, 56);
            this.materialsHLC1.Name = "materialsHLC1";
            this.materialsHLC1.Size = new System.Drawing.Size(798, 330);
            this.materialsHLC1.TabIndex = 1;
            // 
            // MaterialsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naviMaterialHistory);
            this.Controls.Add(this.topMenubar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialsHistoryForm";
            this.Text = "MaterialsHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviMaterialHistory)).EndInit();
            this.naviMaterialHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageMaterialHistory)).EndInit();
            this.pageMaterialHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar topMenubar1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviMaterialHistory;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageMaterialHistory;
        private Controls.Materials.MaterialsHLC materialsHLC1;
        private Controls.Materials.MaterialsHSC materialsHSC1;
    }
}