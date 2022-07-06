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

namespace Afra.Api.Controllers.InvStkPitchsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvStkPitchsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvStkPitchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvStkPitchsCommand command)
        {
            command.Validate();

            var InvStkPitchss = await _unitOfWork.InvStkPitchsRepository.FindAsync(c => c.Id == command.Id);

            if (InvStkPitchss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvStkPitchs = Mapper.Map(command);
            await _unitOfWork.InvStkPitchsRepository.AddAsync(newInvStkPitchs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvStkPitchsCommand command)
        {

            command.Validate();

            var InvStkPitchs = await _unitOfWork.InvStkPitchsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvStkPitchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStkPitchs = Mapper.Map(InvStkPitchs, command);
            InvStkPitchs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvStkPitchs = await _unitOfWork.InvStkPitchsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvStkPitchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStkPitchs.IsActive = false;
            InvStkPitchs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvStkPitchss = await _unitOfWork.InvStkPitchsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvStkPitchssDto = Mapper.Map(InvStkPitchss);

            return OkResult(CustomMessage.DefaultMessage, InvStkPitchssDto.ToPagingAndSorting(query), InvStkPitchssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvStkPitchs = await _unitOfWork.InvStkPitchsRepository.GetByIdAsync(id);

            if (InvStkPitchs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvStkPitchsDto = Mapper.Map(InvStkPitchs);

            return OkResult( CustomMessage.DefaultMessage , InvStkPitchsDto);

        }
    }
}
