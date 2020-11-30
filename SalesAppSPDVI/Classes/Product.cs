using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppSPDVI
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        string ProductNumber { get; set; }
        public string Color { get; set; }
        public int ProductModelID { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
                return $"{ProductNumber} {Name} (Color -> {Color})";
        }
    }
}
