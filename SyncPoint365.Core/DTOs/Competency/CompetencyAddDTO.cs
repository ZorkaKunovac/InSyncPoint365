using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.DTOs.Competency
{
    public class CompetencyAddDTO: BaseAddDTO
    {
        public int UserId { get; set; }
        public int VrstaKompetencijeId { get; set; }
        public int CountryId { get; set; }
 
        public string Naziv { get; set; } = default!;
        public string Komentar { get; set; } = default!;
        public int? Ocjena { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
    }
}
