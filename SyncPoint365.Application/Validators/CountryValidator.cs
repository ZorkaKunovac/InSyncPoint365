using FluentValidation;

using SyncPoint365.Core.DTOs.Country;

namespace SyncPoint365.Application.Validators
{
    public class CountryAddValidator : AbstractValidator<CountryAddDTO>
    {
        public CountryAddValidator()
        {
        }
    }


    public class CountryUpdateValidator : AbstractValidator<CountryUpdateDTO>
    {
        public CountryUpdateValidator()
        {
        }
    }
}
