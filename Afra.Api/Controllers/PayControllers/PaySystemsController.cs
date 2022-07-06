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

namespace Afra.Api.Controllers.PaySystemsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaySystemsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaySystemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaySystemsCommand command)
        {
            command.Validate();

            var PaySystemss = await _unitOfWork.PaySystemsRepository.FindAsync(c => c.Id == command.Id);

            if (PaySystemss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaySystems = Mapper.Map(command);
            await _unitOfWork.PaySystemsRepository.AddAsync(newPaySystems);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaySystemsCommand command)
        {

            command.Validate();

            var PaySystems = await _unitOfWork.PaySystemsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaySystems == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySystems = Mapper.Map(PaySystems, command);
            PaySystems.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaySystems = await _unitOfWork.PaySystemsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaySystems == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySystems.IsActive = false;
            PaySystems.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaySystemss = await _unitOfWork.PaySystemsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaySystemssDto = Mapper.Map(PaySystemss);

            return OkResult(CustomMessage.DefaultMessage, PaySystemssDto.ToPagingAndSorting(query), PaySystemssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaySystems = await _unitOfWork.PaySystemsRepository.GetByIdAsync(id);

            if (PaySystems is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaySystemsDto = Mapper.Map(PaySystems);

            return OkResult( CustomMessage.DefaultMessage , PaySystemsDto);

        }
    }
}
