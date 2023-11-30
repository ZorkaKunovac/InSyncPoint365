using Microsoft.AspNetCore.Mvc;

using SyncPoint365.Core.DTOs.Country;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.API.Helpers;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorization(Role.SuperAdministrator)]
    public class CountriesController : BaseController<CountryDTO, CountryAddDTO, CountryUpdateDTO>
    {
        private readonly ICountriesService _countriesService;

        public CountriesController(ICountriesService countriesService) : base(countriesService)
        {
            _countriesService = countriesService;
        }

        [HttpGet("Counts")]
        public async Task<IActionResult> GetWithCount()
        {
            var countries = await _countriesService.GetWithCountAsync();

            return Ok(countries);
        }
    }
}
