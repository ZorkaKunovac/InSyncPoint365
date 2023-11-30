using AutoMapper;
using X.PagedList;
using FluentValidation;
using SyncPoint365.Application.Helpers;
using SyncPoint365.Core.Entities;
using SyncPoint365.Core.DTOs.User;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Application.Services
{
    public class UsersService : BaseService<User, UserDTO, UserAddDTO, UserUpdateDTO>, IUsersService
    {
        private readonly IUsersRepository _repository;

        public UsersService(IUsersRepository repository, IMapper mapper, IValidator<UserAddDTO> addValidator, IValidator<UserUpdateDTO> updateValidator) : base(repository, mapper, addValidator, updateValidator)
        {
            _repository = repository;
        }

        public async Task<IPagedList<UserDTO>> GetUsersAsync(string? query = null, int page = 1, int? cityId = null, CancellationToken cancellationToken = default)
        {
            var pagedList = await _repository.GetUsersAsync(query, page, cityId, cancellationToken);
            var entities = pagedList.ToList();
            var dtos = Mapper.Map<List<UserDTO>>(entities);

            return new PagedList<UserDTO>(pagedList, dtos);
        }

        public async Task<UserAuthDTO?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            var user = await _repository.GetByEmailAsync(email, cancellationToken);
            return Mapper.Map<UserAuthDTO>(user);
        }

        public override async Task AddAsync(UserAddDTO dto, CancellationToken cancellationToken = default)
        {
            await AddValidator.ValidateAndThrowAsync(dto, cancellationToken);

            var entity = Mapper.Map<User>(dto);

            entity.PasswordSalt = Cryptography.GenerateSalt();
            entity.PasswordHash = Cryptography.GenerateHash(dto.Password, entity.PasswordSalt);

            await Repository.AddAsync(entity, cancellationToken);
            await Repository.SaveChangesAsync(cancellationToken);
        }

        public override async Task UpdateAsync(UserUpdateDTO dto, CancellationToken cancellationToken = default)
        {
            await UpdateValidator.ValidateAndThrowAsync(dto, cancellationToken);

            var entity = Mapper.Map<User>(dto);

            if (dto.Password != null)
            {
                entity.PasswordSalt = Cryptography.GenerateSalt();
                entity.PasswordHash = Cryptography.GenerateHash(dto.Password, entity.PasswordSalt);
            }

            await Repository.UpdateAsync(entity, cancellationToken);
            await Repository.SaveChangesAsync(cancellationToken);
        }
    }
}
