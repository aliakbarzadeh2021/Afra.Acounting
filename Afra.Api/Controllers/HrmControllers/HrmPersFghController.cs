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

namespace Afra.Api.Controllers.HrmPersFghControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersFghController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersFghController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersFghCommand command)
        {
            command.Validate();

            var HrmPersFghs = await _unitOfWork.HrmPersFghRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersFghs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersFgh = Mapper.Map(command);
            await _unitOfWork.HrmPersFghRepository.AddAsync(newHrmPersFgh);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersFghCommand command)
        {

            command.Validate();

            var HrmPersFgh = await _unitOfWork.HrmPersFghRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersFgh == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersFgh = Mapper.Map(HrmPersFgh, command);
            HrmPersFgh.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersFgh = await _unitOfWork.HrmPersFghRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersFgh == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersFgh.IsActive = false;
            HrmPersFgh.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersFghs = await _unitOfWork.HrmPersFghRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersFghsDto = Mapper.Map(HrmPersFghs);

            return OkResult(CustomMessage.DefaultMessage, HrmPersFghsDto.ToPagingAndSorting(query), HrmPersFghsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersFgh = await _unitOfWork.HrmPersFghRepository.GetByIdAsync(id);

            if (HrmPersFgh is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersFghDto = Mapper.Map(HrmPersFgh);

            return OkResult( CustomMessage.DefaultMessage , HrmPersFghDto);

        }
    }
}
