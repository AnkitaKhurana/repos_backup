using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSA_webapp1.Models;
using Newtonsoft.Json;
using Polly.CircuitBreaker;

namespace MSA_webapp1.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;
        public UserController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public async Task<ActionResult> Details()
        {
            ActionResult retVal = null;
            //var userClient = this.httpClientFactory.CreateClient("userApi");
            var userClient = this.httpClientFactory.CreateClient("ApiClient");
            try
            {
                var response = await userClient.GetAsync("/api/user");
                UserModel[] data = JsonConvert.DeserializeObject<UserModel[]>(await response.Content.ReadAsStringAsync());
                retVal = View("~/Views/User/Details.cshtml", data);
            }
            catch(BrokenCircuitException e)
            {
                retVal = View("~/Views/Shared/Error.cshtml", new ErrorViewModel { RequestId = "CE001", Error = " Broken Circuit Exception: The circuit is now open. Please try again after a few minutes" });
            }          
            return retVal;
        }
    }
}