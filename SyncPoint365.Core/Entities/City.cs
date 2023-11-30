namespace SyncPoint365.Core.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int CountryId { get; set; }
        public Country Country { get; set; } = default!;

        public ICollection<User> Users { get; set; } = default!;
        public ICollection<Company> Companies { get; set; } = default!;
    }
}
