using FluentValidation;

using SyncPoint365.Core.DTOs.AbsenceRequest;

namespace SyncPoint365.Application.Validators
{
    public class AbsenceRequestAddValidator : AbstractValidator<AbsenceRequestAddDTO>
    {
        public AbsenceRequestAddValidator()
        {
        }
    }


    public class AbsenceRequestUpdateValidator : AbstractValidator<AbsenceRequestUpdateDTO>
    {
        public AbsenceRequestUpdateValidator()
        {
        }
    }
}
