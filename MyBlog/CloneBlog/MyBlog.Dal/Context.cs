using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Dal
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> db): base(db)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
