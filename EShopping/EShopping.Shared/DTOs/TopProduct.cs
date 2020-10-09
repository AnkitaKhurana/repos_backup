using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopping.Shared.DTOs
{
    public class TopProduct
    {
        public int ID { get; set; }
        public int TotalSale { get; set; }
        public int ProductID { get; set; }
        public int ProductCategoryID { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
