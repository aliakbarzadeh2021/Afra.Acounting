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

namespace Afra.Api.Controllers.AccCloseItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccCloseItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccCloseItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccCloseItmCommand command)
        {
            command.Validate();

            var AccCloseItms = await _unitOfWork.AccCloseItmRepository.FindAsync(c => c.Id == command.Id);

            if (AccCloseItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccCloseItm = Mapper.Map(command);
            await _unitOfWork.AccCloseItmRepository.AddAsync(newAccCloseItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccCloseItmCommand command)
        {

            command.Validate();

            var AccCloseItm = await _unitOfWork.AccCloseItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccCloseItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccCloseItm = Mapper.Map(AccCloseItm, command);
            AccCloseItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccCloseItm = await _unitOfWork.AccCloseItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccCloseItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccCloseItm.IsActive = false;
            AccCloseItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccCloseItms = await _unitOfWork.AccCloseItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccCloseItmsDto = Mapper.Map(AccCloseItms);

            return OkResult(CustomMessage.DefaultMessage, AccCloseItmsDto.ToPagingAndSorting(query), AccCloseItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccCloseItm = await _unitOfWork.AccCloseItmRepository.GetByIdAsync(id);

            if (AccCloseItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccCloseItmDto = Mapper.Map(AccCloseItm);

            return OkResult( CustomMessage.DefaultMessage , AccCloseItmDto);

        }
    }
}
