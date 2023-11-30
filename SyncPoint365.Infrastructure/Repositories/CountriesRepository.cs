using Microsoft.EntityFrameworkCore;
using SyncPoint365.Core.DTOs.Country;
using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Infrastructure.Repositories
{
    public class CountriesRepository : BaseRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public Task<List<CountryCountsDTO>> GetWithCountAsync()
        {
            return DbSet.Include(c => c.Cities).Select(c => new CountryCountsDTO
            {
                Name = c.Name,
                NumberOfCities = c.Cities.Count()
            }).ToListAsync();
        }
    }
}
