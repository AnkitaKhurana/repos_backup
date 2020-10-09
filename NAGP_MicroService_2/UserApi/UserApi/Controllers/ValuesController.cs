using Microsoft.AspNetCore.Mvc;
using System;

namespace Eureka_Client_DotNet.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    { 

        // GET api/values/5
        [HttpGet("/api/user")]
        public ActionResult<string> UserApi()
        {
            string data = "[{\"id\":1,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":2,\"firstname\":\"jane\",\"lastname\":\"smdoeith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":3,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"},{\"id\":4,\"firstname\":\"John\",\"lastname\":\"smith\",\"address\":\"35 avenue road\",\"contact\":\"1125-4569873\",\"email\":\"john.smith@example.com\"}]";
            return data;
        }

         

    }
}
