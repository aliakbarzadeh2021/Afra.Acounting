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

namespace Afra.Api.Controllers.HrmPersEduControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersEduController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersEduController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersEduCommand command)
        {
            command.Validate();

            var HrmPersEdus = await _unitOfWork.HrmPersEduRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersEdus.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersEdu = Mapper.Map(command);
            await _unitOfWork.HrmPersEduRepository.AddAsync(newHrmPersEdu);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersEduCommand command)
        {

            command.Validate();

            var HrmPersEdu = await _unitOfWork.HrmPersEduRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersEdu == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersEdu = Mapper.Map(HrmPersEdu, command);
            HrmPersEdu.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersEdu = await _unitOfWork.HrmPersEduRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersEdu == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersEdu.IsActive = false;
            HrmPersEdu.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersEdus = await _unitOfWork.HrmPersEduRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersEdusDto = Mapper.Map(HrmPersEdus);

            return OkResult(CustomMessage.DefaultMessage, HrmPersEdusDto.ToPagingAndSorting(query), HrmPersEdusDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersEdu = await _unitOfWork.HrmPersEduRepository.GetByIdAsync(id);

            if (HrmPersEdu is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersEduDto = Mapper.Map(HrmPersEdu);

            return OkResult( CustomMessage.DefaultMessage , HrmPersEduDto);

        }
    }
}
