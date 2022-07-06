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

namespace Afra.Api.Controllers.GnrUserLabelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserLabelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserLabelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserLabelsCommand command)
        {
            command.Validate();

            var GnrUserLabelss = await _unitOfWork.GnrUserLabelsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserLabelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserLabels = Mapper.Map(command);
            await _unitOfWork.GnrUserLabelsRepository.AddAsync(newGnrUserLabels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserLabelsCommand command)
        {

            command.Validate();

            var GnrUserLabels = await _unitOfWork.GnrUserLabelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserLabels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserLabels = Mapper.Map(GnrUserLabels, command);
            GnrUserLabels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserLabels = await _unitOfWork.GnrUserLabelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserLabels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserLabels.IsActive = false;
            GnrUserLabels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserLabelss = await _unitOfWork.GnrUserLabelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserLabelssDto = Mapper.Map(GnrUserLabelss);

            return OkResult(CustomMessage.DefaultMessage, GnrUserLabelssDto.ToPagingAndSorting(query), GnrUserLabelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserLabels = await _unitOfWork.GnrUserLabelsRepository.GetByIdAsync(id);

            if (GnrUserLabels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserLabelsDto = Mapper.Map(GnrUserLabels);

            return OkResult( CustomMessage.DefaultMessage , GnrUserLabelsDto);

        }
    }
}
