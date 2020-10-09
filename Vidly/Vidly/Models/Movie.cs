using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[ReadOnly(true)]
        public string Genre { get; set; }
        // shortcut to add prop : 'prop' + TAB
    }
}