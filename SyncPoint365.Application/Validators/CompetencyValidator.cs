using FluentValidation;
using SyncPoint365.Core.DTOs.Competency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.Application.Validators
{
    public class CompetencyValidator
    {
        public class CompetencyAddValidator : AbstractValidator<CompetencyAddDTO>
        {
            public CompetencyAddValidator()
            {
                RuleFor(c => c.Naziv).NotNull().NotEmpty().WithMessage("Competency name is not valid");
                RuleFor(c => c.UserId).NotNull().GreaterThan(0).WithMessage("UserId is not valid");
                RuleFor(c => c.VrstaKompetencijeId).NotNull().GreaterThan(0).WithMessage("VrstaKompetencijeId is not valid");
                RuleFor(c => c.CountryId).NotNull().GreaterThan(0).WithMessage("Country ID is not valid");
                RuleFor(c => c.Komentar).NotNull().NotEmpty().WithMessage("Komentar is not valid");
            }
        }

        public class CompetencyUpdateValidator : AbstractValidator<CompetencyUpdateDTO>
        {
            public CompetencyUpdateValidator()
            {
                RuleFor(c => c.Id).NotNull().GreaterThan(0).WithMessage("ID is not valid");
                RuleFor(c => c.Naziv).NotNull().NotEmpty().WithMessage("Competency name is not valid");
                RuleFor(c => c.UserId).NotNull().GreaterThan(0).WithMessage("UserId is not valid");
                RuleFor(c => c.VrstaKompetencijeId).NotNull().GreaterThan(0).WithMessage("VrstaKompetencijeId is not valid");
                RuleFor(c => c.CountryId).NotNull().GreaterThan(0).WithMessage("Country ID is not valid");
            }
        }

    }
}
