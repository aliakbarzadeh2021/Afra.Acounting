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

namespace Afra.Api.Controllers.CntSrvPrcHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntSrvPrcHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntSrvPrcHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntSrvPrcHdrCommand command)
        {
            command.Validate();

            var CntSrvPrcHdrs = await _unitOfWork.CntSrvPrcHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CntSrvPrcHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntSrvPrcHdr = Mapper.Map(command);
            await _unitOfWork.CntSrvPrcHdrRepository.AddAsync(newCntSrvPrcHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntSrvPrcHdrCommand command)
        {

            command.Validate();

            var CntSrvPrcHdr = await _unitOfWork.CntSrvPrcHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntSrvPrcHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvPrcHdr = Mapper.Map(CntSrvPrcHdr, command);
            CntSrvPrcHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntSrvPrcHdr = await _unitOfWork.CntSrvPrcHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntSrvPrcHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvPrcHdr.IsActive = false;
            CntSrvPrcHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntSrvPrcHdrs = await _unitOfWork.CntSrvPrcHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntSrvPrcHdrsDto = Mapper.Map(CntSrvPrcHdrs);

            return OkResult(CustomMessage.DefaultMessage, CntSrvPrcHdrsDto.ToPagingAndSorting(query), CntSrvPrcHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntSrvPrcHdr = await _unitOfWork.CntSrvPrcHdrRepository.GetByIdAsync(id);

            if (CntSrvPrcHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntSrvPrcHdrDto = Mapper.Map(CntSrvPrcHdr);

            return OkResult( CustomMessage.DefaultMessage , CntSrvPrcHdrDto);

        }
    }
}
