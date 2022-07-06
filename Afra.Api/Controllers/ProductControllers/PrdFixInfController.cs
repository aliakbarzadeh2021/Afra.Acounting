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

namespace Afra.Api.Controllers.PrdFixInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdFixInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdFixInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdFixInfCommand command)
        {
            command.Validate();

            var PrdFixInfs = await _unitOfWork.PrdFixInfRepository.FindAsync(c => c.Id == command.Id);

            if (PrdFixInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdFixInf = Mapper.Map(command);
            await _unitOfWork.PrdFixInfRepository.AddAsync(newPrdFixInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdFixInfCommand command)
        {

            command.Validate();

            var PrdFixInf = await _unitOfWork.PrdFixInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdFixInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdFixInf = Mapper.Map(PrdFixInf, command);
            PrdFixInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdFixInf = await _unitOfWork.PrdFixInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdFixInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdFixInf.IsActive = false;
            PrdFixInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdFixInfs = await _unitOfWork.PrdFixInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdFixInfsDto = Mapper.Map(PrdFixInfs);

            return OkResult(CustomMessage.DefaultMessage, PrdFixInfsDto.ToPagingAndSorting(query), PrdFixInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdFixInf = await _unitOfWork.PrdFixInfRepository.GetByIdAsync(id);

            if (PrdFixInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdFixInfDto = Mapper.Map(PrdFixInf);

            return OkResult( CustomMessage.DefaultMessage , PrdFixInfDto);

        }
    }
}
