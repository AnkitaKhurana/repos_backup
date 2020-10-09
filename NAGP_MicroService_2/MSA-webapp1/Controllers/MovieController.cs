using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSA_webapp1.Models;
using Newtonsoft.Json;

namespace MSA_webapp1.Controllers
{
    public class MovieController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;
        public MovieController(IHttpClientFactory httpClientFactory)
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
            //var userClient = this.httpClientFactory.CreateClient("movieApi");
            var userClient = this.httpClientFactory.CreateClient("ApiClient");
            var response = await userClient.GetAsync("/api/movie");
            MovieModel[] data = JsonConvert.DeserializeObject<MovieModel[]>(await response.Content.ReadAsStringAsync());
            ActionResult retVal = View("~/Views/Movie/Details.cshtml", data);
            return retVal;
        }
    }
}