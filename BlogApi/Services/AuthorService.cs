using BlogApi.Models;
using BlogApi.Repositories.interfaces;
using BlogApi.Services.interfaces;

namespace BlogApi.Services
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        public AuthorService(IRepository<Author> repository) : base(repository)
        {
        }
    }
}
