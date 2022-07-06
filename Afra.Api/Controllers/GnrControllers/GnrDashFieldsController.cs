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

namespace Afra.Api.Controllers.GnrDashFieldsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrDashFieldsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrDashFieldsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrDashFieldsCommand command)
        {
            command.Validate();

            var GnrDashFieldss = await _unitOfWork.GnrDashFieldsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrDashFieldss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrDashFields = Mapper.Map(command);
            await _unitOfWork.GnrDashFieldsRepository.AddAsync(newGnrDashFields);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrDashFieldsCommand command)
        {

            command.Validate();

            var GnrDashFields = await _unitOfWork.GnrDashFieldsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrDashFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrDashFields = Mapper.Map(GnrDashFields, command);
            GnrDashFields.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrDashFields = await _unitOfWork.GnrDashFieldsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrDashFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrDashFields.IsActive = false;
            GnrDashFields.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrDashFieldss = await _unitOfWork.GnrDashFieldsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrDashFieldssDto = Mapper.Map(GnrDashFieldss);

            return OkResult(CustomMessage.DefaultMessage, GnrDashFieldssDto.ToPagingAndSorting(query), GnrDashFieldssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrDashFields = await _unitOfWork.GnrDashFieldsRepository.GetByIdAsync(id);

            if (GnrDashFields is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrDashFieldsDto = Mapper.Map(GnrDashFields);

            return OkResult( CustomMessage.DefaultMessage , GnrDashFieldsDto);

        }
    }
}
