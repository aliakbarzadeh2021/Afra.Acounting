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

namespace Afra.Api.Controllers.CstCostCntrAllocControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrAllocController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrAllocController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrAllocCommand command)
        {
            command.Validate();

            var CstCostCntrAllocs = await _unitOfWork.CstCostCntrAllocRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrAllocs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrAlloc = Mapper.Map(command);
            await _unitOfWork.CstCostCntrAllocRepository.AddAsync(newCstCostCntrAlloc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrAllocCommand command)
        {

            command.Validate();

            var CstCostCntrAlloc = await _unitOfWork.CstCostCntrAllocRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAlloc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAlloc = Mapper.Map(CstCostCntrAlloc, command);
            CstCostCntrAlloc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrAlloc = await _unitOfWork.CstCostCntrAllocRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAlloc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAlloc.IsActive = false;
            CstCostCntrAlloc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrAllocs = await _unitOfWork.CstCostCntrAllocRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrAllocsDto = Mapper.Map(CstCostCntrAllocs);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrAllocsDto.ToPagingAndSorting(query), CstCostCntrAllocsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrAlloc = await _unitOfWork.CstCostCntrAllocRepository.GetByIdAsync(id);

            if (CstCostCntrAlloc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrAllocDto = Mapper.Map(CstCostCntrAlloc);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrAllocDto);

        }
    }
}
