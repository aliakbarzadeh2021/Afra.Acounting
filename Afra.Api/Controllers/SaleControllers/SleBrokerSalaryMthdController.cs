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

namespace Afra.Api.Controllers.SleBrokerSalaryMthdControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokerSalaryMthdController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokerSalaryMthdController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokerSalaryMthdCommand command)
        {
            command.Validate();

            var SleBrokerSalaryMthds = await _unitOfWork.SleBrokerSalaryMthdRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerSalaryMthds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokerSalaryMthd = Mapper.Map(command);
            await _unitOfWork.SleBrokerSalaryMthdRepository.AddAsync(newSleBrokerSalaryMthd);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokerSalaryMthdCommand command)
        {

            command.Validate();

            var SleBrokerSalaryMthd = await _unitOfWork.SleBrokerSalaryMthdRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryMthd = Mapper.Map(SleBrokerSalaryMthd, command);
            SleBrokerSalaryMthd.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokerSalaryMthd = await _unitOfWork.SleBrokerSalaryMthdRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryMthd.IsActive = false;
            SleBrokerSalaryMthd.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerSalaryMthds = await _unitOfWork.SleBrokerSalaryMthdRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerSalaryMthdsDto = Mapper.Map(SleBrokerSalaryMthds);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerSalaryMthdsDto.ToPagingAndSorting(query), SleBrokerSalaryMthdsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokerSalaryMthd = await _unitOfWork.SleBrokerSalaryMthdRepository.GetByIdAsync(id);

            if (SleBrokerSalaryMthd is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokerSalaryMthdDto = Mapper.Map(SleBrokerSalaryMthd);

            return OkResult( CustomMessage.DefaultMessage , SleBrokerSalaryMthdDto);

        }
    }
}
