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

namespace Afra.Api.Controllers.HrmPersonnelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersonnelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersonnelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersonnelsCommand command)
        {
            command.Validate();

            var HrmPersonnelss = await _unitOfWork.HrmPersonnelsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersonnelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersonnels = Mapper.Map(command);
            await _unitOfWork.HrmPersonnelsRepository.AddAsync(newHrmPersonnels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersonnelsCommand command)
        {

            command.Validate();

            var HrmPersonnels = await _unitOfWork.HrmPersonnelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersonnels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersonnels = Mapper.Map(HrmPersonnels, command);
            HrmPersonnels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersonnels = await _unitOfWork.HrmPersonnelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersonnels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersonnels.IsActive = false;
            HrmPersonnels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersonnelss = await _unitOfWork.HrmPersonnelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersonnelssDto = Mapper.Map(HrmPersonnelss);

            return OkResult(CustomMessage.DefaultMessage, HrmPersonnelssDto.ToPagingAndSorting(query), HrmPersonnelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersonnels = await _unitOfWork.HrmPersonnelsRepository.GetByIdAsync(id);

            if (HrmPersonnels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersonnelsDto = Mapper.Map(HrmPersonnels);

            return OkResult( CustomMessage.DefaultMessage , HrmPersonnelsDto);

        }
    }
}
