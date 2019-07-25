namespace Pos.UI
{
    partial class OrderForm
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
            this.PnlMain = new DevExpress.Utils.Layout.TablePanel();
            this.GrcSales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TbcMenu = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).BeginInit();
            this.TbcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.48F)});
            this.PnlMain.Controls.Add(this.TbcMenu);
            this.PnlMain.Controls.Add(this.GrcSales);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(10, 10);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39.59996F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 541.1999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.PnlMain.Size = new System.Drawing.Size(1470, 804);
            this.PnlMain.TabIndex = 0;
            // 
            // GrcSales
            // 
            this.PnlMain.SetColumn(this.GrcSales, 0);
            this.GrcSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrcSales.Location = new System.Drawing.Point(3, 43);
            this.GrcSales.MainView = this.gridView1;
            this.GrcSales.Name = "GrcSales";
            this.PnlMain.SetRow(this.GrcSales, 1);
            this.GrcSales.Size = new System.Drawing.Size(766, 535);
            this.GrcSales.TabIndex = 0;
            this.GrcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrcSales;
            this.gridView1.Name = "gridView1";
            // 
            // TbcMenu
            // 
            this.PnlMain.SetColumn(this.TbcMenu, 1);
            this.TbcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcMenu.Location = new System.Drawing.Point(772, 40);
            this.TbcMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TbcMenu.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.TbcMenu.Name = "TbcMenu";
            this.PnlMain.SetRow(this.TbcMenu, 1);
            this.TbcMenu.SelectedTabPage = this.xtraTabPage1;
            this.TbcMenu.Size = new System.Drawing.Size(698, 541);
            this.TbcMenu.TabIndex = 1;
            this.TbcMenu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(691, 505);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(685, 499);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(685, 499);
            this.xtraTabPage3.Text = "xtraTabPage3";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(685, 499);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 824);
            this.Controls.Add(this.PnlMain);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).EndInit();
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).EndInit();
            this.TbcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel PnlMain;
        private DevExpress.XtraTab.XtraTabControl TbcMenu;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl GrcSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
    }
}