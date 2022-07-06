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

namespace Afra.Api.Controllers.CmrTransportDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrTransportDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrTransportDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrTransportDetCommand command)
        {
            command.Validate();

            var CmrTransportDets = await _unitOfWork.CmrTransportDetRepository.FindAsync(c => c.Id == command.Id);

            if (CmrTransportDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrTransportDet = Mapper.Map(command);
            await _unitOfWork.CmrTransportDetRepository.AddAsync(newCmrTransportDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrTransportDetCommand command)
        {

            command.Validate();

            var CmrTransportDet = await _unitOfWork.CmrTransportDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrTransportDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrTransportDet = Mapper.Map(CmrTransportDet, command);
            CmrTransportDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrTransportDet = await _unitOfWork.CmrTransportDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrTransportDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrTransportDet.IsActive = false;
            CmrTransportDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrTransportDets = await _unitOfWork.CmrTransportDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrTransportDetsDto = Mapper.Map(CmrTransportDets);

            return OkResult(CustomMessage.DefaultMessage, CmrTransportDetsDto.ToPagingAndSorting(query), CmrTransportDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrTransportDet = await _unitOfWork.CmrTransportDetRepository.GetByIdAsync(id);

            if (CmrTransportDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrTransportDetDto = Mapper.Map(CmrTransportDet);

            return OkResult( CustomMessage.DefaultMessage , CmrTransportDetDto);

        }
    }
}
