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

namespace Afra.Api.Controllers.PayUserFunsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayUserFunsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayUserFunsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayUserFunsCommand command)
        {
            command.Validate();

            var PayUserFunss = await _unitOfWork.PayUserFunsRepository.FindAsync(c => c.Id == command.Id);

            if (PayUserFunss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayUserFuns = Mapper.Map(command);
            await _unitOfWork.PayUserFunsRepository.AddAsync(newPayUserFuns);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayUserFunsCommand command)
        {

            command.Validate();

            var PayUserFuns = await _unitOfWork.PayUserFunsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayUserFuns == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayUserFuns = Mapper.Map(PayUserFuns, command);
            PayUserFuns.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayUserFuns = await _unitOfWork.PayUserFunsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayUserFuns == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayUserFuns.IsActive = false;
            PayUserFuns.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayUserFunss = await _unitOfWork.PayUserFunsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayUserFunssDto = Mapper.Map(PayUserFunss);

            return OkResult(CustomMessage.DefaultMessage, PayUserFunssDto.ToPagingAndSorting(query), PayUserFunssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayUserFuns = await _unitOfWork.PayUserFunsRepository.GetByIdAsync(id);

            if (PayUserFuns is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayUserFunsDto = Mapper.Map(PayUserFuns);

            return OkResult( CustomMessage.DefaultMessage , PayUserFunsDto);

        }
    }
}
