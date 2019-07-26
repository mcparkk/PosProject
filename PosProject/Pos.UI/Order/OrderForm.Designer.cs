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
            this.salesLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
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
            this.GrcSales = new DevExpress.XtraGrid.GridControl();
            this.GrvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pncCalculator = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbChangeMoney = new DevExpress.XtraEditors.TextEdit();
            this.txbReceivedMoney = new DevExpress.XtraEditors.TextEdit();
            this.txbTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnBackSpace = new DevExpress.XtraEditors.SimpleButton();
            this.btn0 = new DevExpress.XtraEditors.SimpleButton();
            this.btn00 = new DevExpress.XtraEditors.SimpleButton();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn9 = new DevExpress.XtraEditors.SimpleButton();
            this.btn8 = new DevExpress.XtraEditors.SimpleButton();
            this.btn7 = new DevExpress.XtraEditors.SimpleButton();
            this.pncPayment = new DevExpress.XtraEditors.PanelControl();
            this.PnlMain = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.salesLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).BeginInit();
            this.TbcMenu.SuspendLayout();
            this.TpgCoffee.SuspendLayout();
            this.TpgLatte.SuspendLayout();
            this.TpgAide.SuspendLayout();
            this.TpgTea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncCalculator)).BeginInit();
            this.pncCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChangeMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbReceivedMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesLinesBindingSource
            // 
            this.salesLinesBindingSource.DataSource = typeof(Pos.Data.SalesLine);
            // 
            // TbcMenu
            // 
            this.TbcMenu.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TbcMenu.Appearance.Options.UseFont = true;
            this.TbcMenu.AppearancePage.Header.Font = new System.Drawing.Font("한컴 백제 B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TbcMenu.AppearancePage.Header.Options.UseFont = true;
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
            this.btnEspresso.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.btnEspresso.Appearance.Options.UseFont = true;
            this.btnEspresso.AppearanceDisabled.Font = new System.Drawing.Font("한컴 백제 B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEspresso.AppearanceDisabled.Options.UseFont = true;
            this.btnEspresso.Location = new System.Drawing.Point(175, 3);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(171, 148);
            this.btnEspresso.TabIndex = 1;
            this.btnEspresso.Text = "에스프레소";
            this.btnEspresso.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // btnAmericano
            // 
            this.btnAmericano.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAmericano.Appearance.Options.UseFont = true;
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
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(175, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(171, 148);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "바닐라라떼";
            this.simpleButton3.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
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
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(175, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(171, 148);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "레몬에이드";
            this.simpleButton5.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
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
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(175, 3);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(171, 148);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "페퍼민트";
            this.simpleButton7.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(3, 3);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(171, 148);
            this.simpleButton8.TabIndex = 2;
            this.simpleButton8.Text = "얼그레이";
            this.simpleButton8.Click += new System.EventHandler(this.MenuButtonClicked);
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
            this.GrvSales,
            this.gridView1});
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
            this.GrvSales.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GrvSales_CellValueChanged);
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
            // gridView1
            // 
            this.gridView1.GridControl = this.GrcSales;
            this.gridView1.Name = "gridView1";
            // 
            // pncCalculator
            // 
            this.PnlMain.SetColumn(this.pncCalculator, 0);
            this.pncCalculator.Controls.Add(this.tablePanel2);
            this.pncCalculator.Controls.Add(this.tablePanel1);
            this.pncCalculator.Location = new System.Drawing.Point(3, 584);
            this.pncCalculator.Name = "pncCalculator";
            this.PnlMain.SetRow(this.pncCalculator, 2);
            this.pncCalculator.Size = new System.Drawing.Size(766, 217);
            this.pncCalculator.TabIndex = 3;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.51F)});
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Controls.Add(this.txbChangeMoney);
            this.tablePanel2.Controls.Add(this.txbReceivedMoney);
            this.tablePanel2.Controls.Add(this.txbTotalPrice);
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F)});
            this.tablePanel2.Size = new System.Drawing.Size(353, 220);
            this.tablePanel2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl3, 0);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 147);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(120, 70);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "거스름돈 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 75);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(120, 66);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "받은금액 :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(120, 66);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "  합계   :";
            // 
            // txbChangeMoney
            // 
            this.tablePanel2.SetColumn(this.txbChangeMoney, 1);
            this.txbChangeMoney.EditValue = "0";
            this.txbChangeMoney.Location = new System.Drawing.Point(129, 159);
            this.txbChangeMoney.Name = "txbChangeMoney";
            this.txbChangeMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbChangeMoney.Properties.Appearance.Options.UseFont = true;
            this.txbChangeMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.SetRow(this.txbChangeMoney, 2);
            this.txbChangeMoney.Size = new System.Drawing.Size(221, 46);
            this.txbChangeMoney.TabIndex = 2;
            // 
            // txbReceivedMoney
            // 
            this.tablePanel2.SetColumn(this.txbReceivedMoney, 1);
            this.txbReceivedMoney.EditValue = "0";
            this.txbReceivedMoney.Location = new System.Drawing.Point(129, 85);
            this.txbReceivedMoney.Name = "txbReceivedMoney";
            this.txbReceivedMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbReceivedMoney.Properties.Appearance.Options.UseFont = true;
            this.txbReceivedMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.SetRow(this.txbReceivedMoney, 1);
            this.txbReceivedMoney.Size = new System.Drawing.Size(221, 46);
            this.txbReceivedMoney.TabIndex = 1;
            // 
            // txbTotalPrice
            // 
            this.tablePanel2.SetColumn(this.txbTotalPrice, 1);
            this.txbTotalPrice.EditValue = "0";
            this.txbTotalPrice.Location = new System.Drawing.Point(129, 13);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.SetRow(this.txbTotalPrice, 0);
            this.txbTotalPrice.Size = new System.Drawing.Size(221, 46);
            this.txbTotalPrice.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.39F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Controls.Add(this.btnBackSpace);
            this.tablePanel1.Controls.Add(this.btn0);
            this.tablePanel1.Controls.Add(this.btn00);
            this.tablePanel1.Controls.Add(this.btn3);
            this.tablePanel1.Controls.Add(this.btn2);
            this.tablePanel1.Controls.Add(this.btn1);
            this.tablePanel1.Controls.Add(this.btn6);
            this.tablePanel1.Controls.Add(this.btn5);
            this.tablePanel1.Controls.Add(this.btn4);
            this.tablePanel1.Controls.Add(this.btn9);
            this.tablePanel1.Controls.Add(this.btn8);
            this.tablePanel1.Controls.Add(this.btn7);
            this.tablePanel1.Location = new System.Drawing.Point(356, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(410, 217);
            this.tablePanel1.TabIndex = 1;
            // 
            // btnBackSpace
            // 
            this.tablePanel1.SetColumn(this.btnBackSpace, 2);
            this.btnBackSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackSpace.Location = new System.Drawing.Point(277, 165);
            this.btnBackSpace.Name = "btnBackSpace";
            this.tablePanel1.SetRow(this.btnBackSpace, 3);
            this.btnBackSpace.Size = new System.Drawing.Size(130, 48);
            this.btnBackSpace.TabIndex = 11;
            this.btnBackSpace.Text = "←";
            this.btnBackSpace.Click += new System.EventHandler(this.BackSpaceButtonClicked);
            // 
            // btn0
            // 
            this.tablePanel1.SetColumn(this.btn0, 1);
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(139, 165);
            this.btn0.Name = "btn0";
            this.tablePanel1.SetRow(this.btn0, 3);
            this.btn0.Size = new System.Drawing.Size(132, 48);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn00
            // 
            this.tablePanel1.SetColumn(this.btn00, 0);
            this.btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn00.Location = new System.Drawing.Point(3, 165);
            this.btn00.Name = "btn00";
            this.tablePanel1.SetRow(this.btn00, 3);
            this.btn00.Size = new System.Drawing.Size(130, 48);
            this.btn00.TabIndex = 9;
            this.btn00.Text = "00";
            this.btn00.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn3
            // 
            this.tablePanel1.SetColumn(this.btn3, 2);
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(277, 111);
            this.btn3.Name = "btn3";
            this.tablePanel1.SetRow(this.btn3, 2);
            this.btn3.Size = new System.Drawing.Size(130, 48);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn2
            // 
            this.tablePanel1.SetColumn(this.btn2, 1);
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(139, 111);
            this.btn2.Name = "btn2";
            this.tablePanel1.SetRow(this.btn2, 2);
            this.btn2.Size = new System.Drawing.Size(132, 48);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn1
            // 
            this.tablePanel1.SetColumn(this.btn1, 0);
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 111);
            this.btn1.Name = "btn1";
            this.tablePanel1.SetRow(this.btn1, 2);
            this.btn1.Size = new System.Drawing.Size(130, 48);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn6
            // 
            this.tablePanel1.SetColumn(this.btn6, 2);
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(277, 57);
            this.btn6.Name = "btn6";
            this.tablePanel1.SetRow(this.btn6, 1);
            this.btn6.Size = new System.Drawing.Size(130, 48);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn5
            // 
            this.tablePanel1.SetColumn(this.btn5, 1);
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(139, 57);
            this.btn5.Name = "btn5";
            this.tablePanel1.SetRow(this.btn5, 1);
            this.btn5.Size = new System.Drawing.Size(132, 48);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn4
            // 
            this.tablePanel1.SetColumn(this.btn4, 0);
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 57);
            this.btn4.Name = "btn4";
            this.tablePanel1.SetRow(this.btn4, 1);
            this.btn4.Size = new System.Drawing.Size(130, 48);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn9
            // 
            this.tablePanel1.SetColumn(this.btn9, 2);
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(277, 3);
            this.btn9.Name = "btn9";
            this.tablePanel1.SetRow(this.btn9, 0);
            this.btn9.Size = new System.Drawing.Size(130, 48);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn8
            // 
            this.tablePanel1.SetColumn(this.btn8, 1);
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(139, 3);
            this.btn8.Name = "btn8";
            this.tablePanel1.SetRow(this.btn8, 0);
            this.btn8.Size = new System.Drawing.Size(132, 48);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn7
            // 
            this.tablePanel1.SetColumn(this.btn7, 0);
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.tablePanel1.SetRow(this.btn7, 0);
            this.btn7.Size = new System.Drawing.Size(130, 48);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // pncPayment
            // 
            this.PnlMain.SetColumn(this.pncPayment, 1);
            this.pncPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncPayment.Location = new System.Drawing.Point(775, 584);
            this.pncPayment.Name = "pncPayment";
            this.PnlMain.SetRow(this.pncPayment, 2);
            this.pncPayment.Size = new System.Drawing.Size(692, 217);
            this.pncPayment.TabIndex = 4;
            // 
            // PnlMain
            // 
            this.PnlMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.48F)});
            this.PnlMain.Controls.Add(this.pncPayment);
            this.PnlMain.Controls.Add(this.pncCalculator);
            this.PnlMain.Controls.Add(this.GrcSales);
            this.PnlMain.Controls.Add(this.TbcMenu);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(10, 10);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39.59996F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 541.1999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.40009F)});
            this.PnlMain.Size = new System.Drawing.Size(1470, 804);
            this.PnlMain.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.salesLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).EndInit();
            this.TbcMenu.ResumeLayout(false);
            this.TpgCoffee.ResumeLayout(false);
            this.TpgLatte.ResumeLayout(false);
            this.TpgAide.ResumeLayout(false);
            this.TpgTea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncCalculator)).EndInit();
            this.pncCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChangeMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbReceivedMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pncPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salesLinesBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraTab.XtraTabControl TbcMenu;
        private DevExpress.Utils.Layout.TablePanel PnlMain;
        private DevExpress.XtraEditors.PanelControl pncPayment;
        private DevExpress.XtraEditors.PanelControl pncCalculator;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txbChangeMoney;
        private DevExpress.XtraEditors.TextEdit txbReceivedMoney;
        private DevExpress.XtraEditors.TextEdit txbTotalPrice;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnBackSpace;
        private DevExpress.XtraEditors.SimpleButton btn0;
        private DevExpress.XtraEditors.SimpleButton btn00;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton btn6;
        private DevExpress.XtraEditors.SimpleButton btn5;
        private DevExpress.XtraEditors.SimpleButton btn4;
        private DevExpress.XtraEditors.SimpleButton btn9;
        private DevExpress.XtraEditors.SimpleButton btn8;
        private DevExpress.XtraEditors.SimpleButton btn7;
        private DevExpress.XtraGrid.GridControl GrcSales;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSales;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraTab.XtraTabPage TpgCoffee;
        private DevExpress.XtraEditors.SimpleButton btnEspresso;
        private DevExpress.XtraEditors.SimpleButton btnAmericano;
        private DevExpress.XtraTab.XtraTabPage TpgLatte;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraTab.XtraTabPage TpgAide;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraTab.XtraTabPage TpgTea;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}