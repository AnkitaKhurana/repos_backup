using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Syntax.Models
{
    public class User
    {

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        List<Article> Articles { get; set; }

    }
}