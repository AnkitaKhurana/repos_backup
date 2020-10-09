using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Favorite
    {
        [Key]
        public Guid Id { get; set; }
        //[ForeignKey("User")]
        Guid UserId { get; set; }
        public virtual User User { get; set; }

        //[ForeignKey("Article")]
        Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }

    }
}
