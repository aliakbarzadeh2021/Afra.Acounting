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

namespace Afra.Api.Controllers.CstStdCalcControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstStdCalcController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstStdCalcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstStdCalcCommand command)
        {
            command.Validate();

            var CstStdCalcs = await _unitOfWork.CstStdCalcRepository.FindAsync(c => c.Id == command.Id);

            if (CstStdCalcs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstStdCalc = Mapper.Map(command);
            await _unitOfWork.CstStdCalcRepository.AddAsync(newCstStdCalc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstStdCalcCommand command)
        {

            command.Validate();

            var CstStdCalc = await _unitOfWork.CstStdCalcRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstStdCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstStdCalc = Mapper.Map(CstStdCalc, command);
            CstStdCalc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstStdCalc = await _unitOfWork.CstStdCalcRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstStdCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstStdCalc.IsActive = false;
            CstStdCalc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstStdCalcs = await _unitOfWork.CstStdCalcRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstStdCalcsDto = Mapper.Map(CstStdCalcs);

            return OkResult(CustomMessage.DefaultMessage, CstStdCalcsDto.ToPagingAndSorting(query), CstStdCalcsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstStdCalc = await _unitOfWork.CstStdCalcRepository.GetByIdAsync(id);

            if (CstStdCalc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstStdCalcDto = Mapper.Map(CstStdCalc);

            return OkResult( CustomMessage.DefaultMessage , CstStdCalcDto);

        }
    }
}
