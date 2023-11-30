using FluentValidation;
using SyncPoint365.Core.DTOs.VrstaKompetencije;
using SyncPoint365.Core.DTOs.VrstaKompetencije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Validators
{
    public class VrstaKompetencijeValidator : AbstractValidator<VrstaKompetencijeAddDTO>
    {
        public VrstaKompetencijeValidator()
        {
            RuleFor(c => c.Naziv).NotNull().NotEmpty().WithMessage("Competency name is not valid");
            RuleFor(c => c.CompanyId).NotNull().GreaterThan(0).WithMessage("Company ID is not valid");
        }
     }
    public class VrstaKompetencijeUpdateValidator : AbstractValidator<VrstaKompetencijeUpdateDTO>
    {
        public VrstaKompetencijeUpdateValidator()
        {
            RuleFor(c => c.Naziv).NotNull().NotEmpty().WithMessage("Competency name is not valid");
            RuleFor(c => c.CompanyId).NotNull().GreaterThan(0).WithMessage("Company ID is not valid");
        }
    }
}
