namespace PCBVI.Forms.Basic
{
    partial class BarcodeForm
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
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            this.uscSearch = new PCBVI.Controls.Basic.BarCode.BarcodeSearch();
            this.uscList = new PCBVI.Controls.Basic.BarCode.BarcodeList();
            this.naviBarcode = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageBarcode = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.naviBarcode)).BeginInit();
            this.naviBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBarcode)).BeginInit();
            this.pageBarcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(833, 35);
            this.uscTopMenu.TabIndex = 0;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(831, 68);
            this.uscSearch.TabIndex = 1;
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 68);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(831, 318);
            this.uscList.TabIndex = 2;
            // 
            // naviBarcode
            // 
            this.naviBarcode.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.naviBarcode.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.naviBarcode.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.naviBarcode.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviBarcode.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.None;
            this.naviBarcode.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.naviBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviBarcode.Location = new System.Drawing.Point(0, 35);
            this.naviBarcode.Name = "naviBarcode";
            this.naviBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.naviBarcode.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageBarcode});
            this.naviBarcode.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.naviBarcode.SelectedIndex = 0;
            this.naviBarcode.Size = new System.Drawing.Size(833, 415);
            this.naviBarcode.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("HY헤드라인M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.naviBarcode.TabIndex = 3;
            this.naviBarcode.Text = "navi";
            // 
            // pageBarcode
            // 
            this.pageBarcode.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageBarcode.Controls.Add(this.uscList);
            this.pageBarcode.Controls.Add(this.uscSearch);
            this.pageBarcode.Flags = 65534;
            this.pageBarcode.LastVisibleSet = true;
            this.pageBarcode.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageBarcode.Name = "pageBarcode";
            this.pageBarcode.Size = new System.Drawing.Size(831, 386);
            this.pageBarcode.Text = "바코드 정보";
            this.pageBarcode.ToolTipTitle = "Page ToolTip";
            this.pageBarcode.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.naviBarcode);
            this.Controls.Add(this.uscTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.naviBarcode)).EndInit();
            this.naviBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageBarcode)).EndInit();
            this.pageBarcode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommonControl.TopMenubar uscTopMenu;
        private Controls.Basic.BarCode.BarcodeSearch uscSearch;
        private Controls.Basic.BarCode.BarcodeList uscList;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviBarcode;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageBarcode;
    }
}