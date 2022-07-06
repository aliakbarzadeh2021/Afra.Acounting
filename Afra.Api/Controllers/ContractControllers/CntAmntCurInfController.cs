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

namespace Afra.Api.Controllers.CntAmntCurInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAmntCurInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAmntCurInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAmntCurInfCommand command)
        {
            command.Validate();

            var CntAmntCurInfs = await _unitOfWork.CntAmntCurInfRepository.FindAsync(c => c.Id == command.Id);

            if (CntAmntCurInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAmntCurInf = Mapper.Map(command);
            await _unitOfWork.CntAmntCurInfRepository.AddAsync(newCntAmntCurInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAmntCurInfCommand command)
        {

            command.Validate();

            var CntAmntCurInf = await _unitOfWork.CntAmntCurInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAmntCurInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAmntCurInf = Mapper.Map(CntAmntCurInf, command);
            CntAmntCurInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAmntCurInf = await _unitOfWork.CntAmntCurInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAmntCurInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAmntCurInf.IsActive = false;
            CntAmntCurInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAmntCurInfs = await _unitOfWork.CntAmntCurInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAmntCurInfsDto = Mapper.Map(CntAmntCurInfs);

            return OkResult(CustomMessage.DefaultMessage, CntAmntCurInfsDto.ToPagingAndSorting(query), CntAmntCurInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAmntCurInf = await _unitOfWork.CntAmntCurInfRepository.GetByIdAsync(id);

            if (CntAmntCurInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAmntCurInfDto = Mapper.Map(CntAmntCurInf);

            return OkResult( CustomMessage.DefaultMessage , CntAmntCurInfDto);

        }
    }
}
