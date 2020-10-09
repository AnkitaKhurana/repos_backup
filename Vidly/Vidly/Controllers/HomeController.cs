using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie {Name="ABC", Genre = "Pop", Id=1},
                new Movie {Name="AYZ", Genre = "Rock ", Id=2},
                new Movie {Name = "failed", Genre = "failed", Id=0},            
                new Movie {Name = "PQR", Genre = "Romantic", Id=3}
            };

            var maxId  = movies.Max(movie  => movie.Id);
            var averageId = movies.Average(movie => movie.Id);
            var minId = movies.Min(movie => movie.Id);
            var count = movies.Capacity;
            var listOfPeopleWithA = movies.Where(movie => movie.Name.StartsWith("A"));
            var anyEqualOrlessZero = movies.Any(movie => movie.Id <= 0);
            System.Diagnostics.Debug.WriteLine("Min Id " + minId);
            System.Diagnostics.Debug.WriteLine("Max Id :"+maxId);
            System.Diagnostics.Debug.WriteLine("Average :" + averageId);
            System.Diagnostics.Debug.WriteLine("Capacity : " + count);
            foreach(Movie movie in listOfPeopleWithA)
            {
                System.Diagnostics.Debug.WriteLine(movie.Name);
            }
            System.Diagnostics.Debug.WriteLine("Any Zero : " + anyEqualOrlessZero);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}