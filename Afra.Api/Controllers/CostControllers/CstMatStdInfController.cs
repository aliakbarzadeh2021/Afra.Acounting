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

namespace Afra.Api.Controllers.CstMatStdInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstMatStdInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstMatStdInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstMatStdInfCommand command)
        {
            command.Validate();

            var CstMatStdInfs = await _unitOfWork.CstMatStdInfRepository.FindAsync(c => c.Id == command.Id);

            if (CstMatStdInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstMatStdInf = Mapper.Map(command);
            await _unitOfWork.CstMatStdInfRepository.AddAsync(newCstMatStdInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstMatStdInfCommand command)
        {

            command.Validate();

            var CstMatStdInf = await _unitOfWork.CstMatStdInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstMatStdInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatStdInf = Mapper.Map(CstMatStdInf, command);
            CstMatStdInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstMatStdInf = await _unitOfWork.CstMatStdInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstMatStdInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatStdInf.IsActive = false;
            CstMatStdInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstMatStdInfs = await _unitOfWork.CstMatStdInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstMatStdInfsDto = Mapper.Map(CstMatStdInfs);

            return OkResult(CustomMessage.DefaultMessage, CstMatStdInfsDto.ToPagingAndSorting(query), CstMatStdInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstMatStdInf = await _unitOfWork.CstMatStdInfRepository.GetByIdAsync(id);

            if (CstMatStdInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstMatStdInfDto = Mapper.Map(CstMatStdInf);

            return OkResult( CustomMessage.DefaultMessage , CstMatStdInfDto);

        }
    }
}
