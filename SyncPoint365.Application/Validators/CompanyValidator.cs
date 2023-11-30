using FluentValidation;

using SyncPoint365.Core.DTOs.Company;

namespace SyncPoint365.Application.Validators
{
    public class CompanyAddValidator : AbstractValidator<CompanyAddDTO>
    {
        public CompanyAddValidator()
        {
        }
    }


    public class CompanyUpdateValidator : AbstractValidator<CompanyUpdateDTO>
    {
        public CompanyUpdateValidator()
        {
        }
    }
}
