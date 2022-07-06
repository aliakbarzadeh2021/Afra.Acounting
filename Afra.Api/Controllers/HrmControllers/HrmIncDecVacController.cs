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

namespace Afra.Api.Controllers.HrmIncDecVacControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmIncDecVacController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmIncDecVacController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmIncDecVacCommand command)
        {
            command.Validate();

            var HrmIncDecVacs = await _unitOfWork.HrmIncDecVacRepository.FindAsync(c => c.Id == command.Id);

            if (HrmIncDecVacs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmIncDecVac = Mapper.Map(command);
            await _unitOfWork.HrmIncDecVacRepository.AddAsync(newHrmIncDecVac);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmIncDecVacCommand command)
        {

            command.Validate();

            var HrmIncDecVac = await _unitOfWork.HrmIncDecVacRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmIncDecVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmIncDecVac = Mapper.Map(HrmIncDecVac, command);
            HrmIncDecVac.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmIncDecVac = await _unitOfWork.HrmIncDecVacRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmIncDecVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmIncDecVac.IsActive = false;
            HrmIncDecVac.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmIncDecVacs = await _unitOfWork.HrmIncDecVacRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmIncDecVacsDto = Mapper.Map(HrmIncDecVacs);

            return OkResult(CustomMessage.DefaultMessage, HrmIncDecVacsDto.ToPagingAndSorting(query), HrmIncDecVacsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmIncDecVac = await _unitOfWork.HrmIncDecVacRepository.GetByIdAsync(id);

            if (HrmIncDecVac is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmIncDecVacDto = Mapper.Map(HrmIncDecVac);

            return OkResult( CustomMessage.DefaultMessage , HrmIncDecVacDto);

        }
    }
}
