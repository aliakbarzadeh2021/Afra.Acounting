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

namespace Afra.Api.Controllers.SleTaxesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleTaxesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleTaxesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleTaxesCommand command)
        {
            command.Validate();

            var SleTaxess = await _unitOfWork.SleTaxesRepository.FindAsync(c => c.Id == command.Id);

            if (SleTaxess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleTaxes = Mapper.Map(command);
            await _unitOfWork.SleTaxesRepository.AddAsync(newSleTaxes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleTaxesCommand command)
        {

            command.Validate();

            var SleTaxes = await _unitOfWork.SleTaxesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleTaxes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleTaxes = Mapper.Map(SleTaxes, command);
            SleTaxes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleTaxes = await _unitOfWork.SleTaxesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleTaxes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleTaxes.IsActive = false;
            SleTaxes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleTaxess = await _unitOfWork.SleTaxesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleTaxessDto = Mapper.Map(SleTaxess);

            return OkResult(CustomMessage.DefaultMessage, SleTaxessDto.ToPagingAndSorting(query), SleTaxessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleTaxes = await _unitOfWork.SleTaxesRepository.GetByIdAsync(id);

            if (SleTaxes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleTaxesDto = Mapper.Map(SleTaxes);

            return OkResult( CustomMessage.DefaultMessage , SleTaxesDto);

        }
    }
}
