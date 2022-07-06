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

namespace Afra.Api.Controllers.HrmNumberingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmNumberingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmNumberingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmNumberingCommand command)
        {
            command.Validate();

            var HrmNumberings = await _unitOfWork.HrmNumberingRepository.FindAsync(c => c.Id == command.Id);

            if (HrmNumberings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmNumbering = Mapper.Map(command);
            await _unitOfWork.HrmNumberingRepository.AddAsync(newHrmNumbering);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmNumberingCommand command)
        {

            command.Validate();

            var HrmNumbering = await _unitOfWork.HrmNumberingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmNumbering == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmNumbering = Mapper.Map(HrmNumbering, command);
            HrmNumbering.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmNumbering = await _unitOfWork.HrmNumberingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmNumbering == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmNumbering.IsActive = false;
            HrmNumbering.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmNumberings = await _unitOfWork.HrmNumberingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmNumberingsDto = Mapper.Map(HrmNumberings);

            return OkResult(CustomMessage.DefaultMessage, HrmNumberingsDto.ToPagingAndSorting(query), HrmNumberingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmNumbering = await _unitOfWork.HrmNumberingRepository.GetByIdAsync(id);

            if (HrmNumbering is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmNumberingDto = Mapper.Map(HrmNumbering);

            return OkResult( CustomMessage.DefaultMessage , HrmNumberingDto);

        }
    }
}
