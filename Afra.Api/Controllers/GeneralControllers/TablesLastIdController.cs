using Microsoft.AspNetCore.Mvc;
using Afra.api.Base;
using Afra.Domain.Entities;
using Afra.Repository;
using Afra.Message.Base;
using Afra.Message.Commands;
using Afra.Message.Dtos;
using Afra.Message;
using System;
using System.Linq;
using System.Threading.Tasks;
using Afra.Infrastructure.Base;

namespace Afra.Api.Controllers.TablesLastIdControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TablesLastIdController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TablesLastIdController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTablesLastIdCommand command)
        {
            command.Validate();

            var TablesLastIds = await _unitOfWork.TablesLastIdRepository.FindAsync(c => c.Id == command.Id);

            if (TablesLastIds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTablesLastId = Mapper.Map(command);
            await _unitOfWork.TablesLastIdRepository.AddAsync(newTablesLastId);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTablesLastIdCommand command)
        {

            command.Validate();

            var TablesLastId = await _unitOfWork.TablesLastIdRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TablesLastId == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TablesLastId = Mapper.Map(TablesLastId, command);
            TablesLastId.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TablesLastId = await _unitOfWork.TablesLastIdRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TablesLastId == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TablesLastId.IsActive = false;
            TablesLastId.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TablesLastIds = await _unitOfWork.TablesLastIdRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TablesLastIdsDto = Mapper.Map(TablesLastIds);

            return OkResult(CustomMessage.DefaultMessage, TablesLastIdsDto.ToPagingAndSorting(query), TablesLastIdsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TablesLastId = await _unitOfWork.TablesLastIdRepository.GetByIdAsync(id);

            if (TablesLastId is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TablesLastIdDto = Mapper.Map(TablesLastId);

            return OkResult( CustomMessage.DefaultMessage , TablesLastIdDto);

        }
    }
}
