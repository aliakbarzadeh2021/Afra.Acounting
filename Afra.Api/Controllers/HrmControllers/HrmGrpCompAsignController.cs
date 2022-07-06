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

namespace Afra.Api.Controllers.HrmGrpCompAsignControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpCompAsignController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpCompAsignController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpCompAsignCommand command)
        {
            command.Validate();

            var HrmGrpCompAsigns = await _unitOfWork.HrmGrpCompAsignRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpCompAsigns.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpCompAsign = Mapper.Map(command);
            await _unitOfWork.HrmGrpCompAsignRepository.AddAsync(newHrmGrpCompAsign);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpCompAsignCommand command)
        {

            command.Validate();

            var HrmGrpCompAsign = await _unitOfWork.HrmGrpCompAsignRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpCompAsign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpCompAsign = Mapper.Map(HrmGrpCompAsign, command);
            HrmGrpCompAsign.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpCompAsign = await _unitOfWork.HrmGrpCompAsignRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpCompAsign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpCompAsign.IsActive = false;
            HrmGrpCompAsign.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpCompAsigns = await _unitOfWork.HrmGrpCompAsignRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpCompAsignsDto = Mapper.Map(HrmGrpCompAsigns);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpCompAsignsDto.ToPagingAndSorting(query), HrmGrpCompAsignsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpCompAsign = await _unitOfWork.HrmGrpCompAsignRepository.GetByIdAsync(id);

            if (HrmGrpCompAsign is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpCompAsignDto = Mapper.Map(HrmGrpCompAsign);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpCompAsignDto);

        }
    }
}
