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

namespace Afra.Api.Controllers.HrmStatMthdDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmStatMthdDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmStatMthdDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmStatMthdDetCommand command)
        {
            command.Validate();

            var HrmStatMthdDets = await _unitOfWork.HrmStatMthdDetRepository.FindAsync(c => c.Id == command.Id);

            if (HrmStatMthdDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmStatMthdDet = Mapper.Map(command);
            await _unitOfWork.HrmStatMthdDetRepository.AddAsync(newHrmStatMthdDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmStatMthdDetCommand command)
        {

            command.Validate();

            var HrmStatMthdDet = await _unitOfWork.HrmStatMthdDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmStatMthdDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatMthdDet = Mapper.Map(HrmStatMthdDet, command);
            HrmStatMthdDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmStatMthdDet = await _unitOfWork.HrmStatMthdDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmStatMthdDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatMthdDet.IsActive = false;
            HrmStatMthdDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmStatMthdDets = await _unitOfWork.HrmStatMthdDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmStatMthdDetsDto = Mapper.Map(HrmStatMthdDets);

            return OkResult(CustomMessage.DefaultMessage, HrmStatMthdDetsDto.ToPagingAndSorting(query), HrmStatMthdDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmStatMthdDet = await _unitOfWork.HrmStatMthdDetRepository.GetByIdAsync(id);

            if (HrmStatMthdDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmStatMthdDetDto = Mapper.Map(HrmStatMthdDet);

            return OkResult( CustomMessage.DefaultMessage , HrmStatMthdDetDto);

        }
    }
}
