using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random( )
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>()
            {
                new Customer {Name="Ankita"},
                new Customer {Name="Anki"}
            };

            // View data Dictionary ,used in first version
            //ViewData["Movie"] = movie;


            // NOT recommended !
            //ViewBag.Movie = movie;


            //ALSO TRY VIEW RESULT  

            var ViewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(ViewModel);
            //return Content("hello");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy="name"});

        }
        
        public ActionResult Edit(char id)
        {
            // In controllers 'id'is expected in url, can't change this param name
            return Content("id" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy) //? for making it nullable  in case of string it is automatically nullable 
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageindex = {0}&sortBy={1}", pageIndex, sortBy));

        }


        [Route("Movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]


        public ActionResult OrderByDate(int? year , int? month)
        {
            if (!year.HasValue)
            {
                year = 2018;
            }
            if (!month.HasValue)
            {
                month = 10;
            }
            return Content(String.Format("year  = {0}&month={1}", year, month));
        }


    }


    /* Result Types:
     
        ViewResult              View()
        PartialViewResult       PartialView()
        ContentResult           Content()
        Redirectresult          Redirect()
        RedirectToRouteresult   RedirectToAction()
        JsonResult              Json()
        FileResult              File()
        HttpNotFoundResult      HttpNotFound()
        EmptyResult          
       
     */
     
}