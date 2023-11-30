using AutoMapper;

using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.AbsenceRequest;

namespace SyncPoint365.Application.Mapping
{
    public class AbsenceRequestProfile : Profile
    {
        public AbsenceRequestProfile()
        {
            CreateMap<AbsenceRequest, AbsenceRequestDTO>();
            CreateMap<AbsenceRequestAddDTO, AbsenceRequest>();
            CreateMap<AbsenceRequestUpdateDTO, AbsenceRequest>();
        }
    }
}
