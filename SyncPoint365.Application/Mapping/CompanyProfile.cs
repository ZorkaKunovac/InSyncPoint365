using AutoMapper;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.Company;

namespace SyncPoint365.Application.Mapping
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDTO>();
            CreateMap<CompanyAddDTO, Company>();
            CreateMap<CompanyUpdateDTO, Company>();
        }
    }
}
