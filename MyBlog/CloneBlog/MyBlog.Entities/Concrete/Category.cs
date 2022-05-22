using MyBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Category:Base
    {
        
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public Blog Blogs { get; set; }
    }
}
