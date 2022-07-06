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

namespace Afra.Api.Controllers.PayCalcBaseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCalcBaseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCalcBaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCalcBaseCommand command)
        {
            command.Validate();

            var PayCalcBases = await _unitOfWork.PayCalcBaseRepository.FindAsync(c => c.Id == command.Id);

            if (PayCalcBases.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCalcBase = Mapper.Map(command);
            await _unitOfWork.PayCalcBaseRepository.AddAsync(newPayCalcBase);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCalcBaseCommand command)
        {

            command.Validate();

            var PayCalcBase = await _unitOfWork.PayCalcBaseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCalcBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcBase = Mapper.Map(PayCalcBase, command);
            PayCalcBase.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCalcBase = await _unitOfWork.PayCalcBaseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCalcBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcBase.IsActive = false;
            PayCalcBase.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCalcBases = await _unitOfWork.PayCalcBaseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCalcBasesDto = Mapper.Map(PayCalcBases);

            return OkResult(CustomMessage.DefaultMessage, PayCalcBasesDto.ToPagingAndSorting(query), PayCalcBasesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCalcBase = await _unitOfWork.PayCalcBaseRepository.GetByIdAsync(id);

            if (PayCalcBase is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCalcBaseDto = Mapper.Map(PayCalcBase);

            return OkResult( CustomMessage.DefaultMessage , PayCalcBaseDto);

        }
    }
}
