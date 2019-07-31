using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pos.Data
{
    public class SalesData
    {
       
        public Sale InsertSale()
        {
            using(PosEntities context = new PosEntities())
            {
                var sale = new Sale();

                sale.SalesTime = DateTime.Now;

                context.Sales.Add(sale);

                context.SaveChanges();

                return sale; 
            }
        }
       
    }
}
