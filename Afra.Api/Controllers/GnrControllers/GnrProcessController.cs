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

namespace Afra.Api.Controllers.GnrProcessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessCommand command)
        {
            command.Validate();

            var GnrProcesss = await _unitOfWork.GnrProcessRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcess = Mapper.Map(command);
            await _unitOfWork.GnrProcessRepository.AddAsync(newGnrProcess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessCommand command)
        {

            command.Validate();

            var GnrProcess = await _unitOfWork.GnrProcessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcess = Mapper.Map(GnrProcess, command);
            GnrProcess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcess = await _unitOfWork.GnrProcessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcess.IsActive = false;
            GnrProcess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcesss = await _unitOfWork.GnrProcessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcesssDto = Mapper.Map(GnrProcesss);

            return OkResult(CustomMessage.DefaultMessage, GnrProcesssDto.ToPagingAndSorting(query), GnrProcesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcess = await _unitOfWork.GnrProcessRepository.GetByIdAsync(id);

            if (GnrProcess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDto = Mapper.Map(GnrProcess);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDto);

        }
    }
}
