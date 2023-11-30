using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Core.DTOs.User;

namespace SyncPoint365.Core.DTOs.Company
{
    public class CompanyDTO : BaseDTO
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public int VacationDays { get; set; }
        public string IdNumber { get; set; } = default!;
        public string VatNumber { get; set; } = default!;

        public int CityId { get; set; }
        public CityDTO City { get; set; } = default!;

        public string ZipCode { get; set; } = default!;
        public string? County { get; set; }
        public string? State { get; set; }

        public ICollection<UserDTO> Users { get; set; } = default!;
    }
}
