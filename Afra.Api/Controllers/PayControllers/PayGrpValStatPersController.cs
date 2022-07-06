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

namespace Afra.Api.Controllers.PayGrpValStatPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayGrpValStatPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayGrpValStatPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayGrpValStatPersCommand command)
        {
            command.Validate();

            var PayGrpValStatPerss = await _unitOfWork.PayGrpValStatPersRepository.FindAsync(c => c.Id == command.Id);

            if (PayGrpValStatPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayGrpValStatPers = Mapper.Map(command);
            await _unitOfWork.PayGrpValStatPersRepository.AddAsync(newPayGrpValStatPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayGrpValStatPersCommand command)
        {

            command.Validate();

            var PayGrpValStatPers = await _unitOfWork.PayGrpValStatPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStatPers = Mapper.Map(PayGrpValStatPers, command);
            PayGrpValStatPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayGrpValStatPers = await _unitOfWork.PayGrpValStatPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStatPers.IsActive = false;
            PayGrpValStatPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayGrpValStatPerss = await _unitOfWork.PayGrpValStatPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayGrpValStatPerssDto = Mapper.Map(PayGrpValStatPerss);

            return OkResult(CustomMessage.DefaultMessage, PayGrpValStatPerssDto.ToPagingAndSorting(query), PayGrpValStatPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayGrpValStatPers = await _unitOfWork.PayGrpValStatPersRepository.GetByIdAsync(id);

            if (PayGrpValStatPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayGrpValStatPersDto = Mapper.Map(PayGrpValStatPers);

            return OkResult( CustomMessage.DefaultMessage , PayGrpValStatPersDto);

        }
    }
}
