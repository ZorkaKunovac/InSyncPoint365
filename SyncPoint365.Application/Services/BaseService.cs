using AutoMapper;
using FluentValidation;
using X.PagedList;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Application.Services
{
    public abstract class BaseService<TEntity, TDTO, TAddDTO, TUpdateDTO> : IBaseService<TDTO, TAddDTO, TUpdateDTO>
    {
        protected readonly IBaseRepository<TEntity> Repository;
        protected readonly IMapper Mapper;
        protected readonly IValidator<TAddDTO> AddValidator;
        protected readonly IValidator<TUpdateDTO> UpdateValidator;

        protected BaseService(IBaseRepository<TEntity> repository, IMapper mapper, IValidator<TAddDTO> addValidator, IValidator<TUpdateDTO> updateValidator)
        {
            Repository = repository;
            Mapper = mapper;
            AddValidator = addValidator;
            UpdateValidator = updateValidator;
        }

        public virtual async Task<IPagedList<TDTO>> GetAsync(string? query = null, int page = 1, CancellationToken cancellationToken = default)
        {
            var pagedList = await Repository.GetAsync(query, page, cancellationToken);
            var entities = pagedList.ToList();
            var dtos = Mapper.Map<List<TDTO>>(entities);

            return new PagedList<TDTO>(pagedList, dtos);
        }

        public virtual async Task<TDTO?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await Repository.GetByIdAsync(id, cancellationToken);
            return Mapper.Map<TDTO?>(entity);
        }

        public virtual async Task AddAsync(TAddDTO dto, CancellationToken cancellationToken = default)
        {
            await AddValidator.ValidateAndThrowAsync(dto, cancellationToken);

            var entity = Mapper.Map<TEntity>(dto);
            await Repository.AddAsync(entity, cancellationToken);
            await Repository.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task UpdateAsync(TUpdateDTO dto, CancellationToken cancellationToken = default)
        {
            await UpdateValidator.ValidateAndThrowAsync(dto, cancellationToken);

            var entity = Mapper.Map<TEntity>(dto);
            await Repository.UpdateAsync(entity, cancellationToken);
            await Repository.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task RemoveByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            await Repository.RemoveByIdAsync(id, cancellationToken);
        }
    }
}
