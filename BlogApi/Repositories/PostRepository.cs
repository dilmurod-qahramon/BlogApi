using BlogApi.DataAccess;
using BlogApi.Models;
using BlogApi.Repositories.interfaces;

namespace BlogApi.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(BlogDbContext blogDbContext) : base(blogDbContext)
        {
        }
    }
}
