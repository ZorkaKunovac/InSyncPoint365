using Microsoft.AspNetCore.Mvc;
using SyncPoint365.API.Helpers;
using SyncPoint365.Core.DTOs.AbsenceRequest;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorization(Role.Employee)]
    public class AbsenceRequestsController : BaseController<AbsenceRequestDTO, AbsenceRequestAddDTO, AbsenceRequestUpdateDTO>
    {
        public AbsenceRequestsController(IAbsenceRequestsService absenceRequestsService) : base(absenceRequestsService)
        {
        }
    }
}
