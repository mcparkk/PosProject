using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    static class DataRepository
    {
        static DataRepository()
        {
            Menu = new MenuData();
            MenuCategory = new MenuCategoryData();
            Ingredient = new IngredientsData();
            IngredientsCategory = new IngredientsCategoryData();
            Order = new OrderData();
            OrderLine = new OrderLineData();
            Sales = new SalesData();
            SalesLine = new SalesLineData();
            Supplier = new SupplierData();
        }

        public static MenuData Menu { get; set; }
        public static MenuCategoryData MenuCategory { get; set; }
        public static IngredientsData Ingredient { get; set; }
        public static IngredientsCategoryData IngredientsCategory { get; set; }
        public static OrderData Order { get; set; }
        public static OrderLineData OrderLine { get; set; }
        public static SalesData Sales { get; set; }
        public static SalesLineData SalesLine { get; set; }
        public static SupplierData Supplier { get; set; }
    }
}
