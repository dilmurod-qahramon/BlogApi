using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAccess
{
    public class BlogDbContext(DbContextOptions<BlogDbContext> options) : DbContext(options)
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
