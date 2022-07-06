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

namespace Afra.Api.Controllers.UsrPersHrmRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsCommand command)
        {
            command.Validate();

            var UsrPersHrmRelss = await _unitOfWork.UsrPersHrmRelsRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRels = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsRepository.AddAsync(newUsrPersHrmRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsCommand command)
        {

            command.Validate();

            var UsrPersHrmRels = await _unitOfWork.UsrPersHrmRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRels = Mapper.Map(UsrPersHrmRels, command);
            UsrPersHrmRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRels = await _unitOfWork.UsrPersHrmRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRels.IsActive = false;
            UsrPersHrmRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelss = await _unitOfWork.UsrPersHrmRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelssDto = Mapper.Map(UsrPersHrmRelss);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelssDto.ToPagingAndSorting(query), UsrPersHrmRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRels = await _unitOfWork.UsrPersHrmRelsRepository.GetByIdAsync(id);

            if (UsrPersHrmRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsDto = Mapper.Map(UsrPersHrmRels);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsDto);

        }
    }
}
