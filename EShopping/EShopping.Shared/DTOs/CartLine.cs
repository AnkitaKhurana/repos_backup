using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Shared.DTOs
{
    public class CartLine
    {
        public CartLine()
        {
            this.Carts = new HashSet<Cart>();
        }

        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual CustomerDTO Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
