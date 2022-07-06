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

namespace Afra.Api.Controllers.SleSrvPrcItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleSrvPrcItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleSrvPrcItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleSrvPrcItmCommand command)
        {
            command.Validate();

            var SleSrvPrcItms = await _unitOfWork.SleSrvPrcItmRepository.FindAsync(c => c.Id == command.Id);

            if (SleSrvPrcItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleSrvPrcItm = Mapper.Map(command);
            await _unitOfWork.SleSrvPrcItmRepository.AddAsync(newSleSrvPrcItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleSrvPrcItmCommand command)
        {

            command.Validate();

            var SleSrvPrcItm = await _unitOfWork.SleSrvPrcItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleSrvPrcItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvPrcItm = Mapper.Map(SleSrvPrcItm, command);
            SleSrvPrcItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleSrvPrcItm = await _unitOfWork.SleSrvPrcItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleSrvPrcItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvPrcItm.IsActive = false;
            SleSrvPrcItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleSrvPrcItms = await _unitOfWork.SleSrvPrcItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleSrvPrcItmsDto = Mapper.Map(SleSrvPrcItms);

            return OkResult(CustomMessage.DefaultMessage, SleSrvPrcItmsDto.ToPagingAndSorting(query), SleSrvPrcItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleSrvPrcItm = await _unitOfWork.SleSrvPrcItmRepository.GetByIdAsync(id);

            if (SleSrvPrcItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleSrvPrcItmDto = Mapper.Map(SleSrvPrcItm);

            return OkResult( CustomMessage.DefaultMessage , SleSrvPrcItmDto);

        }
    }
}
