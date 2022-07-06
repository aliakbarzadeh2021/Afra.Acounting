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

namespace Afra.Api.Controllers.HrmGrpParamStatPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpParamStatPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpParamStatPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpParamStatPersCommand command)
        {
            command.Validate();

            var HrmGrpParamStatPerss = await _unitOfWork.HrmGrpParamStatPersRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpParamStatPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpParamStatPers = Mapper.Map(command);
            await _unitOfWork.HrmGrpParamStatPersRepository.AddAsync(newHrmGrpParamStatPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpParamStatPersCommand command)
        {

            command.Validate();

            var HrmGrpParamStatPers = await _unitOfWork.HrmGrpParamStatPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStatPers = Mapper.Map(HrmGrpParamStatPers, command);
            HrmGrpParamStatPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpParamStatPers = await _unitOfWork.HrmGrpParamStatPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStatPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStatPers.IsActive = false;
            HrmGrpParamStatPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpParamStatPerss = await _unitOfWork.HrmGrpParamStatPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpParamStatPerssDto = Mapper.Map(HrmGrpParamStatPerss);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpParamStatPerssDto.ToPagingAndSorting(query), HrmGrpParamStatPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpParamStatPers = await _unitOfWork.HrmGrpParamStatPersRepository.GetByIdAsync(id);

            if (HrmGrpParamStatPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpParamStatPersDto = Mapper.Map(HrmGrpParamStatPers);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpParamStatPersDto);

        }
    }
}
