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

namespace Afra.Api.Controllers.HrmStatElmntMthdControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmStatElmntMthdController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmStatElmntMthdController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmStatElmntMthdCommand command)
        {
            command.Validate();

            var HrmStatElmntMthds = await _unitOfWork.HrmStatElmntMthdRepository.FindAsync(c => c.Id == command.Id);

            if (HrmStatElmntMthds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmStatElmntMthd = Mapper.Map(command);
            await _unitOfWork.HrmStatElmntMthdRepository.AddAsync(newHrmStatElmntMthd);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmStatElmntMthdCommand command)
        {

            command.Validate();

            var HrmStatElmntMthd = await _unitOfWork.HrmStatElmntMthdRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmStatElmntMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatElmntMthd = Mapper.Map(HrmStatElmntMthd, command);
            HrmStatElmntMthd.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmStatElmntMthd = await _unitOfWork.HrmStatElmntMthdRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmStatElmntMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmStatElmntMthd.IsActive = false;
            HrmStatElmntMthd.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmStatElmntMthds = await _unitOfWork.HrmStatElmntMthdRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmStatElmntMthdsDto = Mapper.Map(HrmStatElmntMthds);

            return OkResult(CustomMessage.DefaultMessage, HrmStatElmntMthdsDto.ToPagingAndSorting(query), HrmStatElmntMthdsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmStatElmntMthd = await _unitOfWork.HrmStatElmntMthdRepository.GetByIdAsync(id);

            if (HrmStatElmntMthd is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmStatElmntMthdDto = Mapper.Map(HrmStatElmntMthd);

            return OkResult( CustomMessage.DefaultMessage , HrmStatElmntMthdDto);

        }
    }
}
