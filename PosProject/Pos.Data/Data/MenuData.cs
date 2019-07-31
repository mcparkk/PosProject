using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    public class MenuData
    {
        public Menu GetByName(string name)
        {
            using(PosEntities context = new PosEntities())
            {
                return context.Menus.FirstOrDefault(x => x.Name == name);
            }
        }

        
    }
}
