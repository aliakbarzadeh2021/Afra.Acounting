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

namespace Afra.Api.Controllers.SleBrokerSalaryRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokerSalaryRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokerSalaryRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokerSalaryRelsCommand command)
        {
            command.Validate();

            var SleBrokerSalaryRelss = await _unitOfWork.SleBrokerSalaryRelsRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerSalaryRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokerSalaryRels = Mapper.Map(command);
            await _unitOfWork.SleBrokerSalaryRelsRepository.AddAsync(newSleBrokerSalaryRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokerSalaryRelsCommand command)
        {

            command.Validate();

            var SleBrokerSalaryRels = await _unitOfWork.SleBrokerSalaryRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryRels = Mapper.Map(SleBrokerSalaryRels, command);
            SleBrokerSalaryRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokerSalaryRels = await _unitOfWork.SleBrokerSalaryRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryRels.IsActive = false;
            SleBrokerSalaryRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerSalaryRelss = await _unitOfWork.SleBrokerSalaryRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerSalaryRelssDto = Mapper.Map(SleBrokerSalaryRelss);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerSalaryRelssDto.ToPagingAndSorting(query), SleBrokerSalaryRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokerSalaryRels = await _unitOfWork.SleBrokerSalaryRelsRepository.GetByIdAsync(id);

            if (SleBrokerSalaryRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokerSalaryRelsDto = Mapper.Map(SleBrokerSalaryRels);

            return OkResult( CustomMessage.DefaultMessage , SleBrokerSalaryRelsDto);

        }
    }
}
