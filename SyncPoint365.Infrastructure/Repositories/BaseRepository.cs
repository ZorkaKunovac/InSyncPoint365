using Microsoft.EntityFrameworkCore;

using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using X.PagedList;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected const int PageSize = 10;

        protected readonly DatabaseContext DatabaseContext;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
            DbSet = DatabaseContext.Set<TEntity>();
        }

        public virtual Task<IPagedList<TEntity>> GetAsync(string? query = null, int page = 1, CancellationToken cancellationToken = default)
        {
            return DbSet.ToPagedListAsync(page, PageSize);
        }

        public virtual Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return DbSet.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await DbSet.AddAsync(entity, cancellationToken);
        }

        public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            DatabaseContext.ChangeTracker.Clear();
            DbSet.Update(entity);
        }

        public virtual async Task RemoveByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            await DbSet.Where(u => u.Id == id).ExecuteDeleteAsync(cancellationToken);
        }

        public virtual async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await DatabaseContext.SaveChangesAsync(cancellationToken);
        }
    }
}
