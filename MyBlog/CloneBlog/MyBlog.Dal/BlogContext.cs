using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Dal
{
    public class BlogContext:DbContext
    {
        //public Context(DbContextOptions<Context> op) : base(op)
        //{

        //}


        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyBlog;Trusted_Connection=True;");
        }
    }
}

