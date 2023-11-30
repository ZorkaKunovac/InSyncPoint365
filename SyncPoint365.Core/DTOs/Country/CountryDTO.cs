using SyncPoint365.Core.DTOs.City;

namespace SyncPoint365.Core.DTOs.Country
{
    public class CountryDTO : BaseDTO
    {
        public string Name { get; set; } = default!;

        public ICollection<CityDTO> Cities { get; set; } = default!;
    }
}
