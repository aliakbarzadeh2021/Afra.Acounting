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

namespace Afra.Api.Controllers.HrmPersMrgControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersMrgController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersMrgController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersMrgCommand command)
        {
            command.Validate();

            var HrmPersMrgs = await _unitOfWork.HrmPersMrgRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersMrgs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersMrg = Mapper.Map(command);
            await _unitOfWork.HrmPersMrgRepository.AddAsync(newHrmPersMrg);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersMrgCommand command)
        {

            command.Validate();

            var HrmPersMrg = await _unitOfWork.HrmPersMrgRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersMrg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersMrg = Mapper.Map(HrmPersMrg, command);
            HrmPersMrg.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersMrg = await _unitOfWork.HrmPersMrgRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersMrg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersMrg.IsActive = false;
            HrmPersMrg.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersMrgs = await _unitOfWork.HrmPersMrgRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersMrgsDto = Mapper.Map(HrmPersMrgs);

            return OkResult(CustomMessage.DefaultMessage, HrmPersMrgsDto.ToPagingAndSorting(query), HrmPersMrgsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersMrg = await _unitOfWork.HrmPersMrgRepository.GetByIdAsync(id);

            if (HrmPersMrg is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersMrgDto = Mapper.Map(HrmPersMrg);

            return OkResult( CustomMessage.DefaultMessage , HrmPersMrgDto);

        }
    }
}
