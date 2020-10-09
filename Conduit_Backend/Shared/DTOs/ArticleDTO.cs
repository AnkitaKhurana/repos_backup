using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class ArticleDTO
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string Desc { get; set; }
        public int FavCount { get; set; }
        public virtual UserDTO Author { get; set; }

    }
}
