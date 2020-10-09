using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopping.Shared.DTOs;
using EShopping.DAL;
using test = EShopping.DAL.Customer.Utils;

namespace EShopping.BLL.Customer
{
    public class Utils
    {

        //public static List<Customer> GetAllCustomers()
        //{
        //    var list = db.Customers.ToList();
        //    return list;
        //}

        public static bool RegisterBLL(CustomerDTO customer)
        {
            try
            {
                var saved = test.Register(customer);
                return saved;
            }
            catch (Exception)
            {
                return false;
            }
          
        }
    }
}
