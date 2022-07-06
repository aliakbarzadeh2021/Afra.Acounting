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

namespace Afra.Api.Controllers.HrmEmpTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmEmpTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmEmpTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmEmpTypesCommand command)
        {
            command.Validate();

            var HrmEmpTypess = await _unitOfWork.HrmEmpTypesRepository.FindAsync(c => c.Id == command.Id);

            if (HrmEmpTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmEmpTypes = Mapper.Map(command);
            await _unitOfWork.HrmEmpTypesRepository.AddAsync(newHrmEmpTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmEmpTypesCommand command)
        {

            command.Validate();

            var HrmEmpTypes = await _unitOfWork.HrmEmpTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmEmpTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpTypes = Mapper.Map(HrmEmpTypes, command);
            HrmEmpTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmEmpTypes = await _unitOfWork.HrmEmpTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmEmpTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpTypes.IsActive = false;
            HrmEmpTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmEmpTypess = await _unitOfWork.HrmEmpTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmEmpTypessDto = Mapper.Map(HrmEmpTypess);

            return OkResult(CustomMessage.DefaultMessage, HrmEmpTypessDto.ToPagingAndSorting(query), HrmEmpTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmEmpTypes = await _unitOfWork.HrmEmpTypesRepository.GetByIdAsync(id);

            if (HrmEmpTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmEmpTypesDto = Mapper.Map(HrmEmpTypes);

            return OkResult( CustomMessage.DefaultMessage , HrmEmpTypesDto);

        }
    }
}
