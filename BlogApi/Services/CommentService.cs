using BlogApi.Models;
using BlogApi.Repositories.interfaces;
using BlogApi.Services.interfaces;

namespace BlogApi.Services
{
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IRepository<Comment> repository) : base(repository)
        {
        }
    }
}
