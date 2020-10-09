using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;

namespace DataAccessLayer
{
    public static class Util 
    {
        private static CustomerContext db = new CustomerContext();

        public static List<Customer> GetAllCustomers()
        {
            var list = db.Customers.ToList();
            return list;
        }

        public static bool AddNewCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool EditCustomer(Customer customer)
        {
            try
            {
                var std = db.Customers.Find(customer.Id);
                std.Name = customer.Name;
                std.Age = customer.Age;
                db.SaveChanges();
                //db.Entry(customer).State = EntityState.Modified;
                //db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Customer FindCustomer(int? id)
        {
            return db.Customers.Find(id);
        }
    }
}
