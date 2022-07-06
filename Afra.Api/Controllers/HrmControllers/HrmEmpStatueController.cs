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

namespace Afra.Api.Controllers.HrmEmpStatueControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmEmpStatueController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmEmpStatueController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmEmpStatueCommand command)
        {
            command.Validate();

            var HrmEmpStatues = await _unitOfWork.HrmEmpStatueRepository.FindAsync(c => c.Id == command.Id);

            if (HrmEmpStatues.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmEmpStatue = Mapper.Map(command);
            await _unitOfWork.HrmEmpStatueRepository.AddAsync(newHrmEmpStatue);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmEmpStatueCommand command)
        {

            command.Validate();

            var HrmEmpStatue = await _unitOfWork.HrmEmpStatueRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmEmpStatue == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpStatue = Mapper.Map(HrmEmpStatue, command);
            HrmEmpStatue.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmEmpStatue = await _unitOfWork.HrmEmpStatueRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmEmpStatue == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpStatue.IsActive = false;
            HrmEmpStatue.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmEmpStatues = await _unitOfWork.HrmEmpStatueRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmEmpStatuesDto = Mapper.Map(HrmEmpStatues);

            return OkResult(CustomMessage.DefaultMessage, HrmEmpStatuesDto.ToPagingAndSorting(query), HrmEmpStatuesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmEmpStatue = await _unitOfWork.HrmEmpStatueRepository.GetByIdAsync(id);

            if (HrmEmpStatue is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmEmpStatueDto = Mapper.Map(HrmEmpStatue);

            return OkResult( CustomMessage.DefaultMessage , HrmEmpStatueDto);

        }
    }
}
