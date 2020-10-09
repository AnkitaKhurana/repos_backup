using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string Desc { get; set; }
        public int FavCount { get; set; }

        //[ForeignKey("User")]
        public Guid AuthorId { get; set; }
        public virtual User User { get; set; }

    }
}
