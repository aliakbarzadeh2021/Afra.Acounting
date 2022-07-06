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

namespace Afra.Api.Controllers.HrmVacMthodsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmVacMthodsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmVacMthodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmVacMthodsCommand command)
        {
            command.Validate();

            var HrmVacMthodss = await _unitOfWork.HrmVacMthodsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmVacMthodss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmVacMthods = Mapper.Map(command);
            await _unitOfWork.HrmVacMthodsRepository.AddAsync(newHrmVacMthods);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmVacMthodsCommand command)
        {

            command.Validate();

            var HrmVacMthods = await _unitOfWork.HrmVacMthodsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmVacMthods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmVacMthods = Mapper.Map(HrmVacMthods, command);
            HrmVacMthods.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmVacMthods = await _unitOfWork.HrmVacMthodsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmVacMthods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmVacMthods.IsActive = false;
            HrmVacMthods.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmVacMthodss = await _unitOfWork.HrmVacMthodsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmVacMthodssDto = Mapper.Map(HrmVacMthodss);

            return OkResult(CustomMessage.DefaultMessage, HrmVacMthodssDto.ToPagingAndSorting(query), HrmVacMthodssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmVacMthods = await _unitOfWork.HrmVacMthodsRepository.GetByIdAsync(id);

            if (HrmVacMthods is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmVacMthodsDto = Mapper.Map(HrmVacMthods);

            return OkResult( CustomMessage.DefaultMessage , HrmVacMthodsDto);

        }
    }
}
