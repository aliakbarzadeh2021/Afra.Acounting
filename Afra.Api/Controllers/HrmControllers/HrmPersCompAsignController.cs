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

namespace Afra.Api.Controllers.HrmPersCompAsignControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersCompAsignController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersCompAsignController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersCompAsignCommand command)
        {
            command.Validate();

            var HrmPersCompAsigns = await _unitOfWork.HrmPersCompAsignRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersCompAsigns.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersCompAsign = Mapper.Map(command);
            await _unitOfWork.HrmPersCompAsignRepository.AddAsync(newHrmPersCompAsign);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersCompAsignCommand command)
        {

            command.Validate();

            var HrmPersCompAsign = await _unitOfWork.HrmPersCompAsignRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersCompAsign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersCompAsign = Mapper.Map(HrmPersCompAsign, command);
            HrmPersCompAsign.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersCompAsign = await _unitOfWork.HrmPersCompAsignRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersCompAsign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersCompAsign.IsActive = false;
            HrmPersCompAsign.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersCompAsigns = await _unitOfWork.HrmPersCompAsignRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersCompAsignsDto = Mapper.Map(HrmPersCompAsigns);

            return OkResult(CustomMessage.DefaultMessage, HrmPersCompAsignsDto.ToPagingAndSorting(query), HrmPersCompAsignsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersCompAsign = await _unitOfWork.HrmPersCompAsignRepository.GetByIdAsync(id);

            if (HrmPersCompAsign is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersCompAsignDto = Mapper.Map(HrmPersCompAsign);

            return OkResult( CustomMessage.DefaultMessage , HrmPersCompAsignDto);

        }
    }
}
