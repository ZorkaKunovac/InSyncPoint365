using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Core.DTOs.Competency;
using SyncPoint365.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.DTOs.VrstaKompetencije
{
    public class VrstaKompetencijeDTO : BaseDTO
    {

        public int CompanyId { get; set; }
        public CompanyDTO Company { get; set; } = default!;

        public string Naziv { get; set; } = default!;

        public ICollection<CompetencyDTO> Competencies { get; set; } = default!;
    }
}
