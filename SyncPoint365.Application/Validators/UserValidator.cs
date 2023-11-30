using FluentValidation;

using SyncPoint365.Core.DTOs.User;

namespace SyncPoint365.Application.Validators
{
    public class UserAddValidator : AbstractValidator<UserAddDTO>
    {
        public UserAddValidator()
        {
        }
    }


    public class UserUpdateValidator : AbstractValidator<UserUpdateDTO>
    {
        public UserUpdateValidator()
        {
        }
    }
}
