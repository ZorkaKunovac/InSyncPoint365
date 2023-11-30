using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Core.Entities
{
    public class Competency:BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = default!;

        public int VrstaKompetencijeId { get; set; }
        public VrstaKompetencije VrstaKompetencije { get; set; } = default!;

        public int CountryID { get; set; }
        public Country Country { get; set; } = default!;

        public string Naziv { get; set; } = default!;
        public string Komentar { get; set; } = default!;
        public int? Ocjena { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }


    }
}
