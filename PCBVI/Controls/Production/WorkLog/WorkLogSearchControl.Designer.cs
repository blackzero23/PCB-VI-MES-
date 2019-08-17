namespace PCBVI.Controls.Production.WorkLog
{
    partial class WorkLogSearchControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdsRotation = new System.Windows.Forms.BindingSource(this.components);
            this.bdsItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsRotation
            // 
            this.bdsRotation.DataSource = typeof(PCBVI.Data.RotationGroup);
            // 
            // bdsItem
            // 
            this.bdsItem.DataSource = typeof(PCBVI.Data.Item);
            // 
            // WorkLogSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WorkLogSearchControl";
            this.Size = new System.Drawing.Size(942, 75);
            ((System.ComponentModel.ISupportInitialize)(this.bdsRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsItem;
        private System.Windows.Forms.BindingSource bdsRotation;
    }
}
