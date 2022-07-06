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

namespace Afra.Api.Controllers.SleCstmrsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCstmrsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCstmrsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCstmrsCommand command)
        {
            command.Validate();

            var SleCstmrss = await _unitOfWork.SleCstmrsRepository.FindAsync(c => c.Id == command.Id);

            if (SleCstmrss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCstmrs = Mapper.Map(command);
            await _unitOfWork.SleCstmrsRepository.AddAsync(newSleCstmrs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCstmrsCommand command)
        {

            command.Validate();

            var SleCstmrs = await _unitOfWork.SleCstmrsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCstmrs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrs = Mapper.Map(SleCstmrs, command);
            SleCstmrs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCstmrs = await _unitOfWork.SleCstmrsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCstmrs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrs.IsActive = false;
            SleCstmrs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCstmrss = await _unitOfWork.SleCstmrsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCstmrssDto = Mapper.Map(SleCstmrss);

            return OkResult(CustomMessage.DefaultMessage, SleCstmrssDto.ToPagingAndSorting(query), SleCstmrssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCstmrs = await _unitOfWork.SleCstmrsRepository.GetByIdAsync(id);

            if (SleCstmrs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCstmrsDto = Mapper.Map(SleCstmrs);

            return OkResult( CustomMessage.DefaultMessage , SleCstmrsDto);

        }
    }
}
