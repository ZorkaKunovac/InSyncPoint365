using FluentValidation;
using Microsoft.AspNetCore.Mvc;

using SyncPoint365.Core.DTOs;
using SyncPoint365.Application.Interfaces.Services;
using X.PagedList;

namespace SyncPoint365.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TDTO, TAddDTO, TUpdateDTO> : ControllerBase
    where TDTO : BaseDTO
    {
        protected readonly IBaseService<TDTO, TAddDTO, TUpdateDTO> Service;

        public BaseController(IBaseService<TDTO, TAddDTO, TUpdateDTO> service)
        {
            Service = service;
        }

        [HttpGet("Paged/{page}")]
        public async Task<IActionResult> GetPaged(string? query = null, int page = 1, CancellationToken cancellationToken = default)
        {
            var pagedList = await Service.GetAsync(query, page, cancellationToken: cancellationToken);

            return Ok(GetPagedResult(pagedList));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int? id, CancellationToken cancellationToken = default)
        {
            if (id == null || id == default(int))
                return NotFound();

            var data = await Service.GetByIdAsync(id.Value, cancellationToken);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TAddDTO dto, CancellationToken cancellationToken = default)
        {
            try
            {
                await Service.AddAsync(dto, cancellationToken);

                return Ok();
            }
            catch (ValidationException exception)
            {
                return BadRequest(GetValidationErrors(exception));
            }
            catch (Exception exception)
            {
                return BadRequest("There was something wrong. Sorry about that!");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(TUpdateDTO dto, CancellationToken cancellationToken = default)
        {
            try
            {
                await Service.UpdateAsync(dto, cancellationToken);

                return Ok();
            }
            catch (ValidationException exception)
            {
                return BadRequest(GetValidationErrors(exception));
            }
            catch (Exception exception)
            {
                return BadRequest("There was something wrong. Sorry about that!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id, CancellationToken cancellationToken = default)
        {
            try
            {
                if (id == null || id == default(int))
                    return NotFound();

                await Service.RemoveByIdAsync(id.Value, cancellationToken);

                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest("There was something wrong. Sorry about that!");
            }
        }

        [NonAction]
        protected PagedResult<TDTO> GetPagedResult(IPagedList<TDTO> pagedList)
        {
            return new PagedResult<TDTO>
            {
                PageSize = pagedList.PageSize,
                PageCount = pagedList.PageCount,
                HasNextPage = pagedList.HasNextPage,
                HasPreviousPage = pagedList.HasPreviousPage,
                TotalItemCount = pagedList.TotalItemCount,
                Items = pagedList.ToList()
            };
        }

        [NonAction]
        protected List<string> GetValidationErrors(ValidationException exception)
        {
            return exception.Errors.Select(e => e.ErrorMessage).ToList();
        }
    }

    public class PagedResult<T>
    {
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public int TotalItemCount { get; set; }
        public List<T> Items { get; set; }
    }

}
