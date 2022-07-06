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

namespace Afra.Api.Controllers.HrmPersExpControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersExpController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersExpController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersExpCommand command)
        {
            command.Validate();

            var HrmPersExps = await _unitOfWork.HrmPersExpRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersExps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersExp = Mapper.Map(command);
            await _unitOfWork.HrmPersExpRepository.AddAsync(newHrmPersExp);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersExpCommand command)
        {

            command.Validate();

            var HrmPersExp = await _unitOfWork.HrmPersExpRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersExp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersExp = Mapper.Map(HrmPersExp, command);
            HrmPersExp.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersExp = await _unitOfWork.HrmPersExpRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersExp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersExp.IsActive = false;
            HrmPersExp.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersExps = await _unitOfWork.HrmPersExpRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersExpsDto = Mapper.Map(HrmPersExps);

            return OkResult(CustomMessage.DefaultMessage, HrmPersExpsDto.ToPagingAndSorting(query), HrmPersExpsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersExp = await _unitOfWork.HrmPersExpRepository.GetByIdAsync(id);

            if (HrmPersExp is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersExpDto = Mapper.Map(HrmPersExp);

            return OkResult( CustomMessage.DefaultMessage , HrmPersExpDto);

        }
    }
}
