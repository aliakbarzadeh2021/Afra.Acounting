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

namespace Afra.Api.Controllers.SleCstmrLimitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCstmrLimitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCstmrLimitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCstmrLimitCommand command)
        {
            command.Validate();

            var SleCstmrLimits = await _unitOfWork.SleCstmrLimitRepository.FindAsync(c => c.Id == command.Id);

            if (SleCstmrLimits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCstmrLimit = Mapper.Map(command);
            await _unitOfWork.SleCstmrLimitRepository.AddAsync(newSleCstmrLimit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCstmrLimitCommand command)
        {

            command.Validate();

            var SleCstmrLimit = await _unitOfWork.SleCstmrLimitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCstmrLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrLimit = Mapper.Map(SleCstmrLimit, command);
            SleCstmrLimit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCstmrLimit = await _unitOfWork.SleCstmrLimitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCstmrLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrLimit.IsActive = false;
            SleCstmrLimit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCstmrLimits = await _unitOfWork.SleCstmrLimitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCstmrLimitsDto = Mapper.Map(SleCstmrLimits);

            return OkResult(CustomMessage.DefaultMessage, SleCstmrLimitsDto.ToPagingAndSorting(query), SleCstmrLimitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCstmrLimit = await _unitOfWork.SleCstmrLimitRepository.GetByIdAsync(id);

            if (SleCstmrLimit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCstmrLimitDto = Mapper.Map(SleCstmrLimit);

            return OkResult( CustomMessage.DefaultMessage , SleCstmrLimitDto);

        }
    }
}
