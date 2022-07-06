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

namespace Afra.Api.Controllers.InvPartCtgryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartCtgryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartCtgryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartCtgryCommand command)
        {
            command.Validate();

            var InvPartCtgrys = await _unitOfWork.InvPartCtgryRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartCtgrys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartCtgry = Mapper.Map(command);
            await _unitOfWork.InvPartCtgryRepository.AddAsync(newInvPartCtgry);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartCtgryCommand command)
        {

            command.Validate();

            var InvPartCtgry = await _unitOfWork.InvPartCtgryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCtgry = Mapper.Map(InvPartCtgry, command);
            InvPartCtgry.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartCtgry = await _unitOfWork.InvPartCtgryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCtgry.IsActive = false;
            InvPartCtgry.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartCtgrys = await _unitOfWork.InvPartCtgryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartCtgrysDto = Mapper.Map(InvPartCtgrys);

            return OkResult(CustomMessage.DefaultMessage, InvPartCtgrysDto.ToPagingAndSorting(query), InvPartCtgrysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartCtgry = await _unitOfWork.InvPartCtgryRepository.GetByIdAsync(id);

            if (InvPartCtgry is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartCtgryDto = Mapper.Map(InvPartCtgry);

            return OkResult( CustomMessage.DefaultMessage , InvPartCtgryDto);

        }
    }
}
