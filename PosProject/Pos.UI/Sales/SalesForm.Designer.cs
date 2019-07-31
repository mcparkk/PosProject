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
            this.dbsSalesLines = new System.Windows.Forms.BindingSource(this.components);
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
            this.pncCalculator = new DevExpress.XtraEditors.PanelControl();
            this.tbpSummary = new DevExpress.Utils.Layout.TablePanel();
            this.lblChange = new DevExpress.XtraEditors.LabelControl();
            this.lblCredit = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txbChangeMoney = new DevExpress.XtraEditors.TextEdit();
            this.txbReceivedMoney = new DevExpress.XtraEditors.TextEdit();
            this.txbTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.tbpNumberPad = new DevExpress.Utils.Layout.TablePanel();
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
            this.spcOderOver = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnUpMenuCount = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownMenuCount = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalesComplate = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnCard = new DevExpress.XtraEditors.SimpleButton();
            this.btnCash = new DevExpress.XtraEditors.SimpleButton();
            this.PnlMain = new DevExpress.Utils.Layout.TablePanel();
            this.lblNowTime = new DevExpress.XtraEditors.LabelControl();
            this.tmrCurrentTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbsSalesLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).BeginInit();
            this.TbcMenu.SuspendLayout();
            this.TpgCoffee.SuspendLayout();
            this.TpgLatte.SuspendLayout();
            this.TpgAide.SuspendLayout();
            this.TpgTea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncCalculator)).BeginInit();
            this.pncCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSummary)).BeginInit();
            this.tbpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChangeMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbReceivedMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpNumberPad)).BeginInit();
            this.tbpNumberPad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncPayment)).BeginInit();
            this.pncPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcOderOver)).BeginInit();
            this.spcOderOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcMenu
            // 
            this.TbcMenu.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TbcMenu.Appearance.Options.UseFont = true;
            this.TbcMenu.AppearancePage.Header.Font = new System.Drawing.Font("한컴 백제 B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TbcMenu.AppearancePage.Header.Options.UseFont = true;
            this.PnlMain.SetColumn(this.TbcMenu, 1);
            this.TbcMenu.Location = new System.Drawing.Point(679, 40);
            this.TbcMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TbcMenu.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.TbcMenu.Name = "TbcMenu";
            this.PnlMain.SetRow(this.TbcMenu, 1);
            this.TbcMenu.SelectedTabPage = this.TpgCoffee;
            this.TbcMenu.Size = new System.Drawing.Size(613, 541);
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
            this.TpgCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TpgCoffee.Name = "TpgCoffee";
            this.TpgCoffee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TpgCoffee.Size = new System.Drawing.Size(607, 494);
            this.TpgCoffee.Text = "커피";
            // 
            // btnEspresso
            // 
            this.btnEspresso.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.btnEspresso.Appearance.Options.UseFont = true;
            this.btnEspresso.AppearanceDisabled.Font = new System.Drawing.Font("한컴 백제 B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEspresso.AppearanceDisabled.Options.UseFont = true;
            this.btnEspresso.Location = new System.Drawing.Point(153, 2);
            this.btnEspresso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(150, 115);
            this.btnEspresso.TabIndex = 1;
            this.btnEspresso.Text = "에스프레소";
            this.btnEspresso.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // btnAmericano
            // 
            this.btnAmericano.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAmericano.Appearance.Options.UseFont = true;
            this.btnAmericano.Location = new System.Drawing.Point(3, 2);
            this.btnAmericano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmericano.Name = "btnAmericano";
            this.btnAmericano.Size = new System.Drawing.Size(150, 115);
            this.btnAmericano.TabIndex = 0;
            this.btnAmericano.Text = "아메리카노";
            this.btnAmericano.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgLatte
            // 
            this.TpgLatte.Controls.Add(this.simpleButton3);
            this.TpgLatte.Controls.Add(this.simpleButton4);
            this.TpgLatte.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgLatte.ImageOptions.SvgImage")));
            this.TpgLatte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TpgLatte.Name = "TpgLatte";
            this.TpgLatte.Size = new System.Drawing.Size(607, 494);
            this.TpgLatte.Text = "라떼";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(153, 2);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(150, 115);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "바닐라라떼";
            this.simpleButton3.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(3, 2);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(150, 115);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "카페라떼";
            this.simpleButton4.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgAide
            // 
            this.TpgAide.Controls.Add(this.simpleButton5);
            this.TpgAide.Controls.Add(this.simpleButton6);
            this.TpgAide.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgAide.ImageOptions.SvgImage")));
            this.TpgAide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TpgAide.Name = "TpgAide";
            this.TpgAide.Size = new System.Drawing.Size(607, 494);
            this.TpgAide.Text = "에이드";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(153, 2);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(150, 115);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "레몬에이드";
            this.simpleButton5.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(3, 2);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(150, 115);
            this.simpleButton6.TabIndex = 2;
            this.simpleButton6.Text = "자몽에이드";
            this.simpleButton6.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // TpgTea
            // 
            this.TpgTea.Controls.Add(this.simpleButton7);
            this.TpgTea.Controls.Add(this.simpleButton8);
            this.TpgTea.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TpgTea.ImageOptions.SvgImage")));
            this.TpgTea.Margin = new System.Windows.Forms.Padding(0);
            this.TpgTea.Name = "TpgTea";
            this.TpgTea.Size = new System.Drawing.Size(607, 494);
            this.TpgTea.Text = "티";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(153, 2);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(150, 115);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "페퍼민트";
            this.simpleButton7.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(3, 2);
            this.simpleButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(150, 115);
            this.simpleButton8.TabIndex = 2;
            this.simpleButton8.Text = "얼그레이";
            this.simpleButton8.Click += new System.EventHandler(this.MenuButtonClicked);
            // 
            // GrcSales
            // 
            this.PnlMain.SetColumn(this.GrcSales, 0);
            this.GrcSales.DataSource = this.dbsSalesLines;
            this.GrcSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrcSales.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrcSales.Location = new System.Drawing.Point(0, 40);
            this.GrcSales.MainView = this.GrvSales;
            this.GrcSales.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.GrcSales.Name = "GrcSales";
            this.PnlMain.SetRow(this.GrcSales, 1);
            this.GrcSales.Size = new System.Drawing.Size(679, 537);
            this.GrcSales.TabIndex = 2;
            this.GrcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSales});
            // 
            // GrvSales
            // 
            this.GrvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuName,
            this.colMenuUnitPrice,
            this.colQuantity,
            this.colTotalPrice});
            this.GrvSales.DetailHeight = 272;
            this.GrvSales.GridControl = this.GrcSales;
            this.GrvSales.Name = "GrvSales";
            this.GrvSales.OptionsView.ShowGroupPanel = false;
            this.GrvSales.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GrvSales_CellValueChanged);
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "메뉴";
            this.colMenuName.FieldName = "MenuName";
            this.colMenuName.MinWidth = 22;
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.OptionsColumn.AllowEdit = false;
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 0;
            this.colMenuName.Width = 82;
            // 
            // colMenuUnitPrice
            // 
            this.colMenuUnitPrice.Caption = "단가";
            this.colMenuUnitPrice.FieldName = "MenuUnitPrice";
            this.colMenuUnitPrice.MinWidth = 22;
            this.colMenuUnitPrice.Name = "colMenuUnitPrice";
            this.colMenuUnitPrice.OptionsColumn.AllowEdit = false;
            this.colMenuUnitPrice.Visible = true;
            this.colMenuUnitPrice.VisibleIndex = 1;
            this.colMenuUnitPrice.Width = 82;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "수량";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 22;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 82;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "금액";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 22;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            this.colTotalPrice.Width = 82;
            // 
            // pncCalculator
            // 
            this.PnlMain.SetColumn(this.pncCalculator, 0);
            this.pncCalculator.Controls.Add(this.tbpSummary);
            this.pncCalculator.Controls.Add(this.tbpNumberPad);
            this.pncCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncCalculator.Location = new System.Drawing.Point(3, 583);
            this.pncCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pncCalculator.Name = "pncCalculator";
            this.PnlMain.SetRow(this.pncCalculator, 2);
            this.pncCalculator.Size = new System.Drawing.Size(673, 217);
            this.pncCalculator.TabIndex = 3;
            // 
            // tbpSummary
            // 
            this.tbpSummary.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.51F)});
            this.tbpSummary.Controls.Add(this.lblChange);
            this.tbpSummary.Controls.Add(this.lblCredit);
            this.tbpSummary.Controls.Add(this.lblTotal);
            this.tbpSummary.Controls.Add(this.txbChangeMoney);
            this.tbpSummary.Controls.Add(this.txbReceivedMoney);
            this.tbpSummary.Controls.Add(this.txbTotalPrice);
            this.tbpSummary.Location = new System.Drawing.Point(0, 0);
            this.tbpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSummary.Name = "tbpSummary";
            this.tbpSummary.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.3F)});
            this.tbpSummary.Size = new System.Drawing.Size(309, 218);
            this.tbpSummary.TabIndex = 2;
            // 
            // lblChange
            // 
            this.lblChange.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChange.Appearance.Options.UseFont = true;
            this.tbpSummary.SetColumn(this.lblChange, 0);
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChange.Location = new System.Drawing.Point(3, 146);
            this.lblChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblChange.Name = "lblChange";
            this.tbpSummary.SetRow(this.lblChange, 2);
            this.lblChange.Size = new System.Drawing.Size(105, 70);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "거스름돈 :";
            // 
            // lblCredit
            // 
            this.lblCredit.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCredit.Appearance.Options.UseFont = true;
            this.tbpSummary.SetColumn(this.lblCredit, 0);
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredit.Location = new System.Drawing.Point(3, 74);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCredit.Name = "lblCredit";
            this.tbpSummary.SetRow(this.lblCredit, 1);
            this.lblCredit.Size = new System.Drawing.Size(105, 68);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "받은금액 :";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.tbpSummary.SetColumn(this.lblTotal, 0);
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(3, 2);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotal.Name = "lblTotal";
            this.tbpSummary.SetRow(this.lblTotal, 0);
            this.lblTotal.Size = new System.Drawing.Size(105, 68);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "  합계   :";
            // 
            // txbChangeMoney
            // 
            this.tbpSummary.SetColumn(this.txbChangeMoney, 1);
            this.txbChangeMoney.EditValue = "0";
            this.txbChangeMoney.Location = new System.Drawing.Point(114, 161);
            this.txbChangeMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbChangeMoney.Name = "txbChangeMoney";
            this.txbChangeMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbChangeMoney.Properties.Appearance.Options.UseFont = true;
            this.txbChangeMoney.Properties.Mask.EditMask = "c";
            this.txbChangeMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpSummary.SetRow(this.txbChangeMoney, 2);
            this.txbChangeMoney.Size = new System.Drawing.Size(192, 40);
            this.txbChangeMoney.TabIndex = 2;
            // 
            // txbReceivedMoney
            // 
            this.tbpSummary.SetColumn(this.txbReceivedMoney, 1);
            this.txbReceivedMoney.EditValue = "0";
            this.txbReceivedMoney.Location = new System.Drawing.Point(114, 88);
            this.txbReceivedMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbReceivedMoney.Name = "txbReceivedMoney";
            this.txbReceivedMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbReceivedMoney.Properties.Appearance.Options.UseFont = true;
            this.txbReceivedMoney.Properties.Mask.EditMask = "c";
            this.txbReceivedMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpSummary.SetRow(this.txbReceivedMoney, 1);
            this.txbReceivedMoney.Size = new System.Drawing.Size(192, 40);
            this.txbReceivedMoney.TabIndex = 1;
            this.txbReceivedMoney.TextChanged += new System.EventHandler(this.txbMoneyChange);
            // 
            // txbTotalPrice
            // 
            this.tbpSummary.SetColumn(this.txbTotalPrice, 1);
            this.txbTotalPrice.EditValue = "0";
            this.txbTotalPrice.Location = new System.Drawing.Point(114, 16);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txbTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txbTotalPrice.Properties.Mask.EditMask = "00000-9999";
            this.txbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpSummary.SetRow(this.txbTotalPrice, 0);
            this.txbTotalPrice.Size = new System.Drawing.Size(192, 40);
            this.txbTotalPrice.TabIndex = 0;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbMoneyChange);
            // 
            // tbpNumberPad
            // 
            this.tbpNumberPad.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.39F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tbpNumberPad.Controls.Add(this.btnBackSpace);
            this.tbpNumberPad.Controls.Add(this.btn0);
            this.tbpNumberPad.Controls.Add(this.btn00);
            this.tbpNumberPad.Controls.Add(this.btn3);
            this.tbpNumberPad.Controls.Add(this.btn2);
            this.tbpNumberPad.Controls.Add(this.btn1);
            this.tbpNumberPad.Controls.Add(this.btn6);
            this.tbpNumberPad.Controls.Add(this.btn5);
            this.tbpNumberPad.Controls.Add(this.btn4);
            this.tbpNumberPad.Controls.Add(this.btn9);
            this.tbpNumberPad.Controls.Add(this.btn8);
            this.tbpNumberPad.Controls.Add(this.btn7);
            this.tbpNumberPad.Location = new System.Drawing.Point(312, 0);
            this.tbpNumberPad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNumberPad.Name = "tbpNumberPad";
            this.tbpNumberPad.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F)});
            this.tbpNumberPad.Size = new System.Drawing.Size(359, 218);
            this.tbpNumberPad.TabIndex = 1;
            // 
            // btnBackSpace
            // 
            this.tbpNumberPad.SetColumn(this.btnBackSpace, 2);
            this.btnBackSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackSpace.Location = new System.Drawing.Point(243, 164);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSpace.Name = "btnBackSpace";
            this.tbpNumberPad.SetRow(this.btnBackSpace, 3);
            this.btnBackSpace.Size = new System.Drawing.Size(113, 52);
            this.btnBackSpace.TabIndex = 11;
            this.btnBackSpace.Text = "←";
            this.btnBackSpace.Click += new System.EventHandler(this.BackSpaceButtonClicked);
            // 
            // btn0
            // 
            this.tbpNumberPad.SetColumn(this.btn0, 1);
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(122, 164);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.tbpNumberPad.SetRow(this.btn0, 3);
            this.btn0.Size = new System.Drawing.Size(115, 52);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn00
            // 
            this.tbpNumberPad.SetColumn(this.btn00, 0);
            this.btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn00.Location = new System.Drawing.Point(3, 164);
            this.btn00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn00.Name = "btn00";
            this.tbpNumberPad.SetRow(this.btn00, 3);
            this.btn00.Size = new System.Drawing.Size(113, 52);
            this.btn00.TabIndex = 9;
            this.btn00.Text = "00";
            this.btn00.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn3
            // 
            this.tbpNumberPad.SetColumn(this.btn3, 2);
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(243, 110);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.tbpNumberPad.SetRow(this.btn3, 2);
            this.btn3.Size = new System.Drawing.Size(113, 50);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn2
            // 
            this.tbpNumberPad.SetColumn(this.btn2, 1);
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(122, 110);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.tbpNumberPad.SetRow(this.btn2, 2);
            this.btn2.Size = new System.Drawing.Size(115, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn1
            // 
            this.tbpNumberPad.SetColumn(this.btn1, 0);
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 110);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.tbpNumberPad.SetRow(this.btn1, 2);
            this.btn1.Size = new System.Drawing.Size(113, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn6
            // 
            this.tbpNumberPad.SetColumn(this.btn6, 2);
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(243, 56);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.tbpNumberPad.SetRow(this.btn6, 1);
            this.btn6.Size = new System.Drawing.Size(113, 50);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn5
            // 
            this.tbpNumberPad.SetColumn(this.btn5, 1);
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(122, 56);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.tbpNumberPad.SetRow(this.btn5, 1);
            this.btn5.Size = new System.Drawing.Size(115, 50);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn4
            // 
            this.tbpNumberPad.SetColumn(this.btn4, 0);
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 56);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.tbpNumberPad.SetRow(this.btn4, 1);
            this.btn4.Size = new System.Drawing.Size(113, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn9
            // 
            this.tbpNumberPad.SetColumn(this.btn9, 2);
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(243, 2);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.tbpNumberPad.SetRow(this.btn9, 0);
            this.btn9.Size = new System.Drawing.Size(113, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn8
            // 
            this.tbpNumberPad.SetColumn(this.btn8, 1);
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(122, 2);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.tbpNumberPad.SetRow(this.btn8, 0);
            this.btn8.Size = new System.Drawing.Size(115, 50);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // btn7
            // 
            this.tbpNumberPad.SetColumn(this.btn7, 0);
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 2);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.tbpNumberPad.SetRow(this.btn7, 0);
            this.btn7.Size = new System.Drawing.Size(113, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.NumberBottonClicked);
            // 
            // pncPayment
            // 
            this.PnlMain.SetColumn(this.pncPayment, 1);
            this.pncPayment.Controls.Add(this.spcOderOver);
            this.pncPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncPayment.Location = new System.Drawing.Point(682, 583);
            this.pncPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pncPayment.Name = "pncPayment";
            this.PnlMain.SetRow(this.pncPayment, 2);
            this.pncPayment.Size = new System.Drawing.Size(607, 217);
            this.pncPayment.TabIndex = 4;
            // 
            // spcOderOver
            // 
            this.spcOderOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcOderOver.IsSplitterFixed = true;
            this.spcOderOver.Location = new System.Drawing.Point(2, 2);
            this.spcOderOver.Name = "spcOderOver";
            this.spcOderOver.Panel1.Controls.Add(this.splitContainerControl1);
            this.spcOderOver.Panel1.Text = "Panel1";
            this.spcOderOver.Panel2.Controls.Add(this.btnCancel);
            this.spcOderOver.Panel2.Controls.Add(this.btnSalesComplate);
            this.spcOderOver.Panel2.Controls.Add(this.btnOrderCancel);
            this.spcOderOver.Panel2.Controls.Add(this.btnCard);
            this.spcOderOver.Panel2.Controls.Add(this.btnCash);
            this.spcOderOver.Panel2.Text = "Panel2";
            this.spcOderOver.Size = new System.Drawing.Size(603, 213);
            this.spcOderOver.SplitterPosition = 134;
            this.spcOderOver.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnUpMenuCount);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDownMenuCount);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(134, 213);
            this.splitContainerControl1.SplitterPosition = 103;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // btnUpMenuCount
            // 
            this.btnUpMenuCount.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpMenuCount.Appearance.Options.UseFont = true;
            this.btnUpMenuCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpMenuCount.Location = new System.Drawing.Point(0, 0);
            this.btnUpMenuCount.Name = "btnUpMenuCount";
            this.btnUpMenuCount.Size = new System.Drawing.Size(134, 103);
            this.btnUpMenuCount.TabIndex = 0;
            this.btnUpMenuCount.Text = "▲";
            this.btnUpMenuCount.Click += new System.EventHandler(this.UpButtonClicked);
            // 
            // btnDownMenuCount
            // 
            this.btnDownMenuCount.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownMenuCount.Appearance.Options.UseFont = true;
            this.btnDownMenuCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownMenuCount.Location = new System.Drawing.Point(0, 0);
            this.btnDownMenuCount.Name = "btnDownMenuCount";
            this.btnDownMenuCount.Size = new System.Drawing.Size(134, 105);
            this.btnDownMenuCount.TabIndex = 0;
            this.btnDownMenuCount.Text = "▼";
            this.btnDownMenuCount.Click += new System.EventHandler(this.DownButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(318, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 103);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "취 소";
            this.btnCancel.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // btnSalesComplate
            // 
            this.btnSalesComplate.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalesComplate.Appearance.Options.UseFont = true;
            this.btnSalesComplate.Location = new System.Drawing.Point(231, 108);
            this.btnSalesComplate.Name = "btnSalesComplate";
            this.btnSalesComplate.Size = new System.Drawing.Size(230, 103);
            this.btnSalesComplate.TabIndex = 0;
            this.btnSalesComplate.Text = "결제";
            this.btnSalesComplate.Click += new System.EventHandler(this.OrderComplateButtonClicked);
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 15F, System.Drawing.FontStyle.Bold);
            this.btnOrderCancel.Appearance.Options.UseFont = true;
            this.btnOrderCancel.Location = new System.Drawing.Point(1, 108);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(224, 103);
            this.btnOrderCancel.TabIndex = 0;
            this.btnOrderCancel.Text = "매출 취소";
            // 
            // btnCard
            // 
            this.btnCard.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 15F, System.Drawing.FontStyle.Bold);
            this.btnCard.Appearance.Options.UseFont = true;
            this.btnCard.Location = new System.Drawing.Point(159, 0);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(143, 103);
            this.btnCard.TabIndex = 0;
            this.btnCard.Text = "카 드";
            // 
            // btnCash
            // 
            this.btnCash.Appearance.Font = new System.Drawing.Font("한컴 백제 B", 15F, System.Drawing.FontStyle.Bold);
            this.btnCash.Appearance.Options.UseFont = true;
            this.btnCash.Location = new System.Drawing.Point(1, 0);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(143, 103);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "현 금";
            // 
            // PnlMain
            // 
            this.PnlMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.48F)});
            this.PnlMain.Controls.Add(this.lblNowTime);
            this.PnlMain.Controls.Add(this.pncPayment);
            this.PnlMain.Controls.Add(this.pncCalculator);
            this.PnlMain.Controls.Add(this.GrcSales);
            this.PnlMain.Controls.Add(this.TbcMenu);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(9, 8);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39.59996F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 541.1999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 72.40009F)});
            this.PnlMain.Size = new System.Drawing.Size(1292, 802);
            this.PnlMain.TabIndex = 0;
            // 
            // lblNowTime
            // 
            this.lblNowTime.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblNowTime.Appearance.Options.UseFont = true;
            this.PnlMain.SetColumn(this.lblNowTime, 1);
            this.lblNowTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNowTime.Location = new System.Drawing.Point(1171, 3);
            this.lblNowTime.Name = "lblNowTime";
            this.PnlMain.SetRow(this.lblNowTime, 0);
            this.lblNowTime.Size = new System.Drawing.Size(118, 24);
            this.lblNowTime.TabIndex = 5;
            this.lblNowTime.Text = "labelControl1";
            // 
            // tmrCurrentTime
            // 
            this.tmrCurrentTime.Interval = 1000;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1310, 818);
            this.Controls.Add(this.PnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dbsSalesLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbcMenu)).EndInit();
            this.TbcMenu.ResumeLayout(false);
            this.TpgCoffee.ResumeLayout(false);
            this.TpgLatte.ResumeLayout(false);
            this.TpgAide.ResumeLayout(false);
            this.TpgTea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrcSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncCalculator)).EndInit();
            this.pncCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpSummary)).EndInit();
            this.tbpSummary.ResumeLayout(false);
            this.tbpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChangeMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbReceivedMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpNumberPad)).EndInit();
            this.tbpNumberPad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pncPayment)).EndInit();
            this.pncPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcOderOver)).EndInit();
            this.spcOderOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbsSalesLines;
        private DevExpress.XtraTab.XtraTabControl TbcMenu;
        private DevExpress.Utils.Layout.TablePanel PnlMain;
        private DevExpress.XtraEditors.PanelControl pncPayment;
        private DevExpress.XtraEditors.PanelControl pncCalculator;
        private DevExpress.Utils.Layout.TablePanel tbpSummary;
        private DevExpress.XtraEditors.LabelControl lblChange;
        private DevExpress.XtraEditors.LabelControl lblCredit;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.TextEdit txbChangeMoney;
        private DevExpress.XtraEditors.TextEdit txbReceivedMoney;
        private DevExpress.XtraEditors.TextEdit txbTotalPrice;
        private DevExpress.Utils.Layout.TablePanel tbpNumberPad;
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
        private DevExpress.XtraEditors.SplitContainerControl spcOderOver;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpMenuCount;
        private DevExpress.XtraEditors.SimpleButton btnDownMenuCount;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSalesComplate;
        private DevExpress.XtraEditors.SimpleButton btnOrderCancel;
        private DevExpress.XtraEditors.SimpleButton btnCard;
        private DevExpress.XtraEditors.SimpleButton btnCash;
        private DevExpress.XtraEditors.LabelControl lblNowTime;
        private System.Windows.Forms.Timer tmrCurrentTime;
    }
}