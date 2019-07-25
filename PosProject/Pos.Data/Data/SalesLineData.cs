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
            using(PosEntities context = new PosEntities())
            {
                Dictionary<int, string> MenuName = context.Menus.ToDictionary(x => x.MenuID, x => x.Name);
                Dictionary<int, int> MenuUnitPrice = context.Menus.ToDictionary(x => x.MenuID, x => x.UnitPrice);

                IQueryable<SalesLine> salesLines = from x in context.SalesLines
                                              select x;

                foreach(var salesLine in salesLines)
                {
                    salesLine.MenuName = MenuName[salesLine.MenuID];
                    salesLine.MenuUnitPrice = MenuUnitPrice[salesLine.MenuID];
                }

                
                return salesLines.ToList();
            }
        }
    }
}
