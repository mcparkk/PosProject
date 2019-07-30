using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pos.Data
{
    public class SalesData
    {
        public void UpAndDownButtonClicked(DevExpress.XtraGrid.Views.Grid.GridView gridView, List<SalesLine> salesLines ,bool upAndDown)
        {
            if (gridView.GetFocusedRow() == null)
                return;

            var quantity = (int)gridView.GetFocusedRowCellValue("Quantity");
            var menuname = (string)gridView.GetFocusedRowCellValue("MenuName");
            if (upAndDown == true)
                quantity++;
            else if(quantity != 0)
                quantity--;

            var line = salesLines.FirstOrDefault(x => x.MenuName == menuname);
            // 컬럼의 수량 & 토탈 
            line.Quantity = quantity;
            line.TotalPrice = quantity * line.MenuUnitPrice;
            // 업데이트 뷰

            gridView.RefreshData();

            // 업데이트 토탈
           
        }
    }
}
