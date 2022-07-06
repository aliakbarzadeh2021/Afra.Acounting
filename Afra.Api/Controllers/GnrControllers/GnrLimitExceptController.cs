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

namespace Afra.Api.Controllers.GnrLimitExceptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrLimitExceptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrLimitExceptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrLimitExceptCommand command)
        {
            command.Validate();

            var GnrLimitExcepts = await _unitOfWork.GnrLimitExceptRepository.FindAsync(c => c.Id == command.Id);

            if (GnrLimitExcepts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrLimitExcept = Mapper.Map(command);
            await _unitOfWork.GnrLimitExceptRepository.AddAsync(newGnrLimitExcept);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrLimitExceptCommand command)
        {

            command.Validate();

            var GnrLimitExcept = await _unitOfWork.GnrLimitExceptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrLimitExcept == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitExcept = Mapper.Map(GnrLimitExcept, command);
            GnrLimitExcept.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrLimitExcept = await _unitOfWork.GnrLimitExceptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrLimitExcept == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitExcept.IsActive = false;
            GnrLimitExcept.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrLimitExcepts = await _unitOfWork.GnrLimitExceptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrLimitExceptsDto = Mapper.Map(GnrLimitExcepts);

            return OkResult(CustomMessage.DefaultMessage, GnrLimitExceptsDto.ToPagingAndSorting(query), GnrLimitExceptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrLimitExcept = await _unitOfWork.GnrLimitExceptRepository.GetByIdAsync(id);

            if (GnrLimitExcept is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrLimitExceptDto = Mapper.Map(GnrLimitExcept);

            return OkResult( CustomMessage.DefaultMessage , GnrLimitExceptDto);

        }
    }
}
