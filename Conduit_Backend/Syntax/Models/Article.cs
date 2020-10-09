using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Syntax.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        string Slug { get; set; }
        string Desc { get; set; }
        int FavCount { get; set; }
        public virtual User Author { get; set; }
    }
}