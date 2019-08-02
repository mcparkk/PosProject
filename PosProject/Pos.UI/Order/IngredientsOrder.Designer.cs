namespace Pos.UI
{
    partial class IngredientsOrder
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
            this.tabButton1 = new Pos.UI.TabButton();
            this.grcOrder = new DevExpress.XtraGrid.GridControl();
            this.orderLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabButton1
            // 
            this.tabButton1.Location = new System.Drawing.Point(709, 56);
            this.tabButton1.Name = "tabButton1";
            this.tabButton1.Size = new System.Drawing.Size(591, 481);
            this.tabButton1.TabIndex = 0;
            this.tabButton1.TabButtonClicked += new System.EventHandler<Pos.UI.TabButton.TabButtonClickedEventArgs>(this.TabButtonClicked);
            // 
            // grcOrder
            // 
            this.grcOrder.DataSource = this.orderLinesBindingSource;
            this.grcOrder.Location = new System.Drawing.Point(12, 56);
            this.grcOrder.MainView = this.grvOrder;
            this.grcOrder.Name = "grcOrder";
            this.grcOrder.Size = new System.Drawing.Size(697, 477);
            this.grcOrder.TabIndex = 1;
            this.grcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvOrder});
            // 
            // grvOrder
            // 
            this.grvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity,
            this.colTotalPrice,
            this.colOrderID,
            this.colIngredient,
            this.colUnitPrice,
            this.colSupplierName,
            this.colSupplierPhoneNumber});
            this.grvOrder.GridControl = this.grcOrder;
            this.grvOrder.Name = "grvOrder";
            
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "수량";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 72;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "총 금액";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 4;
            this.colTotalPrice.Width = 83;
            // 
            // colOrderID
            // 
            this.colOrderID.Caption = "번호";
            this.colOrderID.FieldName = "LineId";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            this.colOrderID.Width = 42;
            // 
            // colIngredient
            // 
            this.colIngredient.Caption = "이름";
            this.colIngredient.FieldName = "Name";
            this.colIngredient.Name = "colIngredient";
            this.colIngredient.OptionsColumn.AllowEdit = false;
            this.colIngredient.Visible = true;
            this.colIngredient.VisibleIndex = 1;
            this.colIngredient.Width = 88;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "단가";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowEdit = false;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            this.colUnitPrice.Width = 91;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "공급처";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.OptionsColumn.AllowEdit = false;
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 5;
            this.colSupplierName.Width = 87;
            // 
            // colSupplierPhoneNumber
            // 
            this.colSupplierPhoneNumber.Caption = "공급처 전화번호";
            this.colSupplierPhoneNumber.FieldName = "SupplierPhoneNumber";
            this.colSupplierPhoneNumber.Name = "colSupplierPhoneNumber";
            this.colSupplierPhoneNumber.OptionsColumn.AllowEdit = false;
            this.colSupplierPhoneNumber.Visible = true;
            this.colSupplierPhoneNumber.VisibleIndex = 6;
            this.colSupplierPhoneNumber.Width = 111;
            // 
            // IngredientsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 818);
            this.Controls.Add(this.grcOrder);
            this.Controls.Add(this.tabButton1);
            this.Name = "IngredientsOrder";
            this.Text = "IngredientsOrder";
            ((System.ComponentModel.ISupportInitialize)(this.grcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabButton tabButton1;
        private DevExpress.XtraGrid.GridControl grcOrder;
        private System.Windows.Forms.BindingSource orderLinesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierPhoneNumber;
    }
}