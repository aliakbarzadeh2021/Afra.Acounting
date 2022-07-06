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

namespace Afra.Api.Controllers.CmrFactHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrFactHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrFactHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrFactHdrCommand command)
        {
            command.Validate();

            var CmrFactHdrs = await _unitOfWork.CmrFactHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrFactHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrFactHdr = Mapper.Map(command);
            await _unitOfWork.CmrFactHdrRepository.AddAsync(newCmrFactHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrFactHdrCommand command)
        {

            command.Validate();

            var CmrFactHdr = await _unitOfWork.CmrFactHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrFactHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrFactHdr = Mapper.Map(CmrFactHdr, command);
            CmrFactHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrFactHdr = await _unitOfWork.CmrFactHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrFactHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrFactHdr.IsActive = false;
            CmrFactHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrFactHdrs = await _unitOfWork.CmrFactHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrFactHdrsDto = Mapper.Map(CmrFactHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrFactHdrsDto.ToPagingAndSorting(query), CmrFactHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrFactHdr = await _unitOfWork.CmrFactHdrRepository.GetByIdAsync(id);

            if (CmrFactHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrFactHdrDto = Mapper.Map(CmrFactHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrFactHdrDto);

        }
    }
}
