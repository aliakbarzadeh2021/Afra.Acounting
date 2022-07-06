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

namespace Afra.Api.Controllers.HrmGrpStatPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpStatPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpStatPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpStatPersCommand command)
        {
            command.Validate();

            var HrmGrpStatPerss = await _unitOfWork.HrmGrpStatPersRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpStatPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpStatPers = Mapper.Map(command);
            await _unitOfWork.HrmGrpStatPersRepository.AddAsync(newHrmGrpStatPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpStatPersCommand command)
        {

            command.Validate();

            var HrmGrpStatPers = await _unitOfWork.HrmGrpStatPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpStatPers = Mapper.Map(HrmGrpStatPers, command);
            HrmGrpStatPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpStatPers = await _unitOfWork.HrmGrpStatPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpStatPers.IsActive = false;
            HrmGrpStatPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpStatPerss = await _unitOfWork.HrmGrpStatPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpStatPerssDto = Mapper.Map(HrmGrpStatPerss);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpStatPerssDto.ToPagingAndSorting(query), HrmGrpStatPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpStatPers = await _unitOfWork.HrmGrpStatPersRepository.GetByIdAsync(id);

            if (HrmGrpStatPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpStatPersDto = Mapper.Map(HrmGrpStatPers);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpStatPersDto);

        }
    }
}
