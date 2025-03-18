using BlogApi.DataAccess;
using BlogApi.Models;
using BlogApi.Repositories.interfaces;

namespace BlogApi.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogDbContext blogDbContext) : base(blogDbContext)
        {
        }
    }
}
