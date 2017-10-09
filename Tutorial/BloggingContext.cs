using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tutorial
{
    class BloggingContext : DbContext
    {
        public DbSet Blogs { get; set; }
        public DbSet Posts { get; set; }
    }
}
