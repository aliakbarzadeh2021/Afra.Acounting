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

namespace Afra.Api.Controllers.OtoLttrLabelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoLttrLabelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoLttrLabelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoLttrLabelsCommand command)
        {
            command.Validate();

            var OtoLttrLabelss = await _unitOfWork.OtoLttrLabelsRepository.FindAsync(c => c.Id == command.Id);

            if (OtoLttrLabelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoLttrLabels = Mapper.Map(command);
            await _unitOfWork.OtoLttrLabelsRepository.AddAsync(newOtoLttrLabels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoLttrLabelsCommand command)
        {

            command.Validate();

            var OtoLttrLabels = await _unitOfWork.OtoLttrLabelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoLttrLabels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrLabels = Mapper.Map(OtoLttrLabels, command);
            OtoLttrLabels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoLttrLabels = await _unitOfWork.OtoLttrLabelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoLttrLabels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrLabels.IsActive = false;
            OtoLttrLabels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoLttrLabelss = await _unitOfWork.OtoLttrLabelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoLttrLabelssDto = Mapper.Map(OtoLttrLabelss);

            return OkResult(CustomMessage.DefaultMessage, OtoLttrLabelssDto.ToPagingAndSorting(query), OtoLttrLabelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoLttrLabels = await _unitOfWork.OtoLttrLabelsRepository.GetByIdAsync(id);

            if (OtoLttrLabels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoLttrLabelsDto = Mapper.Map(OtoLttrLabels);

            return OkResult( CustomMessage.DefaultMessage , OtoLttrLabelsDto);

        }
    }
}
