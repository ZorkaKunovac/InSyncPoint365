using AutoMapper;
using FluentValidation;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.Country;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Application.Services
{
    public class CountriesService : BaseService<Country, CountryDTO, CountryAddDTO, CountryUpdateDTO>, ICountriesService
    {
        private readonly ICountriesRepository _countriesRepository;

        public CountriesService(ICountriesRepository repository, IMapper mapper, IValidator<CountryAddDTO> addValidator, IValidator<CountryUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
            _countriesRepository = repository;
        }

        public async Task<List<CountryCountsDTO>> GetWithCountAsync()
        {
            var countries = await _countriesRepository.GetWithCountAsync();

            return countries;
        }
    }
}
