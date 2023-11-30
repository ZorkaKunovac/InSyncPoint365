using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Core.DTOs.Competency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Interfaces.Services
{
    public interface ICompetenciesService : IBaseService<CompetencyDTO, CompetencyAddDTO, CompetencyUpdateDTO>
    {
    }
}
