using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopping.Shared.DTOs
{
    public class ProductVariant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
