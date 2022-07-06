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

namespace Afra.Api.Controllers.CmrContHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrContHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrContHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrContHdrCommand command)
        {
            command.Validate();

            var CmrContHdrs = await _unitOfWork.CmrContHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrContHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrContHdr = Mapper.Map(command);
            await _unitOfWork.CmrContHdrRepository.AddAsync(newCmrContHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrContHdrCommand command)
        {

            command.Validate();

            var CmrContHdr = await _unitOfWork.CmrContHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrContHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrContHdr = Mapper.Map(CmrContHdr, command);
            CmrContHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrContHdr = await _unitOfWork.CmrContHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrContHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrContHdr.IsActive = false;
            CmrContHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrContHdrs = await _unitOfWork.CmrContHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrContHdrsDto = Mapper.Map(CmrContHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrContHdrsDto.ToPagingAndSorting(query), CmrContHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrContHdr = await _unitOfWork.CmrContHdrRepository.GetByIdAsync(id);

            if (CmrContHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrContHdrDto = Mapper.Map(CmrContHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrContHdrDto);

        }
    }
}
