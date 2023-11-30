using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Core.DTOs.Country;
using SyncPoint365.Core.DTOs.User;
using SyncPoint365.Core.DTOs.VrstaKompetencije;
using SyncPoint365.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.DTOs.Competency
{
    public class CompetencyDTO:BaseDTO
    {
        public int UserId { get; set; }
        public UserDTO User { get; set; } = default!;
        
        public int VrstaKompetencijeId { get; set; }
        public VrstaKompetencijeDTO VrstaKompetencije { get; set; } = default!;

        public int CountryID { get; set; }
        public CountryDTO Country { get; set; } = default!;

 

        public string Naziv { get; set; } = default!;
        public string Komentar { get; set; } = default!;
        public int? Ocjena { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }

    }
}
