using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Data.Models 
{
    public class ConduitContext : DbContext
    {
        public ConduitContext() : base("ConduitContext")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Following> Following {get ; set ;}
        public virtual DbSet<Favorite> Favorites { get; set; }

    }
}
