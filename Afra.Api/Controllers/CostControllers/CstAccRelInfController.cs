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

namespace Afra.Api.Controllers.CstAccRelInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstAccRelInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstAccRelInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstAccRelInfCommand command)
        {
            command.Validate();

            var CstAccRelInfs = await _unitOfWork.CstAccRelInfRepository.FindAsync(c => c.Id == command.Id);

            if (CstAccRelInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstAccRelInf = Mapper.Map(command);
            await _unitOfWork.CstAccRelInfRepository.AddAsync(newCstAccRelInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstAccRelInfCommand command)
        {

            command.Validate();

            var CstAccRelInf = await _unitOfWork.CstAccRelInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstAccRelInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstAccRelInf = Mapper.Map(CstAccRelInf, command);
            CstAccRelInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstAccRelInf = await _unitOfWork.CstAccRelInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstAccRelInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstAccRelInf.IsActive = false;
            CstAccRelInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstAccRelInfs = await _unitOfWork.CstAccRelInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstAccRelInfsDto = Mapper.Map(CstAccRelInfs);

            return OkResult(CustomMessage.DefaultMessage, CstAccRelInfsDto.ToPagingAndSorting(query), CstAccRelInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstAccRelInf = await _unitOfWork.CstAccRelInfRepository.GetByIdAsync(id);

            if (CstAccRelInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstAccRelInfDto = Mapper.Map(CstAccRelInf);

            return OkResult( CustomMessage.DefaultMessage , CstAccRelInfDto);

        }
    }
}
