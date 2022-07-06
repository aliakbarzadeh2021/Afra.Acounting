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

namespace Afra.Api.Controllers.SleBrokersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokersCommand command)
        {
            command.Validate();

            var SleBrokerss = await _unitOfWork.SleBrokersRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokers = Mapper.Map(command);
            await _unitOfWork.SleBrokersRepository.AddAsync(newSleBrokers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokersCommand command)
        {

            command.Validate();

            var SleBrokers = await _unitOfWork.SleBrokersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokers = Mapper.Map(SleBrokers, command);
            SleBrokers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokers = await _unitOfWork.SleBrokersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokers.IsActive = false;
            SleBrokers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerss = await _unitOfWork.SleBrokersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerssDto = Mapper.Map(SleBrokerss);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerssDto.ToPagingAndSorting(query), SleBrokerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokers = await _unitOfWork.SleBrokersRepository.GetByIdAsync(id);

            if (SleBrokers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokersDto = Mapper.Map(SleBrokers);

            return OkResult( CustomMessage.DefaultMessage , SleBrokersDto);

        }
    }
}
