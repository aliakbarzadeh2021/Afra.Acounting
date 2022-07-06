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

namespace Afra.Api.Controllers.HrmTimeSheetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmTimeSheetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmTimeSheetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmTimeSheetCommand command)
        {
            command.Validate();

            var HrmTimeSheets = await _unitOfWork.HrmTimeSheetRepository.FindAsync(c => c.Id == command.Id);

            if (HrmTimeSheets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmTimeSheet = Mapper.Map(command);
            await _unitOfWork.HrmTimeSheetRepository.AddAsync(newHrmTimeSheet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmTimeSheetCommand command)
        {

            command.Validate();

            var HrmTimeSheet = await _unitOfWork.HrmTimeSheetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmTimeSheet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTimeSheet = Mapper.Map(HrmTimeSheet, command);
            HrmTimeSheet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmTimeSheet = await _unitOfWork.HrmTimeSheetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmTimeSheet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTimeSheet.IsActive = false;
            HrmTimeSheet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmTimeSheets = await _unitOfWork.HrmTimeSheetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmTimeSheetsDto = Mapper.Map(HrmTimeSheets);

            return OkResult(CustomMessage.DefaultMessage, HrmTimeSheetsDto.ToPagingAndSorting(query), HrmTimeSheetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmTimeSheet = await _unitOfWork.HrmTimeSheetRepository.GetByIdAsync(id);

            if (HrmTimeSheet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmTimeSheetDto = Mapper.Map(HrmTimeSheet);

            return OkResult( CustomMessage.DefaultMessage , HrmTimeSheetDto);

        }
    }
}
