using AutoMapper;
using SyncPoint365.Core.DTOs.VrstaKompetencije;
using SyncPoint365.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Mapping
{
    public class VrstaKompetencijeProfile:Profile
    {
        VrstaKompetencijeProfile()
        {
            CreateMap<VrstaKompetencije, VrstaKompetencijeDTO>();
            CreateMap<VrstaKompetencijeAddDTO, VrstaKompetencije>();
            CreateMap<VrstaKompetencijeUpdateDTO, VrstaKompetencije>();
        }
    }
}
