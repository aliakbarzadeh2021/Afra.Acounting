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

namespace Afra.Api.Controllers.CstCostAllocDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostAllocDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostAllocDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostAllocDetCommand command)
        {
            command.Validate();

            var CstCostAllocDets = await _unitOfWork.CstCostAllocDetRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostAllocDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostAllocDet = Mapper.Map(command);
            await _unitOfWork.CstCostAllocDetRepository.AddAsync(newCstCostAllocDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostAllocDetCommand command)
        {

            command.Validate();

            var CstCostAllocDet = await _unitOfWork.CstCostAllocDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostAllocDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostAllocDet = Mapper.Map(CstCostAllocDet, command);
            CstCostAllocDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostAllocDet = await _unitOfWork.CstCostAllocDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostAllocDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostAllocDet.IsActive = false;
            CstCostAllocDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostAllocDets = await _unitOfWork.CstCostAllocDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostAllocDetsDto = Mapper.Map(CstCostAllocDets);

            return OkResult(CustomMessage.DefaultMessage, CstCostAllocDetsDto.ToPagingAndSorting(query), CstCostAllocDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostAllocDet = await _unitOfWork.CstCostAllocDetRepository.GetByIdAsync(id);

            if (CstCostAllocDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostAllocDetDto = Mapper.Map(CstCostAllocDet);

            return OkResult( CustomMessage.DefaultMessage , CstCostAllocDetDto);

        }
    }
}
