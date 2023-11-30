namespace SyncPoint365.Core.DTOs.City
{
    public class CityAddDTO : BaseAddDTO
    {
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
    }
}
