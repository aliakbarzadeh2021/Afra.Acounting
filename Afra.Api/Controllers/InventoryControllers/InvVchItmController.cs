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

namespace Afra.Api.Controllers.InvVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchItmCommand command)
        {
            command.Validate();

            var InvVchItms = await _unitOfWork.InvVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchItm = Mapper.Map(command);
            await _unitOfWork.InvVchItmRepository.AddAsync(newInvVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchItmCommand command)
        {

            command.Validate();

            var InvVchItm = await _unitOfWork.InvVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchItm = Mapper.Map(InvVchItm, command);
            InvVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchItm = await _unitOfWork.InvVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchItm.IsActive = false;
            InvVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchItms = await _unitOfWork.InvVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchItmsDto = Mapper.Map(InvVchItms);

            return OkResult(CustomMessage.DefaultMessage, InvVchItmsDto.ToPagingAndSorting(query), InvVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchItm = await _unitOfWork.InvVchItmRepository.GetByIdAsync(id);

            if (InvVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchItmDto = Mapper.Map(InvVchItm);

            return OkResult( CustomMessage.DefaultMessage , InvVchItmDto);

        }
    }
}
