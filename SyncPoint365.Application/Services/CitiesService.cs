using AutoMapper;
using FluentValidation;
using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Application.Services
{
    public class CitiesService : BaseService<City, CityDTO, CityAddDTO, CityUpdateDTO>, ICitiesService
    {
        public CitiesService(ICitiesRepository repository, IMapper mapper, IValidator<CityAddDTO> addValidator, IValidator<CityUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
        }
    }
}
