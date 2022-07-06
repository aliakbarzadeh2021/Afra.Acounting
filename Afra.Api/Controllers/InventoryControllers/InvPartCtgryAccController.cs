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

namespace Afra.Api.Controllers.InvPartCtgryAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartCtgryAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartCtgryAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartCtgryAccCommand command)
        {
            command.Validate();

            var InvPartCtgryAccs = await _unitOfWork.InvPartCtgryAccRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartCtgryAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartCtgryAcc = Mapper.Map(command);
            await _unitOfWork.InvPartCtgryAccRepository.AddAsync(newInvPartCtgryAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartCtgryAccCommand command)
        {

            command.Validate();

            var InvPartCtgryAcc = await _unitOfWork.InvPartCtgryAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartCtgryAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCtgryAcc = Mapper.Map(InvPartCtgryAcc, command);
            InvPartCtgryAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartCtgryAcc = await _unitOfWork.InvPartCtgryAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartCtgryAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCtgryAcc.IsActive = false;
            InvPartCtgryAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartCtgryAccs = await _unitOfWork.InvPartCtgryAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartCtgryAccsDto = Mapper.Map(InvPartCtgryAccs);

            return OkResult(CustomMessage.DefaultMessage, InvPartCtgryAccsDto.ToPagingAndSorting(query), InvPartCtgryAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartCtgryAcc = await _unitOfWork.InvPartCtgryAccRepository.GetByIdAsync(id);

            if (InvPartCtgryAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartCtgryAccDto = Mapper.Map(InvPartCtgryAcc);

            return OkResult( CustomMessage.DefaultMessage , InvPartCtgryAccDto);

        }
    }
}
