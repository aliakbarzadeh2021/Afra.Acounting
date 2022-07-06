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

namespace Afra.Api.Controllers.PayBuyBaseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayBuyBaseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayBuyBaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayBuyBaseCommand command)
        {
            command.Validate();

            var PayBuyBases = await _unitOfWork.PayBuyBaseRepository.FindAsync(c => c.Id == command.Id);

            if (PayBuyBases.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayBuyBase = Mapper.Map(command);
            await _unitOfWork.PayBuyBaseRepository.AddAsync(newPayBuyBase);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayBuyBaseCommand command)
        {

            command.Validate();

            var PayBuyBase = await _unitOfWork.PayBuyBaseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayBuyBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBuyBase = Mapper.Map(PayBuyBase, command);
            PayBuyBase.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayBuyBase = await _unitOfWork.PayBuyBaseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayBuyBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBuyBase.IsActive = false;
            PayBuyBase.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayBuyBases = await _unitOfWork.PayBuyBaseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayBuyBasesDto = Mapper.Map(PayBuyBases);

            return OkResult(CustomMessage.DefaultMessage, PayBuyBasesDto.ToPagingAndSorting(query), PayBuyBasesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayBuyBase = await _unitOfWork.PayBuyBaseRepository.GetByIdAsync(id);

            if (PayBuyBase is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayBuyBaseDto = Mapper.Map(PayBuyBase);

            return OkResult( CustomMessage.DefaultMessage , PayBuyBaseDto);

        }
    }
}
