using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using Pos.Data;

namespace Pos.UI
{
    public partial class IngredientsOrder : DevExpress.XtraEditors.XtraForm
    {
        public IngredientsOrder()
        {
            InitializeComponent();
            grcOrder.DataSource = Orderlines;
        }

        private void TabButtonClicked(object sender, TabButton.TabButtonClickedEventArgs e)
        {
            //todo 이벤트 생성기로 넘어온 텍스트로 그리드 뷰 채우기 
            // grid control 내용 추가
            UpdateOrderLine(e.ButtonText);
        }

        
        private List<OrderLine> Orderlines = new List<OrderLine>();

        private void UpdateOrderLine(string name)
        {
            var existingLine = Orderlines.FirstOrDefault(x => x.Name == name);
            var orderLine = new OrderLine();
            var ingredient = DataRepository.Ingredient.GetByName(name);
            var supplier = DataRepository.Supplier.GetSupplier(ingredient.SupplierID);

            orderLine.LineId = Orderlines.Count;
            orderLine.Name = name;
            orderLine.Quantity++;
            orderLine.LineId++;
            orderLine.SupplierName = supplier.Name;
            orderLine.SupplierPhoneNumber = supplier.PhoneNumber;
            orderLine.UnitPrice = ingredient.UnitPrice;

            if (existingLine == null)
            {
                orderLine.Quantity = 1;
                orderLine.UnitPrice = ingredient.UnitPrice;
                orderLine.TotalPrice = orderLine.UnitPrice;
                Orderlines.Add(orderLine);
            }
            else
            {
                existingLine.Quantity++;
                existingLine.TotalPrice = existingLine.UnitPrice * existingLine.Quantity;
            }

            grvOrder.RefreshData();
        }

        

        
    }
}