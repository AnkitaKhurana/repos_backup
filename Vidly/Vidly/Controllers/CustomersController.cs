using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("Customers/Customers")]

        // GET: Customers
        public ActionResult Index()
        {

            var customers = new List<Customer>()
            {
                new Customer {Name="Ankita"},
                new Customer {Name="Anki"}
            };
            var ViewModel = new CustomersViewModel()
            {
               
                Customers = customers
            };
            //return Content(ViewModel.Customers[0].Name);
            return View(ViewModel);
        }
    }
}