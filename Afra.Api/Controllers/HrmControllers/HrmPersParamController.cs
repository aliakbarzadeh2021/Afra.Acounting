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

namespace Afra.Api.Controllers.HrmPersParamControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersParamController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersParamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersParamCommand command)
        {
            command.Validate();

            var HrmPersParams = await _unitOfWork.HrmPersParamRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersParams.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersParam = Mapper.Map(command);
            await _unitOfWork.HrmPersParamRepository.AddAsync(newHrmPersParam);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersParamCommand command)
        {

            command.Validate();

            var HrmPersParam = await _unitOfWork.HrmPersParamRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersParam == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersParam = Mapper.Map(HrmPersParam, command);
            HrmPersParam.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersParam = await _unitOfWork.HrmPersParamRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersParam == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersParam.IsActive = false;
            HrmPersParam.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersParams = await _unitOfWork.HrmPersParamRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersParamsDto = Mapper.Map(HrmPersParams);

            return OkResult(CustomMessage.DefaultMessage, HrmPersParamsDto.ToPagingAndSorting(query), HrmPersParamsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersParam = await _unitOfWork.HrmPersParamRepository.GetByIdAsync(id);

            if (HrmPersParam is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersParamDto = Mapper.Map(HrmPersParam);

            return OkResult( CustomMessage.DefaultMessage , HrmPersParamDto);

        }
    }
}
