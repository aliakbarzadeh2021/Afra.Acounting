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

namespace Afra.Api.Controllers.SleSrvItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleSrvItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleSrvItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleSrvItmCommand command)
        {
            command.Validate();

            var SleSrvItms = await _unitOfWork.SleSrvItmRepository.FindAsync(c => c.Id == command.Id);

            if (SleSrvItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleSrvItm = Mapper.Map(command);
            await _unitOfWork.SleSrvItmRepository.AddAsync(newSleSrvItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleSrvItmCommand command)
        {

            command.Validate();

            var SleSrvItm = await _unitOfWork.SleSrvItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleSrvItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvItm = Mapper.Map(SleSrvItm, command);
            SleSrvItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleSrvItm = await _unitOfWork.SleSrvItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleSrvItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvItm.IsActive = false;
            SleSrvItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleSrvItms = await _unitOfWork.SleSrvItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleSrvItmsDto = Mapper.Map(SleSrvItms);

            return OkResult(CustomMessage.DefaultMessage, SleSrvItmsDto.ToPagingAndSorting(query), SleSrvItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleSrvItm = await _unitOfWork.SleSrvItmRepository.GetByIdAsync(id);

            if (SleSrvItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleSrvItmDto = Mapper.Map(SleSrvItm);

            return OkResult( CustomMessage.DefaultMessage , SleSrvItmDto);

        }
    }
}
