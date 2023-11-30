using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class VrstaKompetencijaRepository : BaseRepository<VrstaKompetencije>, IVrstaKompetencijaRepository
    {
        public VrstaKompetencijaRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
