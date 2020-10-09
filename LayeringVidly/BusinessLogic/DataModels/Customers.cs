using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic.DataModels
{
    public class Customers
    {
        public List<Customer> AllCustomers;
        public Customers()
        {
            AllCustomers = new List<Customer>();
        }
    }
}
