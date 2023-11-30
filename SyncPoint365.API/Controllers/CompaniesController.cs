using Microsoft.AspNetCore.Mvc;
using SyncPoint365.API.Helpers;
using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorization(Role.SuperAdministrator)]
    public class CompaniesController : BaseController<CompanyDTO, CompanyAddDTO, CompanyUpdateDTO>
    {
        public CompaniesController(ICompaniesService companiesService) : base(companiesService)
        {
        }
    }
}
