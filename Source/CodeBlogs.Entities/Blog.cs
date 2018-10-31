using System;
using System.Collections.Generic;

namespace CodeBlogs.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public ICollection<BlogComment> Comments { get; set; }
    }
}
