using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; } 
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //[ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        //[ForeignKey("Article")]
        public Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }


    }
}
