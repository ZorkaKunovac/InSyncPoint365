using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.API.Helpers;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorization(Role.SuperAdministrator)]
    public class CitiesController : BaseController<CityDTO, CityAddDTO, CityUpdateDTO>
    {
        public CitiesController(ICitiesService citiesService) : base(citiesService)
        {
        }
    }
}
