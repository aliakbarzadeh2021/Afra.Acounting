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

namespace Afra.Api.Controllers.BdgCostCntrAllocControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgCostCntrAllocController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgCostCntrAllocController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgCostCntrAllocCommand command)
        {
            command.Validate();

            var BdgCostCntrAllocs = await _unitOfWork.BdgCostCntrAllocRepository.FindAsync(c => c.Id == command.Id);

            if (BdgCostCntrAllocs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgCostCntrAlloc = Mapper.Map(command);
            await _unitOfWork.BdgCostCntrAllocRepository.AddAsync(newBdgCostCntrAlloc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgCostCntrAllocCommand command)
        {

            command.Validate();

            var BdgCostCntrAlloc = await _unitOfWork.BdgCostCntrAllocRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgCostCntrAlloc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostCntrAlloc = Mapper.Map(BdgCostCntrAlloc, command);
            BdgCostCntrAlloc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgCostCntrAlloc = await _unitOfWork.BdgCostCntrAllocRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgCostCntrAlloc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostCntrAlloc.IsActive = false;
            BdgCostCntrAlloc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgCostCntrAllocs = await _unitOfWork.BdgCostCntrAllocRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgCostCntrAllocsDto = Mapper.Map(BdgCostCntrAllocs);

            return OkResult(CustomMessage.DefaultMessage, BdgCostCntrAllocsDto.ToPagingAndSorting(query), BdgCostCntrAllocsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgCostCntrAlloc = await _unitOfWork.BdgCostCntrAllocRepository.GetByIdAsync(id);

            if (BdgCostCntrAlloc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgCostCntrAllocDto = Mapper.Map(BdgCostCntrAlloc);

            return OkResult( CustomMessage.DefaultMessage , BdgCostCntrAllocDto);

        }
    }
}
