using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.Entities
{
    public class VrstaKompetencije:BaseEntity
    {

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public string Naziv { get; set; }

        public ICollection<Competency> Competencies { get; set; } = default!;

    }
}
