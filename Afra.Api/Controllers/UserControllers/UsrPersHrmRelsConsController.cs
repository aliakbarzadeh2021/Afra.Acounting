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

namespace Afra.Api.Controllers.UsrPersHrmRelsConsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsConsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsConsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsConsCommand command)
        {
            command.Validate();

            var UsrPersHrmRelsConss = await _unitOfWork.UsrPersHrmRelsConsRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelsConss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRelsCons = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsConsRepository.AddAsync(newUsrPersHrmRelsCons);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsConsCommand command)
        {

            command.Validate();

            var UsrPersHrmRelsCons = await _unitOfWork.UsrPersHrmRelsConsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsCons == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsCons = Mapper.Map(UsrPersHrmRelsCons, command);
            UsrPersHrmRelsCons.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRelsCons = await _unitOfWork.UsrPersHrmRelsConsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsCons == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsCons.IsActive = false;
            UsrPersHrmRelsCons.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelsConss = await _unitOfWork.UsrPersHrmRelsConsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelsConssDto = Mapper.Map(UsrPersHrmRelsConss);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelsConssDto.ToPagingAndSorting(query), UsrPersHrmRelsConssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRelsCons = await _unitOfWork.UsrPersHrmRelsConsRepository.GetByIdAsync(id);

            if (UsrPersHrmRelsCons is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsConsDto = Mapper.Map(UsrPersHrmRelsCons);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsConsDto);

        }
    }
}
