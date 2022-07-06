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

namespace Afra.Api.Controllers.CstRealCalcControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstRealCalcController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstRealCalcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstRealCalcCommand command)
        {
            command.Validate();

            var CstRealCalcs = await _unitOfWork.CstRealCalcRepository.FindAsync(c => c.Id == command.Id);

            if (CstRealCalcs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstRealCalc = Mapper.Map(command);
            await _unitOfWork.CstRealCalcRepository.AddAsync(newCstRealCalc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstRealCalcCommand command)
        {

            command.Validate();

            var CstRealCalc = await _unitOfWork.CstRealCalcRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstRealCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstRealCalc = Mapper.Map(CstRealCalc, command);
            CstRealCalc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstRealCalc = await _unitOfWork.CstRealCalcRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstRealCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstRealCalc.IsActive = false;
            CstRealCalc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstRealCalcs = await _unitOfWork.CstRealCalcRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstRealCalcsDto = Mapper.Map(CstRealCalcs);

            return OkResult(CustomMessage.DefaultMessage, CstRealCalcsDto.ToPagingAndSorting(query), CstRealCalcsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstRealCalc = await _unitOfWork.CstRealCalcRepository.GetByIdAsync(id);

            if (CstRealCalc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstRealCalcDto = Mapper.Map(CstRealCalc);

            return OkResult( CustomMessage.DefaultMessage , CstRealCalcDto);

        }
    }
}
