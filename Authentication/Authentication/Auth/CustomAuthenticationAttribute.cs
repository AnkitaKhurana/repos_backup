using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Authentication.Auth
{
    public class CustomAuthenticationAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //For demo purpose only. In real life your custom principal might be retrieved via different source. i.e context/request etc.
            Console.Write(filterContext);
            Console.Write(filterContext.HttpContext.Session[""]);
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //var color = ((MyCustomPrincipal)filterContext.HttpContext.User).HairColor;
            //IPrincipal user = filterContext.HttpContext.User;

            var user = filterContext.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult(string.Format("/users/Login"));
                //filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}