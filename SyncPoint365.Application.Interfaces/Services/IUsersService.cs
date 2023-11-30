using SyncPoint365.Core.DTOs.User;
using X.PagedList;

namespace SyncPoint365.Application.Interfaces.Services
{
    public interface IUsersService : IBaseService<UserDTO, UserAddDTO, UserUpdateDTO>
    {
        Task<IPagedList<UserDTO>> GetUsersAsync(string? query = null, int page = 1, int? cityId = null, CancellationToken cancellationToken = default);
        Task<UserAuthDTO?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    }
}
