using AutoMapper;
using FluentValidation;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Application.Services
{
    public class CompaniesService : BaseService<Company, CompanyDTO, CompanyAddDTO, CompanyUpdateDTO>, ICompaniesService
    {
        public CompaniesService(ICompaniesRepository repository, IMapper mapper, IValidator<CompanyAddDTO> addValidator, IValidator<CompanyUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
        }
    }
}
