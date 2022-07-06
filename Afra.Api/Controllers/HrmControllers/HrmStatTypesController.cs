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

namespace Afra.Api.Controllers.HrmStatTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmStatTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmStatTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmStatTypesCommand command)
        {
            command.Validate();

            var HrmStatTypess = await _unitOfWork.HrmStatTypesRepository.FindAsync(c => c.Id == command.Id);

            if (HrmStatTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmStatTypes = Mapper.Map(command);
            await _unitOfWork.HrmStatTypesRepository.AddAsync(newHrmStatTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmStatTypesCommand command)
        {

            command.Validate();

            var HrmStatTypes = await _unitOfWork.HrmStatTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmStatTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatTypes = Mapper.Map(HrmStatTypes, command);
            HrmStatTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmStatTypes = await _unitOfWork.HrmStatTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmStatTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatTypes.IsActive = false;
            HrmStatTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmStatTypess = await _unitOfWork.HrmStatTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmStatTypessDto = Mapper.Map(HrmStatTypess);

            return OkResult(CustomMessage.DefaultMessage, HrmStatTypessDto.ToPagingAndSorting(query), HrmStatTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmStatTypes = await _unitOfWork.HrmStatTypesRepository.GetByIdAsync(id);

            if (HrmStatTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmStatTypesDto = Mapper.Map(HrmStatTypes);

            return OkResult( CustomMessage.DefaultMessage , HrmStatTypesDto);

        }
    }
}
