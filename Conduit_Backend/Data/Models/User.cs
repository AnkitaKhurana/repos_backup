using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public User()
        {
            this.Articles = new List<Article>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
