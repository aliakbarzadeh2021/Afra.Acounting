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

namespace Afra.Api.Controllers.CmrPreFactHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrPreFactHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrPreFactHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrPreFactHdrCommand command)
        {
            command.Validate();

            var CmrPreFactHdrs = await _unitOfWork.CmrPreFactHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrPreFactHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrPreFactHdr = Mapper.Map(command);
            await _unitOfWork.CmrPreFactHdrRepository.AddAsync(newCmrPreFactHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrPreFactHdrCommand command)
        {

            command.Validate();

            var CmrPreFactHdr = await _unitOfWork.CmrPreFactHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrPreFactHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPreFactHdr = Mapper.Map(CmrPreFactHdr, command);
            CmrPreFactHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrPreFactHdr = await _unitOfWork.CmrPreFactHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrPreFactHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPreFactHdr.IsActive = false;
            CmrPreFactHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrPreFactHdrs = await _unitOfWork.CmrPreFactHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrPreFactHdrsDto = Mapper.Map(CmrPreFactHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrPreFactHdrsDto.ToPagingAndSorting(query), CmrPreFactHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrPreFactHdr = await _unitOfWork.CmrPreFactHdrRepository.GetByIdAsync(id);

            if (CmrPreFactHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrPreFactHdrDto = Mapper.Map(CmrPreFactHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrPreFactHdrDto);

        }
    }
}
