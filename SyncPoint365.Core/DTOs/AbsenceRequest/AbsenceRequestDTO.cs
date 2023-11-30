using SyncPoint365.Core.Enums;
using SyncPoint365.Core.DTOs.User;

namespace SyncPoint365.Core.DTOs.AbsenceRequest
{
    public class AbsenceRequestDTO : BaseDTO
    {
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? DateReturn { get; set; }
        public string Type { get; set; } = default!;
        public string? PreComment { get; set; }
        public string? PostComment { get; set; }
        public AbsenceRequestStatus Status { get; set; }

        public int UserId { get; set; }
        public UserDTO User { get; set; } = default!;
    }
}
