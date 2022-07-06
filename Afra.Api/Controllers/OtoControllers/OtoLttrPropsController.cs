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

namespace Afra.Api.Controllers.OtoLttrPropsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoLttrPropsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoLttrPropsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoLttrPropsCommand command)
        {
            command.Validate();

            var OtoLttrPropss = await _unitOfWork.OtoLttrPropsRepository.FindAsync(c => c.Id == command.Id);

            if (OtoLttrPropss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoLttrProps = Mapper.Map(command);
            await _unitOfWork.OtoLttrPropsRepository.AddAsync(newOtoLttrProps);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoLttrPropsCommand command)
        {

            command.Validate();

            var OtoLttrProps = await _unitOfWork.OtoLttrPropsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoLttrProps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrProps = Mapper.Map(OtoLttrProps, command);
            OtoLttrProps.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoLttrProps = await _unitOfWork.OtoLttrPropsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoLttrProps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrProps.IsActive = false;
            OtoLttrProps.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoLttrPropss = await _unitOfWork.OtoLttrPropsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoLttrPropssDto = Mapper.Map(OtoLttrPropss);

            return OkResult(CustomMessage.DefaultMessage, OtoLttrPropssDto.ToPagingAndSorting(query), OtoLttrPropssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoLttrProps = await _unitOfWork.OtoLttrPropsRepository.GetByIdAsync(id);

            if (OtoLttrProps is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoLttrPropsDto = Mapper.Map(OtoLttrProps);

            return OkResult( CustomMessage.DefaultMessage , OtoLttrPropsDto);

        }
    }
}
