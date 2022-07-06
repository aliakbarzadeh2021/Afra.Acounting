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

namespace Afra.Api.Controllers.HrmRqstVacControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmRqstVacController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmRqstVacController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmRqstVacCommand command)
        {
            command.Validate();

            var HrmRqstVacs = await _unitOfWork.HrmRqstVacRepository.FindAsync(c => c.Id == command.Id);

            if (HrmRqstVacs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmRqstVac = Mapper.Map(command);
            await _unitOfWork.HrmRqstVacRepository.AddAsync(newHrmRqstVac);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmRqstVacCommand command)
        {

            command.Validate();

            var HrmRqstVac = await _unitOfWork.HrmRqstVacRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmRqstVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmRqstVac = Mapper.Map(HrmRqstVac, command);
            HrmRqstVac.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmRqstVac = await _unitOfWork.HrmRqstVacRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmRqstVac == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmRqstVac.IsActive = false;
            HrmRqstVac.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmRqstVacs = await _unitOfWork.HrmRqstVacRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmRqstVacsDto = Mapper.Map(HrmRqstVacs);

            return OkResult(CustomMessage.DefaultMessage, HrmRqstVacsDto.ToPagingAndSorting(query), HrmRqstVacsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmRqstVac = await _unitOfWork.HrmRqstVacRepository.GetByIdAsync(id);

            if (HrmRqstVac is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmRqstVacDto = Mapper.Map(HrmRqstVac);

            return OkResult( CustomMessage.DefaultMessage , HrmRqstVacDto);

        }
    }
}
