using AutoMapper;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.AbsenceRequest;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using FluentValidation;
using SyncPoint365.Core.DTOs.City;

namespace SyncPoint365.Application.Services
{
    public class AbsenceRequestsService : BaseService<AbsenceRequest, AbsenceRequestDTO, AbsenceRequestAddDTO, AbsenceRequestUpdateDTO>, IAbsenceRequestsService
    {
        public AbsenceRequestsService(IAbsenceRequestsRepository repository, IMapper mapper, IValidator<AbsenceRequestAddDTO> addValidator, IValidator<AbsenceRequestUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
        }
    }
}
