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

namespace Afra.Api.Controllers.AccDLCtgryRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccDLCtgryRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccDLCtgryRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccDLCtgryRelCommand command)
        {
            command.Validate();

            var AccDLCtgryRels = await _unitOfWork.AccDLCtgryRelRepository.FindAsync(c => c.Id == command.Id);

            if (AccDLCtgryRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccDLCtgryRel = Mapper.Map(command);
            await _unitOfWork.AccDLCtgryRelRepository.AddAsync(newAccDLCtgryRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccDLCtgryRelCommand command)
        {

            command.Validate();

            var AccDLCtgryRel = await _unitOfWork.AccDLCtgryRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccDLCtgryRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDLCtgryRel = Mapper.Map(AccDLCtgryRel, command);
            AccDLCtgryRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccDLCtgryRel = await _unitOfWork.AccDLCtgryRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccDLCtgryRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDLCtgryRel.IsActive = false;
            AccDLCtgryRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccDLCtgryRels = await _unitOfWork.AccDLCtgryRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccDLCtgryRelsDto = Mapper.Map(AccDLCtgryRels);

            return OkResult(CustomMessage.DefaultMessage, AccDLCtgryRelsDto.ToPagingAndSorting(query), AccDLCtgryRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccDLCtgryRel = await _unitOfWork.AccDLCtgryRelRepository.GetByIdAsync(id);

            if (AccDLCtgryRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccDLCtgryRelDto = Mapper.Map(AccDLCtgryRel);

            return OkResult( CustomMessage.DefaultMessage , AccDLCtgryRelDto);

        }
    }
}
