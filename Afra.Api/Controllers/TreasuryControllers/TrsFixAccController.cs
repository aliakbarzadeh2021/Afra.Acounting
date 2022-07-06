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

namespace Afra.Api.Controllers.TrsFixAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFixAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFixAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFixAccCommand command)
        {
            command.Validate();

            var TrsFixAccs = await _unitOfWork.TrsFixAccRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFixAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFixAcc = Mapper.Map(command);
            await _unitOfWork.TrsFixAccRepository.AddAsync(newTrsFixAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFixAccCommand command)
        {

            command.Validate();

            var TrsFixAcc = await _unitOfWork.TrsFixAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFixAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFixAcc = Mapper.Map(TrsFixAcc, command);
            TrsFixAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFixAcc = await _unitOfWork.TrsFixAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFixAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFixAcc.IsActive = false;
            TrsFixAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFixAccs = await _unitOfWork.TrsFixAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFixAccsDto = Mapper.Map(TrsFixAccs);

            return OkResult(CustomMessage.DefaultMessage, TrsFixAccsDto.ToPagingAndSorting(query), TrsFixAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFixAcc = await _unitOfWork.TrsFixAccRepository.GetByIdAsync(id);

            if (TrsFixAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFixAccDto = Mapper.Map(TrsFixAcc);

            return OkResult( CustomMessage.DefaultMessage , TrsFixAccDto);

        }
    }
}
