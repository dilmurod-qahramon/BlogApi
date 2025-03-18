using BlogApi.Models;
using BlogApi.Repositories.interfaces;
using BlogApi.Services.interfaces;

namespace BlogApi.Services
{
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IRepository<Post> repository) : base(repository)
        {
        }
    }
}
