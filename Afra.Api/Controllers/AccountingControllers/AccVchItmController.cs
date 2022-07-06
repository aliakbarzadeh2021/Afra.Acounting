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

namespace Afra.Api.Controllers.AccVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchItmCommand command)
        {
            command.Validate();

            var AccVchItms = await _unitOfWork.AccVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchItm = Mapper.Map(command);
            await _unitOfWork.AccVchItmRepository.AddAsync(newAccVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchItmCommand command)
        {

            command.Validate();

            var AccVchItm = await _unitOfWork.AccVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchItm = Mapper.Map(AccVchItm, command);
            AccVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchItm = await _unitOfWork.AccVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchItm.IsActive = false;
            AccVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchItms = await _unitOfWork.AccVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchItmsDto = Mapper.Map(AccVchItms);

            return OkResult(CustomMessage.DefaultMessage, AccVchItmsDto.ToPagingAndSorting(query), AccVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchItm = await _unitOfWork.AccVchItmRepository.GetByIdAsync(id);

            if (AccVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchItmDto = Mapper.Map(AccVchItm);

            return OkResult( CustomMessage.DefaultMessage , AccVchItmDto);

        }
    }
}
