using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.Country;

namespace SyncPoint365.Infrastructure.Interfaces.Repositories
{
    public interface ICountriesRepository : IBaseRepository<Country>
    {
        Task<List<CountryCountsDTO>> GetWithCountAsync();
    }
}
