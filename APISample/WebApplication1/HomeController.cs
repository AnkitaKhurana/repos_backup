using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;


namespace WebApplication1
{
    [RoutePrefix("Home")]
    public class HomeController : ApiController
    {
       
        [Route("GetID")]
        [HttpGet]       
        public int GetID()
        {
            return 1;
        }
    }
}