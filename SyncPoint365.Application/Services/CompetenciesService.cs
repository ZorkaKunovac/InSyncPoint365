using AutoMapper;
using FluentValidation;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Core.DTOs.Competency;
using SyncPoint365.Core.Entities;
using SyncPoint365.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Services
{
    public class CompetenciesService : BaseService<Competency, CompetencyDTO, CompetencyAddDTO, CompetencyUpdateDTO>, ICompetenciesService
    {
        public CompetenciesService(ICompetenciesRepository repository, IMapper mapper, IValidator<CompetencyAddDTO> addValidator, IValidator<CompetencyUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
        }
         
    }
}
