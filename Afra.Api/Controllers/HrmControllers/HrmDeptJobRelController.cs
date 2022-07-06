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

namespace Afra.Api.Controllers.HrmDeptJobRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmDeptJobRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmDeptJobRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmDeptJobRelCommand command)
        {
            command.Validate();

            var HrmDeptJobRels = await _unitOfWork.HrmDeptJobRelRepository.FindAsync(c => c.Id == command.Id);

            if (HrmDeptJobRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmDeptJobRel = Mapper.Map(command);
            await _unitOfWork.HrmDeptJobRelRepository.AddAsync(newHrmDeptJobRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmDeptJobRelCommand command)
        {

            command.Validate();

            var HrmDeptJobRel = await _unitOfWork.HrmDeptJobRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmDeptJobRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmDeptJobRel = Mapper.Map(HrmDeptJobRel, command);
            HrmDeptJobRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmDeptJobRel = await _unitOfWork.HrmDeptJobRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmDeptJobRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmDeptJobRel.IsActive = false;
            HrmDeptJobRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmDeptJobRels = await _unitOfWork.HrmDeptJobRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmDeptJobRelsDto = Mapper.Map(HrmDeptJobRels);

            return OkResult(CustomMessage.DefaultMessage, HrmDeptJobRelsDto.ToPagingAndSorting(query), HrmDeptJobRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmDeptJobRel = await _unitOfWork.HrmDeptJobRelRepository.GetByIdAsync(id);

            if (HrmDeptJobRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmDeptJobRelDto = Mapper.Map(HrmDeptJobRel);

            return OkResult( CustomMessage.DefaultMessage , HrmDeptJobRelDto);

        }
    }
}
