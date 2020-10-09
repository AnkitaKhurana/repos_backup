using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopping.Shared.DTOs
{
    public class Cart
    {
        public int ID { get; set; }
        public int CartStatusID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual CartLine CartLine { get; set; }
        public virtual CustomerDTO Customer { get; set; }
    }
}
