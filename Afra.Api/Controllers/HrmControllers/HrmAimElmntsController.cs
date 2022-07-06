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

namespace Afra.Api.Controllers.HrmAimElmntsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmAimElmntsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmAimElmntsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmAimElmntsCommand command)
        {
            command.Validate();

            var HrmAimElmntss = await _unitOfWork.HrmAimElmntsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmAimElmntss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmAimElmnts = Mapper.Map(command);
            await _unitOfWork.HrmAimElmntsRepository.AddAsync(newHrmAimElmnts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmAimElmntsCommand command)
        {

            command.Validate();

            var HrmAimElmnts = await _unitOfWork.HrmAimElmntsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmAimElmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimElmnts = Mapper.Map(HrmAimElmnts, command);
            HrmAimElmnts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmAimElmnts = await _unitOfWork.HrmAimElmntsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmAimElmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimElmnts.IsActive = false;
            HrmAimElmnts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmAimElmntss = await _unitOfWork.HrmAimElmntsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmAimElmntssDto = Mapper.Map(HrmAimElmntss);

            return OkResult(CustomMessage.DefaultMessage, HrmAimElmntssDto.ToPagingAndSorting(query), HrmAimElmntssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmAimElmnts = await _unitOfWork.HrmAimElmntsRepository.GetByIdAsync(id);

            if (HrmAimElmnts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmAimElmntsDto = Mapper.Map(HrmAimElmnts);

            return OkResult( CustomMessage.DefaultMessage , HrmAimElmntsDto);

        }
    }
}
