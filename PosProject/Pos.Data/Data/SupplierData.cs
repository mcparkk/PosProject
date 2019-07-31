using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    public class SupplierData
    {
        public string GetSupplierName(int ingredientsId)
        {
            using (var context = new PosEntities())
            {
                var supplierId = context.Ingredients.FirstOrDefault(x => x.IngredientsID == ingredientsId).SupplierID;
                return context.Suppliers.FirstOrDefault(x => x.SupplierID == supplierId).Name;
            }
        }

        public Supplier GetSupplier(int supplierId)
        {
            using (var context = new PosEntities())
            {
                
                return context.Suppliers.FirstOrDefault(x => x.SupplierID == supplierId);
            }
        }
    }
}
