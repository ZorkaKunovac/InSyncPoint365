using X.PagedList;

namespace SyncPoint365.Infrastructure.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        Task<IPagedList<TEntity>> GetAsync(string? query = null, int page = 1, CancellationToken cancellationToken = default);
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task RemoveByIdAsync(int id, CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
