using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               "MyName",
               "Ankita/Index",
                new { controller = "AnkitaController", action = "Index"}
           );
            routes.MapMvcAttributeRoutes();
           

            //routes.MapRoute(
            //      "MoviesByReleaseDate",
            //       "Movies/release/{year}/{month}",
            //        new { controller = "Movies", action = "OrderByDate" },
            //        new { year = @"\d{4}", month = @"\d{2}" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
