using EShopping.Shared.DTOs;
using EShopping.BLL.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Security;
using System.Net;
using EShopping.UI.ViewModels;

namespace EShopping.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        // Login: Customer
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login([Bind(Include = "ID,Email,Password")] CustomerDTO user)
        {
            if (ModelState.IsValid)
            {
                CustomerDTO findCustomer = new CustomerDTO() { Name = "Test", Email = "test", Password = "test", RoleId = 2 };
                //CustomerDTO findCustomer = null;
                // CustomerDTO finduser = db.Users.FirstOrDefault(e => e.Name.Equals(user.Name) && e.Password.Equals(user.Password));
                if (findCustomer != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, false);
                    FormsAuthentication.SetAuthCookie(user.RoleId.ToString(), false);

                    Console.Write(HttpContext.User.Identity.IsAuthenticated);
                }
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // Register: Customer
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CustomerDTO customer)
        {
            if (ModelState.IsValid)
            {
                Utils.RegisterBLL(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Users/Details/5
        [Authorize]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer user = new Customer() { Name = "Test", Email = "test", Password = "test", RoleId = 2 };
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //[ActionFilter]
        //public ActionResult Admin()
        //{
        //    string RoleID = Session["RoleID"];
        //    if(RoleID == "1")
        //    {
        //        return View(false);
        //    }
        //    return View(true);
        //}
    }
}