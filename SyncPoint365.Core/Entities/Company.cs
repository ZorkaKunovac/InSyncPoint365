namespace SyncPoint365.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public int VacationDays { get; set; }
        public string IdNumber { get; set; } = default!;
        public string VatNumber { get; set; } = default!;

        public int CityId { get; set; }
        public City City { get; set; } = default!;

        public string ZipCode { get; set; } = default!;
        public string? County { get; set; }
        public string? State { get; set; }

        public ICollection<User> Users { get; set; } = default!;
        public ICollection<VrstaKompetencije> VrstaKompetencija { get; set; } = default!;

    }
}
