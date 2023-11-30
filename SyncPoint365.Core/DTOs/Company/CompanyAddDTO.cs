namespace SyncPoint365.Core.DTOs.Company
{
    public class CompanyAddDTO : BaseAddDTO
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public int VacationDays { get; set; }
        public string IdNumber { get; set; } = default!;
        public string VatNumber { get; set; } = default!;

        public int CityId { get; set; }

        public string ZipCode { get; set; } = default!;
        public string? County { get; set; }
        public string? State { get; set; }
    }
}
