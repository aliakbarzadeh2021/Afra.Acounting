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

namespace Afra.Api.Controllers.UsrRqstVacControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrRqstVacController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrRqstVacController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrRqstVacCommand command)
        {
            command.Validate();

            var UsrRqstVacs = await _unitOfWork.UsrRqstVacRepository.FindAsync(c => c.Id == command.Id);

            if (UsrRqstVacs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrRqstVac = Mapper.Map(command);
            await _unitOfWork.UsrRqstVacRepository.AddAsync(newUsrRqstVac);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrRqstVacCommand command)
        {

            command.Validate();

            var UsrRqstVac = await _unitOfWork.UsrRqstVacRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrRqstVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrRqstVac = Mapper.Map(UsrRqstVac, command);
            UsrRqstVac.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrRqstVac = await _unitOfWork.UsrRqstVacRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrRqstVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrRqstVac.IsActive = false;
            UsrRqstVac.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrRqstVacs = await _unitOfWork.UsrRqstVacRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrRqstVacsDto = Mapper.Map(UsrRqstVacs);

            return OkResult(CustomMessage.DefaultMessage, UsrRqstVacsDto.ToPagingAndSorting(query), UsrRqstVacsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrRqstVac = await _unitOfWork.UsrRqstVacRepository.GetByIdAsync(id);

            if (UsrRqstVac is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrRqstVacDto = Mapper.Map(UsrRqstVac);

            return OkResult( CustomMessage.DefaultMessage , UsrRqstVacDto);

        }
    }
}
