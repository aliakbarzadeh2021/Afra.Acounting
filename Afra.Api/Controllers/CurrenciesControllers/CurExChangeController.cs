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

namespace Afra.Api.Controllers.CurExChangeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CurExChangeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CurExChangeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCurExChangeCommand command)
        {
            command.Validate();

            var CurExChanges = await _unitOfWork.CurExChangeRepository.FindAsync(c => c.Id == command.Id);

            if (CurExChanges.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCurExChange = Mapper.Map(command);
            await _unitOfWork.CurExChangeRepository.AddAsync(newCurExChange);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCurExChangeCommand command)
        {

            command.Validate();

            var CurExChange = await _unitOfWork.CurExChangeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CurExChange == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CurExChange = Mapper.Map(CurExChange, command);
            CurExChange.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CurExChange = await _unitOfWork.CurExChangeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CurExChange == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CurExChange.IsActive = false;
            CurExChange.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CurExChanges = await _unitOfWork.CurExChangeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CurExChangesDto = Mapper.Map(CurExChanges);

            return OkResult(CustomMessage.DefaultMessage, CurExChangesDto.ToPagingAndSorting(query), CurExChangesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CurExChange = await _unitOfWork.CurExChangeRepository.GetByIdAsync(id);

            if (CurExChange is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CurExChangeDto = Mapper.Map(CurExChange);

            return OkResult( CustomMessage.DefaultMessage , CurExChangeDto);

        }
    }
}
