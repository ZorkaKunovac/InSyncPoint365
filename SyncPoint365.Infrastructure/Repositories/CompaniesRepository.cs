using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class CompaniesRepository : BaseRepository<Company>, ICompaniesRepository
    {
        public CompaniesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
