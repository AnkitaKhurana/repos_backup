using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.CustomModelBinder
{
    public class MyModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext )
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            int id = Convert.ToInt32(request.Form.Get("Id"));
            string name  =  request.Form.Get("Name");
            string genre = request.Form.Get("Genre");

            return new Movie()
            {
               Id = id,
               Name = name+" : Movie",
               Genre = genre
              
            };
        }
    }
}