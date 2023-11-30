using SyncPoint365.Core.DTOs.Country;

namespace SyncPoint365.Application.Interfaces.Services
{
    public interface ICountriesService : IBaseService<CountryDTO, CountryAddDTO, CountryUpdateDTO>
    {
        Task<List<CountryCountsDTO>> GetWithCountAsync();
    }
}
