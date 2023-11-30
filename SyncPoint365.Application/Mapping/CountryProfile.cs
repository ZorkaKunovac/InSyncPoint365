using AutoMapper;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.Country;

namespace SyncPoint365.Application.Mapping
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDTO>();
            CreateMap<CountryAddDTO, Country>();
            CreateMap<CountryUpdateDTO, Country>();
            CreateMap<Country, CountryCountsDTO>()
                .ForMember(d => d.Name, p => p.MapFrom(d => d.Name))
                .ForMember(d => d.NumberOfCities, p => p.MapFrom(d => d.Cities.Count()));
        }
    }
}
