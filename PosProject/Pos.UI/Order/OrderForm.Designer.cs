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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.PnlMain = new DevExpress.Utils.Layout.TablePanel();
            this.GrcSales = new DevExpress.XtraGrid.GridControl();
            this.salesLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TbcMenu = new DevExpress.XtraTab.XtraTabControl();
            this.TpgCoffee = new DevExpress.XtraTab.XtraTabPage();
            this.btnEspresso = new DevExpress.XtraEditors.SimpleButton();
            this.btnAmericano = new DevExpress.XtraEditors.SimpleButton();
            this.TpgLatte = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.TpgAide = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.TpgTea = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).BeginInit();
            this.TbcMenu.SuspendLayout();
            this.TpgCoffee.SuspendLayout();
            this.TpgLatte.SuspendLayout();
            this.TpgAide.SuspendLayout();
            this.TpgTea.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.48F)});
            this.PnlMain.Controls.Add(this.GrcSales);
            this.PnlMain.Controls.Add(this.TbcMenu);
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
            this.GrcSales.DataSource = this.salesLinesBindingSource;
            this.GrcSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrcSales.Location = new System.Drawing.Point(3, 43);
            this.GrcSales.MainView = this.GrvSales;
            this.GrcSales.Name = "GrcSales";
            this.PnlMain.SetRow(this.GrcSales, 1);
            this.GrcSales.Size = new System.Drawing.Size(766, 535);
            this.GrcSales.TabIndex = 2;
            this.GrcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSales});
            // 
            // salesLinesBindingSource
            // 
            this.salesLinesBindingSource.DataSource = typeof(Pos.Data.SalesLine);
            // 
            // GrvSales
            // 
            this.GrvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuName,
            this.colMenuUnitPrice,
            this.colQuantity,
            this.colTotalPrice});
            this.GrvSales.GridControl = this.GrcSales;
            this.GrvSales.Name = "GrvSales";
            this.GrvSales.OptionsView.ShowGroupPanel = false;
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "메뉴";
            this.colMenuName.FieldName = "MenuName";
            this.colMenuName.MinWidth = 25;
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.OptionsColumn.AllowEdit = false;
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 0;
            this.colMenuName.Width = 94;
            // 
            // colMenuUnitPrice
            // 
            this.colMenuUnitPrice.Caption = "단가";
            this.colMenuUnitPrice.FieldName = "MenuUnitPrice";
            this.colMenuUnitPrice.MinWidth = 25;
            this.colMenuUnitPrice.Name = "colMenuUnitPrice";
            this.colMenuUnitPrice.OptionsColumn.AllowEdit = false;
            this.colMenuUnitPrice.Visible = true;
            this.colMenuUnitPrice.VisibleIndex = 1;
            this.colMenuUnitPrice.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "수량";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "금액";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            this.colTotalPrice.Width = 94;
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
            this.TbcMenu.SelectedTabPage = this.TpgCoffee;
            this.TbcMenu.Size = new System.Drawing.Size(698, 541);
            this.TbcMenu.TabIndex = 1;
            this.TbcMenu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TpgCoffee,
            this.TpgLatte,
            this.TpgAide,
            this.TpgTea});
            // 
            // TpgCoffee
            // 
            this.TpgCoffee.Controls.Add(this.btnEspresso);
            this.TpgCoffee.Controls.Add(this.btnAmericano);
            this.TpgCoffee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgCoffee.ImageOptions.SvgImage")));
            this.TpgCoffee.Name = "TpgCoffee";
            this.TpgCoffee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TpgCoffee.Size = new System.Drawing.Size(691, 483);
            this.TpgCoffee.Text = "커피";
            // 
            // btnEspresso
            // 
            this.btnEspresso.Location = new System.Drawing.Point(175, 3);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(171, 148);
            this.btnEspresso.TabIndex = 1;
            this.btnEspresso.Text = "에스프레소";
            this.btnEspresso.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // btnAmericano
            // 
            this.btnAmericano.Location = new System.Drawing.Point(3, 3);
            this.btnAmericano.Name = "btnAmericano";
            this.btnAmericano.Size = new System.Drawing.Size(171, 148);
            this.btnAmericano.TabIndex = 0;
            this.btnAmericano.Text = "아메리카노";
            this.btnAmericano.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgLatte
            // 
            this.TpgLatte.Controls.Add(this.simpleButton3);
            this.TpgLatte.Controls.Add(this.simpleButton4);
            this.TpgLatte.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgLatte.ImageOptions.SvgImage")));
            this.TpgLatte.Name = "TpgLatte";
            this.TpgLatte.Size = new System.Drawing.Size(691, 483);
            this.TpgLatte.Text = "라떼";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(175, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(171, 148);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "바닐라라떼";
            this.simpleButton3.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(3, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(171, 148);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "카페라떼";
            this.simpleButton4.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgAide
            // 
            this.TpgAide.Controls.Add(this.simpleButton5);
            this.TpgAide.Controls.Add(this.simpleButton6);
            this.TpgAide.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgAide.ImageOptions.SvgImage")));
            this.TpgAide.Name = "TpgAide";
            this.TpgAide.Size = new System.Drawing.Size(691, 483);
            this.TpgAide.Text = "에이드";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(175, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(171, 148);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "레몬에이드";
            this.simpleButton5.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(3, 3);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(171, 148);
            this.simpleButton6.TabIndex = 2;
            this.simpleButton6.Text = "자몽에이드";
            this.simpleButton6.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgTea
            // 
            this.TpgTea.Controls.Add(this.simpleButton7);
            this.TpgTea.Controls.Add(this.simpleButton8);
            this.TpgTea.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgTea.ImageOptions.SvgImage")));
            this.TpgTea.Name = "TpgTea";
            this.TpgTea.Size = new System.Drawing.Size(691, 483);
            this.TpgTea.Text = "티";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(175, 3);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(171, 148);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "페퍼민트";
            this.simpleButton7.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(3, 3);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(171, 148);
            this.simpleButton8.TabIndex = 2;
            this.simpleButton8.Text = "얼그레이";
            this.simpleButton8.Click += new System.EventHandler(this.MenuButtonClicked);
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
            ((System.ComponentModel.ISupportInitialize)(this.salesLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).EndInit();
            this.TbcMenu.ResumeLayout(false);
            this.TpgCoffee.ResumeLayout(false);
            this.TpgLatte.ResumeLayout(false);
            this.TpgAide.ResumeLayout(false);
            this.TpgTea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel PnlMain;
        private DevExpress.XtraTab.XtraTabControl TbcMenu;
        private DevExpress.XtraTab.XtraTabPage TpgCoffee;
        private DevExpress.XtraTab.XtraTabPage TpgLatte;
        private DevExpress.XtraTab.XtraTabPage TpgAide;
        private DevExpress.XtraTab.XtraTabPage TpgTea;
        
        
        private DevExpress.XtraEditors.SimpleButton btnEspresso;
        private DevExpress.XtraEditors.SimpleButton btnAmericano;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraGrid.GridControl GrcSales;
        private System.Windows.Forms.BindingSource salesLinesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSales;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
    }
}