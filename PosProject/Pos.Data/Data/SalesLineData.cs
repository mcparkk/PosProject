using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    public class SalesLineData
    {
        public List<SalesLine> GetMenuData()
        {
            using (PosEntities context = new PosEntities())
            {
                Dictionary<int, string> MenuName = context.Menus.ToDictionary(x => x.MenuID, x => x.Name);
                Dictionary<int, int> MenuUnitPrice = context.Menus.ToDictionary(x => x.MenuID, x => x.UnitPrice);

                IQueryable<SalesLine> salesLines = from x in context.SalesLines
                                                   select x;

                foreach (var salesLine in salesLines)
                {
                    salesLine.MenuName = MenuName[salesLine.MenuID];
                    salesLine.MenuUnitPrice = MenuUnitPrice[salesLine.MenuID];
                }


                return salesLines.ToList();
            }
        }
        public void UpAndDownButtonClicked(DevExpress.XtraGrid.Views.Grid.GridView gridView, List<SalesLine> salesLines, bool upAndDown)
        {
            if (gridView.GetFocusedRow() == null)
                return;

            var quantity = (int)gridView.GetFocusedRowCellValue("Quantity");
            var menuname = (string)gridView.GetFocusedRowCellValue("MenuName");

            if (upAndDown == true)
                quantity++;
            else if (quantity != 0)
            {
                quantity--;
                if (quantity == 0)
                {
                    var selectLine = salesLines.FirstOrDefault(x => x.MenuName == menuname);
                    salesLines.Remove(selectLine);
                    gridView.RefreshData();
                    return;
                }
            }

            var line = salesLines.FirstOrDefault(x => x.MenuName == menuname);
            // 컬럼의 수량 & 토탈 
            line.Quantity = quantity;
            line.TotalPrice = quantity * line.MenuUnitPrice;
            // 업데이트 뷰

            gridView.RefreshData();

            // 업데이트 토탈

        }

        public void InsertSalesLine(List<SalesLine> salesLines)
        {
            using (PosEntities context = new PosEntities())
            {
                var sale = DataRepository.Sales.InsertSale();
                var salesID = sale.SalesID;
                
                foreach (var line in salesLines)
                {
                   
                    line.SalesID = salesID;
                    line.MenuID = DataRepository.Menu.GetByName(line.MenuName).MenuID;

                    context.SalesLines.Add(line);
                    context.SaveChanges();
                }

            }
        }
    }
}
