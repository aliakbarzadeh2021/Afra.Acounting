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

namespace Afra.Api.Controllers.InvPartStockRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartStockRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartStockRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartStockRelCommand command)
        {
            command.Validate();

            var InvPartStockRels = await _unitOfWork.InvPartStockRelRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartStockRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartStockRel = Mapper.Map(command);
            await _unitOfWork.InvPartStockRelRepository.AddAsync(newInvPartStockRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartStockRelCommand command)
        {

            command.Validate();

            var InvPartStockRel = await _unitOfWork.InvPartStockRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartStockRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartStockRel = Mapper.Map(InvPartStockRel, command);
            InvPartStockRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartStockRel = await _unitOfWork.InvPartStockRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartStockRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartStockRel.IsActive = false;
            InvPartStockRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartStockRels = await _unitOfWork.InvPartStockRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartStockRelsDto = Mapper.Map(InvPartStockRels);

            return OkResult(CustomMessage.DefaultMessage, InvPartStockRelsDto.ToPagingAndSorting(query), InvPartStockRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartStockRel = await _unitOfWork.InvPartStockRelRepository.GetByIdAsync(id);

            if (InvPartStockRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartStockRelDto = Mapper.Map(InvPartStockRel);

            return OkResult( CustomMessage.DefaultMessage , InvPartStockRelDto);

        }
    }
}
