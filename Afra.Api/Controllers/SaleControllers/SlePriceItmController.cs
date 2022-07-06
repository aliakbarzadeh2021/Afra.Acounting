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

namespace Afra.Api.Controllers.SlePriceItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SlePriceItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SlePriceItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSlePriceItmCommand command)
        {
            command.Validate();

            var SlePriceItms = await _unitOfWork.SlePriceItmRepository.FindAsync(c => c.Id == command.Id);

            if (SlePriceItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSlePriceItm = Mapper.Map(command);
            await _unitOfWork.SlePriceItmRepository.AddAsync(newSlePriceItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSlePriceItmCommand command)
        {

            command.Validate();

            var SlePriceItm = await _unitOfWork.SlePriceItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SlePriceItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SlePriceItm = Mapper.Map(SlePriceItm, command);
            SlePriceItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SlePriceItm = await _unitOfWork.SlePriceItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SlePriceItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SlePriceItm.IsActive = false;
            SlePriceItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SlePriceItms = await _unitOfWork.SlePriceItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SlePriceItmsDto = Mapper.Map(SlePriceItms);

            return OkResult(CustomMessage.DefaultMessage, SlePriceItmsDto.ToPagingAndSorting(query), SlePriceItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SlePriceItm = await _unitOfWork.SlePriceItmRepository.GetByIdAsync(id);

            if (SlePriceItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SlePriceItmDto = Mapper.Map(SlePriceItm);

            return OkResult( CustomMessage.DefaultMessage , SlePriceItmDto);

        }
    }
}
