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

namespace Afra.Api.Controllers.PayGrpLoanPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayGrpLoanPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayGrpLoanPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayGrpLoanPersCommand command)
        {
            command.Validate();

            var PayGrpLoanPerss = await _unitOfWork.PayGrpLoanPersRepository.FindAsync(c => c.Id == command.Id);

            if (PayGrpLoanPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayGrpLoanPers = Mapper.Map(command);
            await _unitOfWork.PayGrpLoanPersRepository.AddAsync(newPayGrpLoanPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayGrpLoanPersCommand command)
        {

            command.Validate();

            var PayGrpLoanPers = await _unitOfWork.PayGrpLoanPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayGrpLoanPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpLoanPers = Mapper.Map(PayGrpLoanPers, command);
            PayGrpLoanPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayGrpLoanPers = await _unitOfWork.PayGrpLoanPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayGrpLoanPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpLoanPers.IsActive = false;
            PayGrpLoanPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayGrpLoanPerss = await _unitOfWork.PayGrpLoanPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayGrpLoanPerssDto = Mapper.Map(PayGrpLoanPerss);

            return OkResult(CustomMessage.DefaultMessage, PayGrpLoanPerssDto.ToPagingAndSorting(query), PayGrpLoanPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayGrpLoanPers = await _unitOfWork.PayGrpLoanPersRepository.GetByIdAsync(id);

            if (PayGrpLoanPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayGrpLoanPersDto = Mapper.Map(PayGrpLoanPers);

            return OkResult( CustomMessage.DefaultMessage , PayGrpLoanPersDto);

        }
    }
}
