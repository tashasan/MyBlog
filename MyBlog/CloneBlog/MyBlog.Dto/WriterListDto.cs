using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Dto
{
    public  class WriterListDto
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string WriterName { get; set; }
        public string WriterLastName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Date { get; set; }
    }
}
