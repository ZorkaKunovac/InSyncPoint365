using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.DTOs.VrstaKompetencije
{
    public class VrstaKompetencijeUpdateDTO:BaseUpdateDTO
    {
        public int CompanyId { get; set; }
        public string Naziv { get; set; } = default!;
    }
}
