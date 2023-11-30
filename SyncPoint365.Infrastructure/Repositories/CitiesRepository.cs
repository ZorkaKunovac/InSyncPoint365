using Microsoft.EntityFrameworkCore;
using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using X.PagedList;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class CitiesRepository : BaseRepository<City>, ICitiesRepository
    {
        public CitiesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public override Task<IPagedList<City>> GetAsync(string? query = null, int page = 1, CancellationToken cancellationToken = default)
        {
            return DbSet.Include(c => c.Country).Where(c => query == null || c.Name.Contains(query) || c.Country.Name.Contains(query)).ToPagedListAsync(page, PageSize);
        }
    }
}
