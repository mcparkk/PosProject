using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    public class IngredientsCategoryData
    {
        public List<string> GetAllNames()
        {
            using (var cont = new PosEntities())
            {
                var ingredients = cont.IngredientsCategories.Select(x => x);

                List<string> toReturn = new List<string>();

                foreach(var ingr in ingredients)
                {
                    toReturn.Add(ingr.Name);
                }

                return toReturn;
            }
        }

        public int GetIdByName(string name)
        {
            using (var context = new PosEntities())
            {
                return context.IngredientsCategories.FirstOrDefault(x => x.Name == name).IngredientCategoryID;
            }
        }
    }
}
