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

namespace Afra.Api.Controllers.HrmJobsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmJobsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmJobsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmJobsCommand command)
        {
            command.Validate();

            var HrmJobss = await _unitOfWork.HrmJobsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmJobss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmJobs = Mapper.Map(command);
            await _unitOfWork.HrmJobsRepository.AddAsync(newHrmJobs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmJobsCommand command)
        {

            command.Validate();

            var HrmJobs = await _unitOfWork.HrmJobsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmJobs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmJobs = Mapper.Map(HrmJobs, command);
            HrmJobs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmJobs = await _unitOfWork.HrmJobsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmJobs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmJobs.IsActive = false;
            HrmJobs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmJobss = await _unitOfWork.HrmJobsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmJobssDto = Mapper.Map(HrmJobss);

            return OkResult(CustomMessage.DefaultMessage, HrmJobssDto.ToPagingAndSorting(query), HrmJobssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmJobs = await _unitOfWork.HrmJobsRepository.GetByIdAsync(id);

            if (HrmJobs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmJobsDto = Mapper.Map(HrmJobs);

            return OkResult( CustomMessage.DefaultMessage , HrmJobsDto);

        }
    }
}
