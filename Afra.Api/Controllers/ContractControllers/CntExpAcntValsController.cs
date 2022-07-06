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

namespace Afra.Api.Controllers.CntExpAcntValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAcntValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAcntValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAcntValsCommand command)
        {
            command.Validate();

            var CntExpAcntValss = await _unitOfWork.CntExpAcntValsRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAcntValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAcntVals = Mapper.Map(command);
            await _unitOfWork.CntExpAcntValsRepository.AddAsync(newCntExpAcntVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAcntValsCommand command)
        {

            command.Validate();

            var CntExpAcntVals = await _unitOfWork.CntExpAcntValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntVals = Mapper.Map(CntExpAcntVals, command);
            CntExpAcntVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAcntVals = await _unitOfWork.CntExpAcntValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntVals.IsActive = false;
            CntExpAcntVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAcntValss = await _unitOfWork.CntExpAcntValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAcntValssDto = Mapper.Map(CntExpAcntValss);

            return OkResult(CustomMessage.DefaultMessage, CntExpAcntValssDto.ToPagingAndSorting(query), CntExpAcntValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAcntVals = await _unitOfWork.CntExpAcntValsRepository.GetByIdAsync(id);

            if (CntExpAcntVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAcntValsDto = Mapper.Map(CntExpAcntVals);

            return OkResult( CustomMessage.DefaultMessage , CntExpAcntValsDto);

        }
    }
}
