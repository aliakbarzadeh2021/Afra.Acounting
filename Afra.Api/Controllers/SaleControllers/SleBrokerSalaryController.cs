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

namespace Afra.Api.Controllers.SleBrokerSalaryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokerSalaryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokerSalaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokerSalaryCommand command)
        {
            command.Validate();

            var SleBrokerSalarys = await _unitOfWork.SleBrokerSalaryRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerSalarys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokerSalary = Mapper.Map(command);
            await _unitOfWork.SleBrokerSalaryRepository.AddAsync(newSleBrokerSalary);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokerSalaryCommand command)
        {

            command.Validate();

            var SleBrokerSalary = await _unitOfWork.SleBrokerSalaryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalary == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalary = Mapper.Map(SleBrokerSalary, command);
            SleBrokerSalary.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokerSalary = await _unitOfWork.SleBrokerSalaryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalary == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalary.IsActive = false;
            SleBrokerSalary.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerSalarys = await _unitOfWork.SleBrokerSalaryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerSalarysDto = Mapper.Map(SleBrokerSalarys);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerSalarysDto.ToPagingAndSorting(query), SleBrokerSalarysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokerSalary = await _unitOfWork.SleBrokerSalaryRepository.GetByIdAsync(id);

            if (SleBrokerSalary is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokerSalaryDto = Mapper.Map(SleBrokerSalary);

            return OkResult( CustomMessage.DefaultMessage , SleBrokerSalaryDto);

        }
    }
}
