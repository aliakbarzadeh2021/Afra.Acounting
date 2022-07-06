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

namespace Afra.Api.Controllers.HrmBasesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmBasesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmBasesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmBasesCommand command)
        {
            command.Validate();

            var HrmBasess = await _unitOfWork.HrmBasesRepository.FindAsync(c => c.Id == command.Id);

            if (HrmBasess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmBases = Mapper.Map(command);
            await _unitOfWork.HrmBasesRepository.AddAsync(newHrmBases);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmBasesCommand command)
        {

            command.Validate();

            var HrmBases = await _unitOfWork.HrmBasesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmBases == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmBases = Mapper.Map(HrmBases, command);
            HrmBases.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmBases = await _unitOfWork.HrmBasesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmBases == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmBases.IsActive = false;
            HrmBases.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmBasess = await _unitOfWork.HrmBasesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmBasessDto = Mapper.Map(HrmBasess);

            return OkResult(CustomMessage.DefaultMessage, HrmBasessDto.ToPagingAndSorting(query), HrmBasessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmBases = await _unitOfWork.HrmBasesRepository.GetByIdAsync(id);

            if (HrmBases is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmBasesDto = Mapper.Map(HrmBases);

            return OkResult( CustomMessage.DefaultMessage , HrmBasesDto);

        }
    }
}
