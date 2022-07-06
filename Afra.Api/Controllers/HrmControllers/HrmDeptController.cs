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

namespace Afra.Api.Controllers.HrmDeptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmDeptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmDeptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmDeptCommand command)
        {
            command.Validate();

            var HrmDepts = await _unitOfWork.HrmDeptRepository.FindAsync(c => c.Id == command.Id);

            if (HrmDepts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmDept = Mapper.Map(command);
            await _unitOfWork.HrmDeptRepository.AddAsync(newHrmDept);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmDeptCommand command)
        {

            command.Validate();

            var HrmDept = await _unitOfWork.HrmDeptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmDept == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmDept = Mapper.Map(HrmDept, command);
            HrmDept.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmDept = await _unitOfWork.HrmDeptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmDept == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmDept.IsActive = false;
            HrmDept.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmDepts = await _unitOfWork.HrmDeptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmDeptsDto = Mapper.Map(HrmDepts);

            return OkResult(CustomMessage.DefaultMessage, HrmDeptsDto.ToPagingAndSorting(query), HrmDeptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmDept = await _unitOfWork.HrmDeptRepository.GetByIdAsync(id);

            if (HrmDept is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmDeptDto = Mapper.Map(HrmDept);

            return OkResult( CustomMessage.DefaultMessage , HrmDeptDto);

        }
    }
}
