using MyBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Writer:Base
    {
        public Writer()
        {
            Blogs = new HashSet<Blog>();
        }

        public string WriterName { get; set; }
        public string WriterLastName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
       
        public ICollection<Blog> Blogs { get; set; }
    }
}
