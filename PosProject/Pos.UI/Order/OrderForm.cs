﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pos.Data;
using System.Data.Entity;
using System.Collections;

namespace Pos.UI
{
    public partial class OrderForm : XtraForm
    {
        public const string DefaultValue = "0";

        public OrderForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Pos.Data.PosEntities dbContext = new Pos.Data.PosEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.SalesLines.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                dbsSalesLines.DataSource = dbContext.SalesLines.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }



        List<SalesLine> salesLines = new List<SalesLine>();
        //리스트뷰에 정보


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GrcSales.DataSource = salesLines;
            tmrCurrentTime.Start();
            tmrCurrentTime.Tick += new EventHandler(NowTimeUpdate);

        }

        private void NowTimeUpdate(object sender, EventArgs e)
        {
            lblNowTime.Text = DateTime.Now.ToString();
        }

        private void MenuButtonClicked(object sender, EventArgs e)
        {
            var menu = DataRepository.Menu.GetByName(((SimpleButton)sender).Text.ToString());
            var salesLine = new SalesLine();
            // 새로 들어갈 라인
            salesLine.MenuName = menu.Name;
            salesLine.MenuUnitPrice = menu.UnitPrice;

            // 중복된 이름이 없을경우
            var existingSalesLine = salesLines.FirstOrDefault(x => x.MenuName == salesLine.MenuName);

            if (existingSalesLine == null)
            {
                salesLine.Quantity++;
                salesLine.TotalPrice = salesLine.MenuUnitPrice;
                salesLines.Add(salesLine);
            }
            else
            { 
                existingSalesLine.Quantity++;
                existingSalesLine.TotalPrice = existingSalesLine.MenuUnitPrice * existingSalesLine.Quantity;
                // 있음
                // quantity ++
            }

            GrvSales.RefreshData();

            UpdateLblTotalText();

        }

        private void NumberBottonClicked(object sender, EventArgs e)
        {
            if ((txbReceivedMoney.Text.ToString()) == "0")
            {
                var text = ((SimpleButton)sender).Text.ToString();
                if (text == "0" || text == "00")
                    return;
                txbReceivedMoney.Text = text;
                return;
            }

            var number = ((SimpleButton)sender).Text.ToString();

            txbReceivedMoney.Text += number;
        }

        private void BackSpaceButtonClicked(object sender, EventArgs e)
        {
            if (txbReceivedMoney.Text.Length == 1)
            {
                txbReceivedMoney.Text = "0";
                return;
            }
            else if (txbReceivedMoney.Text.Length > 0)
            {
                txbReceivedMoney.Text = txbReceivedMoney.Text.Remove(txbReceivedMoney.Text.Length - 1, 1);
            }
        }

        private void GrvSales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var quantity = (int)GrvSales.GetRowCellValue(GrvSales.FocusedRowHandle, GrvSales.FocusedColumn);
            var menuName = (string)GrvSales.GetRowCellValue(GrvSales.FocusedRowHandle, GrvSales.Columns.ColumnByFieldName("MenuName"));

            // list update
            var line = salesLines.FirstOrDefault(x => x.MenuName == menuName);
            line.Quantity = quantity;
            line.TotalPrice = quantity * line.MenuUnitPrice;

            // update view & total


            GrvSales.RefreshData();

            //업데이트 토탈
            UpdateLblTotalText();
        }

        private void UpButtonClicked(object sender, EventArgs e)
        {
            // 선택된 컬럼


            DataRepository.SalesLine.UpAndDownButtonClicked(GrvSales, salesLines, true);

            // 업데이트 토탈
            UpdateLblTotalText();

        }

        private void DownButtonClicked(object sender, EventArgs e)
        {

            DataRepository.SalesLine.UpAndDownButtonClicked(GrvSales, salesLines, false);

            // 업데이트 토탈
            UpdateLblTotalText();
        }

        private void UpdateLblTotalText()
        {
            int sum = 0;
            foreach (var salesline in salesLines)
            {
                sum += salesline.TotalPrice;
            }
            txbTotalPrice.Text = sum.ToString();

        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {

            salesLines.RemoveRange(0, salesLines.Count());

            GrvSales.RefreshData();

            txbTotalPrice.Text = DefaultValue;

        }

        private void OrderComplateButtonClicked(object sender, EventArgs e)
        {


            // 그리드 뷰의 정보 db에 전송하여 SalesLine row 생성 & sales row 생성 
            DataRepository.SalesLine.InsertSalesLine(salesLines);


            CancelButtonClicked(sender, e);

            ////salesLines 초기화
            //salesLines.RemoveRange(0, salesLines.Count());
            
            //// 그리드 뷰 초기화 
            //GrvSales.RefreshData();

            //// 텍스트 박스 초기화 
            //txbTotalPrice.Text = DefaultValue;

        }


    }
}