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

namespace Afra.Api.Controllers.CmrPOrderHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrPOrderHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrPOrderHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrPOrderHdrCommand command)
        {
            command.Validate();

            var CmrPOrderHdrs = await _unitOfWork.CmrPOrderHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrPOrderHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrPOrderHdr = Mapper.Map(command);
            await _unitOfWork.CmrPOrderHdrRepository.AddAsync(newCmrPOrderHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrPOrderHdrCommand command)
        {

            command.Validate();

            var CmrPOrderHdr = await _unitOfWork.CmrPOrderHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrPOrderHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPOrderHdr = Mapper.Map(CmrPOrderHdr, command);
            CmrPOrderHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrPOrderHdr = await _unitOfWork.CmrPOrderHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrPOrderHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPOrderHdr.IsActive = false;
            CmrPOrderHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrPOrderHdrs = await _unitOfWork.CmrPOrderHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrPOrderHdrsDto = Mapper.Map(CmrPOrderHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrPOrderHdrsDto.ToPagingAndSorting(query), CmrPOrderHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrPOrderHdr = await _unitOfWork.CmrPOrderHdrRepository.GetByIdAsync(id);

            if (CmrPOrderHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrPOrderHdrDto = Mapper.Map(CmrPOrderHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrPOrderHdrDto);

        }
    }
}
