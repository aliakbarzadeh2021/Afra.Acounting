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

namespace Afra.Api.Controllers.GnrSysQryFieldsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysQryFieldsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysQryFieldsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysQryFieldsCommand command)
        {
            command.Validate();

            var GnrSysQryFieldss = await _unitOfWork.GnrSysQryFieldsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysQryFieldss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysQryFields = Mapper.Map(command);
            await _unitOfWork.GnrSysQryFieldsRepository.AddAsync(newGnrSysQryFields);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysQryFieldsCommand command)
        {

            command.Validate();

            var GnrSysQryFields = await _unitOfWork.GnrSysQryFieldsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysQryFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysQryFields = Mapper.Map(GnrSysQryFields, command);
            GnrSysQryFields.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysQryFields = await _unitOfWork.GnrSysQryFieldsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysQryFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysQryFields.IsActive = false;
            GnrSysQryFields.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysQryFieldss = await _unitOfWork.GnrSysQryFieldsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysQryFieldssDto = Mapper.Map(GnrSysQryFieldss);

            return OkResult(CustomMessage.DefaultMessage, GnrSysQryFieldssDto.ToPagingAndSorting(query), GnrSysQryFieldssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysQryFields = await _unitOfWork.GnrSysQryFieldsRepository.GetByIdAsync(id);

            if (GnrSysQryFields is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysQryFieldsDto = Mapper.Map(GnrSysQryFields);

            return OkResult( CustomMessage.DefaultMessage , GnrSysQryFieldsDto);

        }
    }
}
