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
            this.naviBarcode = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageBarcode = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.uscList = new PCBVI.Controls.Basic.BarCode.BarcodeList();
            this.barcodeSearch1 = new PCBVI.Controls.Basic.BarCode.BarcodeSearch();
            this.uscTopMenu = new PCBVI.Controls.CommonControl.TopMenubar();
            ((System.ComponentModel.ISupportInitialize)(this.naviBarcode)).BeginInit();
            this.naviBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBarcode)).BeginInit();
            this.pageBarcode.SuspendLayout();
            this.SuspendLayout();
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
            this.pageBarcode.Controls.Add(this.barcodeSearch1);
            this.pageBarcode.Flags = 65534;
            this.pageBarcode.LastVisibleSet = true;
            this.pageBarcode.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageBarcode.Name = "pageBarcode";
            this.pageBarcode.Size = new System.Drawing.Size(831, 386);
            this.pageBarcode.Text = "바코드 정보";
            this.pageBarcode.ToolTipTitle = "Page ToolTip";
            this.pageBarcode.UniqueName = "B16A5854167348FF14A9DF677D016AAF";
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 68);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(831, 318);
            this.uscList.TabIndex = 1;
            // 
            // barcodeSearch1
            // 
            this.barcodeSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeSearch1.Location = new System.Drawing.Point(0, 0);
            this.barcodeSearch1.Name = "barcodeSearch1";
            this.barcodeSearch1.Size = new System.Drawing.Size(831, 68);
            this.barcodeSearch1.TabIndex = 0;
            this.barcodeSearch1.SearchButtonClicked += new System.EventHandler<PCBVI.Controls.Basic.BarCode.BarcodeSearch.SearchButtonClickedEventArgs>(this.BarcodeSearch1_SearchButtonClicked);
            // 
            // uscTopMenu
            // 
            this.uscTopMenu.BackColor = System.Drawing.Color.White;
            this.uscTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTopMenu.Location = new System.Drawing.Point(0, 0);
            this.uscTopMenu.Name = "uscTopMenu";
            this.uscTopMenu.Size = new System.Drawing.Size(833, 35);
            this.uscTopMenu.TabIndex = 0;
            this.uscTopMenu.InsertButtonClicked += new System.EventHandler<PCBVI.Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs>(this.UscTopMenu_InsertButtonClicked);
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
        private ComponentFactory.Krypton.Navigator.KryptonNavigator naviBarcode;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageBarcode;
        private Controls.Basic.BarCode.BarcodeSearch barcodeSearch1;
        private Controls.Basic.BarCode.BarcodeList uscList;
    }
}