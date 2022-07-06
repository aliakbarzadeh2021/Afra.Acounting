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

namespace Afra.Api.Controllers.HrmPersRltdControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersRltdController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersRltdController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersRltdCommand command)
        {
            command.Validate();

            var HrmPersRltds = await _unitOfWork.HrmPersRltdRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersRltds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersRltd = Mapper.Map(command);
            await _unitOfWork.HrmPersRltdRepository.AddAsync(newHrmPersRltd);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersRltdCommand command)
        {

            command.Validate();

            var HrmPersRltd = await _unitOfWork.HrmPersRltdRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersRltd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersRltd = Mapper.Map(HrmPersRltd, command);
            HrmPersRltd.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersRltd = await _unitOfWork.HrmPersRltdRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersRltd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersRltd.IsActive = false;
            HrmPersRltd.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersRltds = await _unitOfWork.HrmPersRltdRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersRltdsDto = Mapper.Map(HrmPersRltds);

            return OkResult(CustomMessage.DefaultMessage, HrmPersRltdsDto.ToPagingAndSorting(query), HrmPersRltdsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersRltd = await _unitOfWork.HrmPersRltdRepository.GetByIdAsync(id);

            if (HrmPersRltd is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersRltdDto = Mapper.Map(HrmPersRltd);

            return OkResult( CustomMessage.DefaultMessage , HrmPersRltdDto);

        }
    }
}
