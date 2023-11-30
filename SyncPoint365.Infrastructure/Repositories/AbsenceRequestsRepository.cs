using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class AbsenceRequestsRepository : BaseRepository<AbsenceRequest>, IAbsenceRequestsRepository
    {
        public AbsenceRequestsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
