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

namespace Afra.Api.Controllers.TrsGContractChngControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGContractChngController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGContractChngController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGContractChngCommand command)
        {
            command.Validate();

            var TrsGContractChngs = await _unitOfWork.TrsGContractChngRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGContractChngs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGContractChng = Mapper.Map(command);
            await _unitOfWork.TrsGContractChngRepository.AddAsync(newTrsGContractChng);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGContractChngCommand command)
        {

            command.Validate();

            var TrsGContractChng = await _unitOfWork.TrsGContractChngRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGContractChng == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGContractChng = Mapper.Map(TrsGContractChng, command);
            TrsGContractChng.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGContractChng = await _unitOfWork.TrsGContractChngRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGContractChng == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGContractChng.IsActive = false;
            TrsGContractChng.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGContractChngs = await _unitOfWork.TrsGContractChngRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGContractChngsDto = Mapper.Map(TrsGContractChngs);

            return OkResult(CustomMessage.DefaultMessage, TrsGContractChngsDto.ToPagingAndSorting(query), TrsGContractChngsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGContractChng = await _unitOfWork.TrsGContractChngRepository.GetByIdAsync(id);

            if (TrsGContractChng is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGContractChngDto = Mapper.Map(TrsGContractChng);

            return OkResult( CustomMessage.DefaultMessage , TrsGContractChngDto);

        }
    }
}
