using System.ComponentModel.DataAnnotations;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.Core.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SocialSecurityNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; } = default!;
        public string Nationality { get; set; } = default!;
        public string ContractNumber { get; set; } = default!;
        public string BusinessEmail { get; set; } = default!;
        public string? PrivateEmail { get; set; }
        public string PasswordHash { get; set; } = default!;
        public string PasswordSalt { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public int VacationDays { get; set; }
        public string Department { get; set; } = default!;
        public string BusinessUnit { get; set; } = default!;
        public string Position { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string? Municipality { get; set; }
        
        public int CityId { get; set; }
        public City City { get; set; } = default!;

        public string ZipCode { get; set; } = default!;
        public string? County { get; set; }
        public string? State { get; set; }

        public Role Role { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public ICollection<AbsenceRequest> AbsenceRequests { get; set; } = default!;
        public ICollection<Competency> Competencies { get; set; } = default!;

    }
}
