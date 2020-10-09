using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Following
    {
        [Key]
        public Guid Id { get; set; }

        //[ForeignKey("User")]
        public Guid FollowerId { get; set; }
        public virtual User User { get; set; }

        //[ForeignKey("User2")]
        public Guid FollowingId { get; set; }
        public virtual User User2 { get; set; }

    }
}
