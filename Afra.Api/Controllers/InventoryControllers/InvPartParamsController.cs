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

namespace Afra.Api.Controllers.InvPartParamsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartParamsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartParamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartParamsCommand command)
        {
            command.Validate();

            var InvPartParamss = await _unitOfWork.InvPartParamsRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartParamss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartParams = Mapper.Map(command);
            await _unitOfWork.InvPartParamsRepository.AddAsync(newInvPartParams);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartParamsCommand command)
        {

            command.Validate();

            var InvPartParams = await _unitOfWork.InvPartParamsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartParams == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartParams = Mapper.Map(InvPartParams, command);
            InvPartParams.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartParams = await _unitOfWork.InvPartParamsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartParams == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartParams.IsActive = false;
            InvPartParams.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartParamss = await _unitOfWork.InvPartParamsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartParamssDto = Mapper.Map(InvPartParamss);

            return OkResult(CustomMessage.DefaultMessage, InvPartParamssDto.ToPagingAndSorting(query), InvPartParamssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartParams = await _unitOfWork.InvPartParamsRepository.GetByIdAsync(id);

            if (InvPartParams is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartParamsDto = Mapper.Map(InvPartParams);

            return OkResult( CustomMessage.DefaultMessage , InvPartParamsDto);

        }
    }
}
