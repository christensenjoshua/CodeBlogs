using CodeBlogs.Data;
using CodeBlogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlogs.Business
{
    public class BlogsService
    {
        private readonly BlogContext _context;

        public BlogsService(BlogContext context)
        {
            _context = context;
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }

        public Blog GetBlogById(int id)
        {
            return _context.Blogs.FirstOrDefault(x => x.Id == id);
        }

        public void CreateBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }
    }
}
