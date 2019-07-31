using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    public class IngredientsData
    {
        public List<string> GetNamesOfCategory(int categoryId)
        {
            using (var context = new PosEntities())
            {
                return context.Ingredients.Where(x => x.IngredientCategoryID == categoryId).Select(x => x.Name).ToList();
            }
        }

        public Ingredient GetByName(string name)
        {
            using (var context = new PosEntities())
            {
                return context.Ingredients.FirstOrDefault(x => x.Name == name);
            }
        }

        
    }
}
