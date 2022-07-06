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

namespace Afra.Api.Controllers.InvVchDefAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchDefAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchDefAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchDefAccCommand command)
        {
            command.Validate();

            var InvVchDefAccs = await _unitOfWork.InvVchDefAccRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchDefAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchDefAcc = Mapper.Map(command);
            await _unitOfWork.InvVchDefAccRepository.AddAsync(newInvVchDefAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchDefAccCommand command)
        {

            command.Validate();

            var InvVchDefAcc = await _unitOfWork.InvVchDefAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchDefAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchDefAcc = Mapper.Map(InvVchDefAcc, command);
            InvVchDefAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchDefAcc = await _unitOfWork.InvVchDefAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchDefAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchDefAcc.IsActive = false;
            InvVchDefAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchDefAccs = await _unitOfWork.InvVchDefAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchDefAccsDto = Mapper.Map(InvVchDefAccs);

            return OkResult(CustomMessage.DefaultMessage, InvVchDefAccsDto.ToPagingAndSorting(query), InvVchDefAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchDefAcc = await _unitOfWork.InvVchDefAccRepository.GetByIdAsync(id);

            if (InvVchDefAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchDefAccDto = Mapper.Map(InvVchDefAcc);

            return OkResult( CustomMessage.DefaultMessage , InvVchDefAccDto);

        }
    }
}
