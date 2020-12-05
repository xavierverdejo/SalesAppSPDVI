using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppSPDVI
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string ProductModelName { get; set; }
        public string Description { get; set; }
        public string ListPrice { get; set; }

        public List<Product> Products = new List<Product>();
    }
}
