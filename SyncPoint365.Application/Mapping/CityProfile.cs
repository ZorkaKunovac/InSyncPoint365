using AutoMapper;

using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Core.Entities;
using X.PagedList;

namespace SyncPoint365.Application.Mapping
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDTO>();
            CreateMap<CityAddDTO, City>();
            CreateMap<CityUpdateDTO, City>();
        }
    }
}
