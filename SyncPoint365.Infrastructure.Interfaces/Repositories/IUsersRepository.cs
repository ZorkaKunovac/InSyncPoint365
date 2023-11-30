using SyncPoint365.Core.Entities;
using X.PagedList;

namespace SyncPoint365.Infrastructure.Interfaces.Repositories
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        Task<IPagedList<User>> GetUsersAsync(string? query = null, int page = 1, int? cityId = null, CancellationToken cancellationToken = default);
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    }
}
