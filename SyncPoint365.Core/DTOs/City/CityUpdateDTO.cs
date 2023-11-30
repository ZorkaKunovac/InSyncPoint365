namespace SyncPoint365.Core.DTOs.City
{
    public class CityUpdateDTO : BaseUpdateDTO
    {
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
    }
}
