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

namespace Afra.Api.Controllers.CntExpAcntDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAcntDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAcntDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAcntDetCommand command)
        {
            command.Validate();

            var CntExpAcntDets = await _unitOfWork.CntExpAcntDetRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAcntDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAcntDet = Mapper.Map(command);
            await _unitOfWork.CntExpAcntDetRepository.AddAsync(newCntExpAcntDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAcntDetCommand command)
        {

            command.Validate();

            var CntExpAcntDet = await _unitOfWork.CntExpAcntDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntDet = Mapper.Map(CntExpAcntDet, command);
            CntExpAcntDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAcntDet = await _unitOfWork.CntExpAcntDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntDet.IsActive = false;
            CntExpAcntDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAcntDets = await _unitOfWork.CntExpAcntDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAcntDetsDto = Mapper.Map(CntExpAcntDets);

            return OkResult(CustomMessage.DefaultMessage, CntExpAcntDetsDto.ToPagingAndSorting(query), CntExpAcntDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAcntDet = await _unitOfWork.CntExpAcntDetRepository.GetByIdAsync(id);

            if (CntExpAcntDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAcntDetDto = Mapper.Map(CntExpAcntDet);

            return OkResult( CustomMessage.DefaultMessage , CntExpAcntDetDto);

        }
    }
}
