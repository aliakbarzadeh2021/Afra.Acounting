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

namespace Afra.Api.Controllers.InvStckPeriodRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvStckPeriodRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvStckPeriodRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvStckPeriodRelsCommand command)
        {
            command.Validate();

            var InvStckPeriodRelss = await _unitOfWork.InvStckPeriodRelsRepository.FindAsync(c => c.Id == command.Id);

            if (InvStckPeriodRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvStckPeriodRels = Mapper.Map(command);
            await _unitOfWork.InvStckPeriodRelsRepository.AddAsync(newInvStckPeriodRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvStckPeriodRelsCommand command)
        {

            command.Validate();

            var InvStckPeriodRels = await _unitOfWork.InvStckPeriodRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvStckPeriodRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStckPeriodRels = Mapper.Map(InvStckPeriodRels, command);
            InvStckPeriodRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvStckPeriodRels = await _unitOfWork.InvStckPeriodRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvStckPeriodRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStckPeriodRels.IsActive = false;
            InvStckPeriodRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvStckPeriodRelss = await _unitOfWork.InvStckPeriodRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvStckPeriodRelssDto = Mapper.Map(InvStckPeriodRelss);

            return OkResult(CustomMessage.DefaultMessage, InvStckPeriodRelssDto.ToPagingAndSorting(query), InvStckPeriodRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvStckPeriodRels = await _unitOfWork.InvStckPeriodRelsRepository.GetByIdAsync(id);

            if (InvStckPeriodRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvStckPeriodRelsDto = Mapper.Map(InvStckPeriodRels);

            return OkResult( CustomMessage.DefaultMessage , InvStckPeriodRelsDto);

        }
    }
}
