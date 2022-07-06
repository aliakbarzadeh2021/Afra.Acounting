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

namespace Afra.Api.Controllers.PayBdgBaseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayBdgBaseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayBdgBaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayBdgBaseCommand command)
        {
            command.Validate();

            var PayBdgBases = await _unitOfWork.PayBdgBaseRepository.FindAsync(c => c.Id == command.Id);

            if (PayBdgBases.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayBdgBase = Mapper.Map(command);
            await _unitOfWork.PayBdgBaseRepository.AddAsync(newPayBdgBase);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayBdgBaseCommand command)
        {

            command.Validate();

            var PayBdgBase = await _unitOfWork.PayBdgBaseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayBdgBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgBase = Mapper.Map(PayBdgBase, command);
            PayBdgBase.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayBdgBase = await _unitOfWork.PayBdgBaseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayBdgBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgBase.IsActive = false;
            PayBdgBase.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayBdgBases = await _unitOfWork.PayBdgBaseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayBdgBasesDto = Mapper.Map(PayBdgBases);

            return OkResult(CustomMessage.DefaultMessage, PayBdgBasesDto.ToPagingAndSorting(query), PayBdgBasesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayBdgBase = await _unitOfWork.PayBdgBaseRepository.GetByIdAsync(id);

            if (PayBdgBase is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayBdgBaseDto = Mapper.Map(PayBdgBase);

            return OkResult( CustomMessage.DefaultMessage , PayBdgBaseDto);

        }
    }
}
