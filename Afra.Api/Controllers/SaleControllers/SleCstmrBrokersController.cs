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

namespace Afra.Api.Controllers.SleCstmrBrokersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCstmrBrokersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCstmrBrokersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCstmrBrokersCommand command)
        {
            command.Validate();

            var SleCstmrBrokerss = await _unitOfWork.SleCstmrBrokersRepository.FindAsync(c => c.Id == command.Id);

            if (SleCstmrBrokerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCstmrBrokers = Mapper.Map(command);
            await _unitOfWork.SleCstmrBrokersRepository.AddAsync(newSleCstmrBrokers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCstmrBrokersCommand command)
        {

            command.Validate();

            var SleCstmrBrokers = await _unitOfWork.SleCstmrBrokersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCstmrBrokers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrBrokers = Mapper.Map(SleCstmrBrokers, command);
            SleCstmrBrokers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCstmrBrokers = await _unitOfWork.SleCstmrBrokersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCstmrBrokers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrBrokers.IsActive = false;
            SleCstmrBrokers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCstmrBrokerss = await _unitOfWork.SleCstmrBrokersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCstmrBrokerssDto = Mapper.Map(SleCstmrBrokerss);

            return OkResult(CustomMessage.DefaultMessage, SleCstmrBrokerssDto.ToPagingAndSorting(query), SleCstmrBrokerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCstmrBrokers = await _unitOfWork.SleCstmrBrokersRepository.GetByIdAsync(id);

            if (SleCstmrBrokers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCstmrBrokersDto = Mapper.Map(SleCstmrBrokers);

            return OkResult( CustomMessage.DefaultMessage , SleCstmrBrokersDto);

        }
    }
}
