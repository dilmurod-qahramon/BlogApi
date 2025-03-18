using BlogApi.DataAccess;
using BlogApi.Models;
using BlogApi.Repositories.interfaces;

namespace BlogApi.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public AuthorRepository(BlogDbContext blogDbContext) : base(blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
    }
}
