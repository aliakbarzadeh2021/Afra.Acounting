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

namespace Afra.Api.Controllers.PrdPersWorkStControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdPersWorkStController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdPersWorkStController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdPersWorkStCommand command)
        {
            command.Validate();

            var PrdPersWorkSts = await _unitOfWork.PrdPersWorkStRepository.FindAsync(c => c.Id == command.Id);

            if (PrdPersWorkSts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdPersWorkSt = Mapper.Map(command);
            await _unitOfWork.PrdPersWorkStRepository.AddAsync(newPrdPersWorkSt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdPersWorkStCommand command)
        {

            command.Validate();

            var PrdPersWorkSt = await _unitOfWork.PrdPersWorkStRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdPersWorkSt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPersWorkSt = Mapper.Map(PrdPersWorkSt, command);
            PrdPersWorkSt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdPersWorkSt = await _unitOfWork.PrdPersWorkStRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdPersWorkSt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPersWorkSt.IsActive = false;
            PrdPersWorkSt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdPersWorkSts = await _unitOfWork.PrdPersWorkStRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdPersWorkStsDto = Mapper.Map(PrdPersWorkSts);

            return OkResult(CustomMessage.DefaultMessage, PrdPersWorkStsDto.ToPagingAndSorting(query), PrdPersWorkStsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdPersWorkSt = await _unitOfWork.PrdPersWorkStRepository.GetByIdAsync(id);

            if (PrdPersWorkSt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdPersWorkStDto = Mapper.Map(PrdPersWorkSt);

            return OkResult( CustomMessage.DefaultMessage , PrdPersWorkStDto);

        }
    }
}
