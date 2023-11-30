using AutoMapper;

using SyncPoint365.Core.DTOs.User;
using SyncPoint365.Core.Entities;

namespace SyncPoint365.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(d => d.FullName, o => o.MapFrom(e => e.FirstName + " " + e.LastName));

            CreateMap<User, UserAuthDTO>()
                .ForMember(d => d.FullName, o => o.MapFrom(e => e.FirstName + " " + e.LastName));

            CreateMap<UserAddDTO, User>();
            CreateMap<UserUpdateDTO, User>();
        }
    }
}
