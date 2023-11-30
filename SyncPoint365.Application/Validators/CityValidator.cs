using System.Data;
using FluentValidation;

using SyncPoint365.Core.DTOs.City;

namespace SyncPoint365.Application.Validators
{
    public class CityAddValidator : AbstractValidator<CityAddDTO>
    {
        public CityAddValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("City name is not valid");
            RuleFor(c => c.CountryId).NotNull().GreaterThan(0).WithMessage("Country ID is not valid");
        }
    }


    public class CityUpdateValidator : AbstractValidator<CityUpdateDTO>
    {
        public CityUpdateValidator()
        {
            RuleFor(c => c.Id).NotNull().GreaterThan(0).WithMessage("ID is not valid");
            RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("City name is not valid");
            RuleFor(c => c.CountryId).NotNull().GreaterThan(0).WithMessage("Country ID is not valid");
        }
    }
}
