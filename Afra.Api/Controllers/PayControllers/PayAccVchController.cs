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

namespace Afra.Api.Controllers.PayAccVchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayAccVchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayAccVchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayAccVchCommand command)
        {
            command.Validate();

            var PayAccVchs = await _unitOfWork.PayAccVchRepository.FindAsync(c => c.Id == command.Id);

            if (PayAccVchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayAccVch = Mapper.Map(command);
            await _unitOfWork.PayAccVchRepository.AddAsync(newPayAccVch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayAccVchCommand command)
        {

            command.Validate();

            var PayAccVch = await _unitOfWork.PayAccVchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayAccVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayAccVch = Mapper.Map(PayAccVch, command);
            PayAccVch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayAccVch = await _unitOfWork.PayAccVchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayAccVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayAccVch.IsActive = false;
            PayAccVch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayAccVchs = await _unitOfWork.PayAccVchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayAccVchsDto = Mapper.Map(PayAccVchs);

            return OkResult(CustomMessage.DefaultMessage, PayAccVchsDto.ToPagingAndSorting(query), PayAccVchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayAccVch = await _unitOfWork.PayAccVchRepository.GetByIdAsync(id);

            if (PayAccVch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayAccVchDto = Mapper.Map(PayAccVch);

            return OkResult( CustomMessage.DefaultMessage , PayAccVchDto);

        }
    }
}
