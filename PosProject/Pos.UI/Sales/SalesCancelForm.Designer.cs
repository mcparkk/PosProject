namespace Pos.UI
{
    partial class SalesCancelForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesLines = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.salesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(55, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(617, 422);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(Pos.Data.Sale);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesID,
            this.colSalesTime,
            this.colSalesLines});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSalesID
            // 
            this.colSalesID.FieldName = "SalesID";
            this.colSalesID.Name = "colSalesID";
            this.colSalesID.Visible = true;
            this.colSalesID.VisibleIndex = 0;
            this.colSalesID.Width = 81;
            // 
            // colSalesTime
            // 
            this.colSalesTime.FieldName = "SalesTime";
            this.colSalesTime.Name = "colSalesTime";
            this.colSalesTime.Visible = true;
            this.colSalesTime.VisibleIndex = 1;
            this.colSalesTime.Width = 257;
            // 
            // colSalesLines
            // 
            this.colSalesLines.FieldName = "SalesLines";
            this.colSalesLines.Name = "colSalesLines";
            this.colSalesLines.Visible = true;
            this.colSalesLines.VisibleIndex = 2;
            this.colSalesLines.Width = 261;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(294, 472);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 92);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "조회";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(486, 472);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(186, 92);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "매출취소";
            // 
            // SalesCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 600);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "SalesCancelForm";
            this.Text = "SalesCancelForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesID;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesLines;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}