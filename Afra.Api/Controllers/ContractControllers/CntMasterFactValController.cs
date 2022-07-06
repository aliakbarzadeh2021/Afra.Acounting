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

namespace Afra.Api.Controllers.CntMasterFactValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntMasterFactValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntMasterFactValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntMasterFactValCommand command)
        {
            command.Validate();

            var CntMasterFactVals = await _unitOfWork.CntMasterFactValRepository.FindAsync(c => c.Id == command.Id);

            if (CntMasterFactVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntMasterFactVal = Mapper.Map(command);
            await _unitOfWork.CntMasterFactValRepository.AddAsync(newCntMasterFactVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntMasterFactValCommand command)
        {

            command.Validate();

            var CntMasterFactVal = await _unitOfWork.CntMasterFactValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactVal = Mapper.Map(CntMasterFactVal, command);
            CntMasterFactVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntMasterFactVal = await _unitOfWork.CntMasterFactValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactVal.IsActive = false;
            CntMasterFactVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntMasterFactVals = await _unitOfWork.CntMasterFactValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntMasterFactValsDto = Mapper.Map(CntMasterFactVals);

            return OkResult(CustomMessage.DefaultMessage, CntMasterFactValsDto.ToPagingAndSorting(query), CntMasterFactValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntMasterFactVal = await _unitOfWork.CntMasterFactValRepository.GetByIdAsync(id);

            if (CntMasterFactVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntMasterFactValDto = Mapper.Map(CntMasterFactVal);

            return OkResult( CustomMessage.DefaultMessage , CntMasterFactValDto);

        }
    }
}
