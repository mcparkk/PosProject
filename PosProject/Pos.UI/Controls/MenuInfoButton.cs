using Pos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.UI
{
    internal class MenuInfoButton : DevExpress.XtraEditors.SimpleButton
    {
        public Menu menu;

        public MenuInfoButton(string name, Menu menu)
        {
            Text = name;
            if (DesignMode)
                return;
            this.menu = menu;
        }

        public MenuInfoButton() : base()
        {

        }
    }
}
