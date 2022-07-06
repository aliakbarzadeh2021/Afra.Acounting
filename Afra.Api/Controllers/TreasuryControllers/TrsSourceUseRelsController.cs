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

namespace Afra.Api.Controllers.TrsSourceUseRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsSourceUseRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsSourceUseRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsSourceUseRelsCommand command)
        {
            command.Validate();

            var TrsSourceUseRelss = await _unitOfWork.TrsSourceUseRelsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsSourceUseRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsSourceUseRels = Mapper.Map(command);
            await _unitOfWork.TrsSourceUseRelsRepository.AddAsync(newTrsSourceUseRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsSourceUseRelsCommand command)
        {

            command.Validate();

            var TrsSourceUseRels = await _unitOfWork.TrsSourceUseRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsSourceUseRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsSourceUseRels = Mapper.Map(TrsSourceUseRels, command);
            TrsSourceUseRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsSourceUseRels = await _unitOfWork.TrsSourceUseRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsSourceUseRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsSourceUseRels.IsActive = false;
            TrsSourceUseRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsSourceUseRelss = await _unitOfWork.TrsSourceUseRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsSourceUseRelssDto = Mapper.Map(TrsSourceUseRelss);

            return OkResult(CustomMessage.DefaultMessage, TrsSourceUseRelssDto.ToPagingAndSorting(query), TrsSourceUseRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsSourceUseRels = await _unitOfWork.TrsSourceUseRelsRepository.GetByIdAsync(id);

            if (TrsSourceUseRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsSourceUseRelsDto = Mapper.Map(TrsSourceUseRels);

            return OkResult( CustomMessage.DefaultMessage , TrsSourceUseRelsDto);

        }
    }
}
