using X.PagedList;

namespace SyncPoint365.Application.Interfaces.Services
{
    public interface IBaseService<TDTO, TAddDTO, TUpdateDTO>
    {
        Task<IPagedList<TDTO>> GetAsync(string? query = null, int page = 1, CancellationToken cancellationToken = default);
        Task<TDTO?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(TAddDTO dto, CancellationToken cancellationToken = default);
        Task UpdateAsync(TUpdateDTO dto, CancellationToken cancellationToken = default);
        Task RemoveByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
