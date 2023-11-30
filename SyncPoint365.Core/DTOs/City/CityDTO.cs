namespace SyncPoint365.Core.DTOs.City
{
    public class CityDTO : BaseDTO
    {
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
    }
}
