using EShopping.Data.Models;
using EShopping.Shared.DTOs;
using System;
using EShopping.DAL.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopping.DAL.Customer
{
    public class Utils
    {
        private static EShoppingEntities db = new EShoppingEntities();

        public static bool Register(CustomerDTO customer)
        {
            try
            {
                 var DbCustomer = EShopping.DAL.Mapping.Map.MapToCustomer(customer);               
                 db.Customers.Add(DbCustomer);
                 db.SaveChanges();
            }
            catch 
            {
                return false;
            }
            return true;
        }
    }
}