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

namespace Afra.Api.Controllers.TrsVchItmBaseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsVchItmBaseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsVchItmBaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsVchItmBaseCommand command)
        {
            command.Validate();

            var TrsVchItmBases = await _unitOfWork.TrsVchItmBaseRepository.FindAsync(c => c.Id == command.Id);

            if (TrsVchItmBases.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsVchItmBase = Mapper.Map(command);
            await _unitOfWork.TrsVchItmBaseRepository.AddAsync(newTrsVchItmBase);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsVchItmBaseCommand command)
        {

            command.Validate();

            var TrsVchItmBase = await _unitOfWork.TrsVchItmBaseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsVchItmBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItmBase = Mapper.Map(TrsVchItmBase, command);
            TrsVchItmBase.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsVchItmBase = await _unitOfWork.TrsVchItmBaseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsVchItmBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItmBase.IsActive = false;
            TrsVchItmBase.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsVchItmBases = await _unitOfWork.TrsVchItmBaseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsVchItmBasesDto = Mapper.Map(TrsVchItmBases);

            return OkResult(CustomMessage.DefaultMessage, TrsVchItmBasesDto.ToPagingAndSorting(query), TrsVchItmBasesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsVchItmBase = await _unitOfWork.TrsVchItmBaseRepository.GetByIdAsync(id);

            if (TrsVchItmBase is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsVchItmBaseDto = Mapper.Map(TrsVchItmBase);

            return OkResult( CustomMessage.DefaultMessage , TrsVchItmBaseDto);

        }
    }
}
