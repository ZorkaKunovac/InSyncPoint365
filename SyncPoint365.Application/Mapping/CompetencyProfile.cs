using AutoMapper;
using SyncPoint365.Core.DTOs.Competency;
using SyncPoint365.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Mapping
{
    public class CompetencyProfile : Profile
    {
        CompetencyProfile()
        {
            CreateMap<Competency, CompetencyDTO>();
            CreateMap<CompetencyAddDTO, Competency>();
            CreateMap<CompetencyUpdateDTO, Competency>();
        }

    }
}
