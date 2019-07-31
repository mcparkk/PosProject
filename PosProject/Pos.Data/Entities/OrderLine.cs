using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Data
{
    partial class OrderLine
    {
        public int LineId { get; set; }
        public string  SupplierName { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public int UnitPrice { get; set; }
        public string Name { get; set; }

    }
}
