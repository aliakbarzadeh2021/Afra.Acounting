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

namespace Afra.Api.Controllers.BdgCostAllocDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgCostAllocDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgCostAllocDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgCostAllocDetCommand command)
        {
            command.Validate();

            var BdgCostAllocDets = await _unitOfWork.BdgCostAllocDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgCostAllocDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgCostAllocDet = Mapper.Map(command);
            await _unitOfWork.BdgCostAllocDetRepository.AddAsync(newBdgCostAllocDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgCostAllocDetCommand command)
        {

            command.Validate();

            var BdgCostAllocDet = await _unitOfWork.BdgCostAllocDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgCostAllocDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostAllocDet = Mapper.Map(BdgCostAllocDet, command);
            BdgCostAllocDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgCostAllocDet = await _unitOfWork.BdgCostAllocDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgCostAllocDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostAllocDet.IsActive = false;
            BdgCostAllocDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgCostAllocDets = await _unitOfWork.BdgCostAllocDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgCostAllocDetsDto = Mapper.Map(BdgCostAllocDets);

            return OkResult(CustomMessage.DefaultMessage, BdgCostAllocDetsDto.ToPagingAndSorting(query), BdgCostAllocDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgCostAllocDet = await _unitOfWork.BdgCostAllocDetRepository.GetByIdAsync(id);

            if (BdgCostAllocDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgCostAllocDetDto = Mapper.Map(BdgCostAllocDet);

            return OkResult( CustomMessage.DefaultMessage , BdgCostAllocDetDto);

        }
    }
}
