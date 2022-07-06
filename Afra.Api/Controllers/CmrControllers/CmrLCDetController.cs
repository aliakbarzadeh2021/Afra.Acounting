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

namespace Afra.Api.Controllers.CmrLCDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrLCDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrLCDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrLCDetCommand command)
        {
            command.Validate();

            var CmrLCDets = await _unitOfWork.CmrLCDetRepository.FindAsync(c => c.Id == command.Id);

            if (CmrLCDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrLCDet = Mapper.Map(command);
            await _unitOfWork.CmrLCDetRepository.AddAsync(newCmrLCDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrLCDetCommand command)
        {

            command.Validate();

            var CmrLCDet = await _unitOfWork.CmrLCDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrLCDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrLCDet = Mapper.Map(CmrLCDet, command);
            CmrLCDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrLCDet = await _unitOfWork.CmrLCDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrLCDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrLCDet.IsActive = false;
            CmrLCDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrLCDets = await _unitOfWork.CmrLCDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrLCDetsDto = Mapper.Map(CmrLCDets);

            return OkResult(CustomMessage.DefaultMessage, CmrLCDetsDto.ToPagingAndSorting(query), CmrLCDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrLCDet = await _unitOfWork.CmrLCDetRepository.GetByIdAsync(id);

            if (CmrLCDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrLCDetDto = Mapper.Map(CmrLCDet);

            return OkResult( CustomMessage.DefaultMessage , CmrLCDetDto);

        }
    }
}
