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

namespace Afra.Api.Controllers.TrsFacTypeInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacTypeInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacTypeInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacTypeInfCommand command)
        {
            command.Validate();

            var TrsFacTypeInfs = await _unitOfWork.TrsFacTypeInfRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacTypeInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacTypeInf = Mapper.Map(command);
            await _unitOfWork.TrsFacTypeInfRepository.AddAsync(newTrsFacTypeInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacTypeInfCommand command)
        {

            command.Validate();

            var TrsFacTypeInf = await _unitOfWork.TrsFacTypeInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacTypeInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacTypeInf = Mapper.Map(TrsFacTypeInf, command);
            TrsFacTypeInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacTypeInf = await _unitOfWork.TrsFacTypeInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacTypeInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacTypeInf.IsActive = false;
            TrsFacTypeInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacTypeInfs = await _unitOfWork.TrsFacTypeInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacTypeInfsDto = Mapper.Map(TrsFacTypeInfs);

            return OkResult(CustomMessage.DefaultMessage, TrsFacTypeInfsDto.ToPagingAndSorting(query), TrsFacTypeInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacTypeInf = await _unitOfWork.TrsFacTypeInfRepository.GetByIdAsync(id);

            if (TrsFacTypeInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacTypeInfDto = Mapper.Map(TrsFacTypeInf);

            return OkResult( CustomMessage.DefaultMessage , TrsFacTypeInfDto);

        }
    }
}
