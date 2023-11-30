using Microsoft.EntityFrameworkCore;
using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using X.PagedList;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        public UsersRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public Task<IPagedList<User>> GetUsersAsync(string? query = null, int page = 1, int? cityId = null,
            CancellationToken cancellationToken = default)
        {
            return DbSet.Where(c => (query == null || c.FirstName.Contains(query) 
                                                   || c.LastName.Contains(query)
                                                   || c.BusinessEmail.Contains(query)
                                                   || c.Address.Contains(query)) 
                                    && (cityId == null || c.CityId == cityId)
                        ).ToPagedListAsync(page, PageSize);
        }

        public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await DbSet.FirstOrDefaultAsync(u => u.BusinessEmail == email, cancellationToken);
        }
    }
}
