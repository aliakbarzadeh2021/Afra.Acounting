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

namespace Afra.Api.Controllers.HrmPersSldrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersSldrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersSldrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersSldrCommand command)
        {
            command.Validate();

            var HrmPersSldrs = await _unitOfWork.HrmPersSldrRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersSldrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersSldr = Mapper.Map(command);
            await _unitOfWork.HrmPersSldrRepository.AddAsync(newHrmPersSldr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersSldrCommand command)
        {

            command.Validate();

            var HrmPersSldr = await _unitOfWork.HrmPersSldrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersSldr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersSldr = Mapper.Map(HrmPersSldr, command);
            HrmPersSldr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersSldr = await _unitOfWork.HrmPersSldrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersSldr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersSldr.IsActive = false;
            HrmPersSldr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersSldrs = await _unitOfWork.HrmPersSldrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersSldrsDto = Mapper.Map(HrmPersSldrs);

            return OkResult(CustomMessage.DefaultMessage, HrmPersSldrsDto.ToPagingAndSorting(query), HrmPersSldrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersSldr = await _unitOfWork.HrmPersSldrRepository.GetByIdAsync(id);

            if (HrmPersSldr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersSldrDto = Mapper.Map(HrmPersSldr);

            return OkResult( CustomMessage.DefaultMessage , HrmPersSldrDto);

        }
    }
}
