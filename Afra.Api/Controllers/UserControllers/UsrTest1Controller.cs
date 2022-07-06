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

namespace Afra.Api.Controllers.UsrTest1Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrTest1Controller : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrTest1Controller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrTest1Command command)
        {
            command.Validate();

            var UsrTest1s = await _unitOfWork.UsrTest1Repository.FindAsync(c => c.Id == command.Id);

            if (UsrTest1s.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrTest1 = Mapper.Map(command);
            await _unitOfWork.UsrTest1Repository.AddAsync(newUsrTest1);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrTest1Command command)
        {

            command.Validate();

            var UsrTest1 = await _unitOfWork.UsrTest1Repository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrTest1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTest1 = Mapper.Map(UsrTest1, command);
            UsrTest1.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrTest1 = await _unitOfWork.UsrTest1Repository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrTest1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTest1.IsActive = false;
            UsrTest1.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrTest1s = await _unitOfWork.UsrTest1Repository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrTest1sDto = Mapper.Map(UsrTest1s);

            return OkResult(CustomMessage.DefaultMessage, UsrTest1sDto.ToPagingAndSorting(query), UsrTest1sDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrTest1 = await _unitOfWork.UsrTest1Repository.GetByIdAsync(id);

            if (UsrTest1 is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrTest1Dto = Mapper.Map(UsrTest1);

            return OkResult( CustomMessage.DefaultMessage , UsrTest1Dto);

        }
    }
}
