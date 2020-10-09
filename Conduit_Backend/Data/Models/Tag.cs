using System;
using System.ComponentModel.DataAnnotations.Schema;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }
        //[ForeignKey("User")]
        public Guid ArticleId { get; set; }
        public virtual User User { get; set; }
        public string Body { get; set;}
    }
}
