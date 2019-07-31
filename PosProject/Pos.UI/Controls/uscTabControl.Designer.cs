namespace Pos.UI
{
    partial class TabButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uscTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.uscTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // uscTabControl
            // 
            this.uscTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTabControl.Location = new System.Drawing.Point(0, 0);
            this.uscTabControl.Name = "uscTabControl";
            this.uscTabControl.SelectedTabPage = this.xtraTabPage1;
            this.uscTabControl.Size = new System.Drawing.Size(1024, 649);
            this.uscTabControl.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1018, 643);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            // 
            // TabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uscTabControl);
            this.Name = "TabButton";
            this.Size = new System.Drawing.Size(1024, 649);
            ((System.ComponentModel.ISupportInitialize)(this.uscTabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabControl uscTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}
