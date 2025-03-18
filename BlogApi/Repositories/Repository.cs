using BlogApi.DataAccess;
using BlogApi.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlogDbContext _blogDbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
            _dbSet = _blogDbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _blogDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _blogDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _blogDbContext.SaveChangesAsync();
        }
    }
}
