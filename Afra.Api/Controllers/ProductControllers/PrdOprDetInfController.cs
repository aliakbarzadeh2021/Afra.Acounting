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

namespace Afra.Api.Controllers.PrdOprDetInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOprDetInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOprDetInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOprDetInfCommand command)
        {
            command.Validate();

            var PrdOprDetInfs = await _unitOfWork.PrdOprDetInfRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOprDetInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOprDetInf = Mapper.Map(command);
            await _unitOfWork.PrdOprDetInfRepository.AddAsync(newPrdOprDetInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOprDetInfCommand command)
        {

            command.Validate();

            var PrdOprDetInf = await _unitOfWork.PrdOprDetInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOprDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDetInf = Mapper.Map(PrdOprDetInf, command);
            PrdOprDetInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOprDetInf = await _unitOfWork.PrdOprDetInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOprDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDetInf.IsActive = false;
            PrdOprDetInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOprDetInfs = await _unitOfWork.PrdOprDetInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOprDetInfsDto = Mapper.Map(PrdOprDetInfs);

            return OkResult(CustomMessage.DefaultMessage, PrdOprDetInfsDto.ToPagingAndSorting(query), PrdOprDetInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOprDetInf = await _unitOfWork.PrdOprDetInfRepository.GetByIdAsync(id);

            if (PrdOprDetInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOprDetInfDto = Mapper.Map(PrdOprDetInf);

            return OkResult( CustomMessage.DefaultMessage , PrdOprDetInfDto);

        }
    }
}
