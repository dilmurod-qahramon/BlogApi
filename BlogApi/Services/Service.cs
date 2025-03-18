using BlogApi.Repositories.interfaces;
using BlogApi.Services.interfaces;

namespace BlogApi.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<T> GetByIdAsync(Guid id) => await _repository.GetByIdAsync(id);
        public async Task<T> CreateAsync(T entity) => await _repository.CreateAsync(entity);
        public async Task UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id) 
                ?? throw new ArgumentNullException(nameof(id));
            await _repository.DeleteAsync(entity);
        }
    }
}
