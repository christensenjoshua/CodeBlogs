using CodeBlogs.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeBlogs.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=CodeBlogs;
                Integrated Security=True");
        }
    }
}
