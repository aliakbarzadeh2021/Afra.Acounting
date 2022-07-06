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

namespace Afra.Api.Controllers.GnrRef2FormLinkHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrRef2FormLinkHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrRef2FormLinkHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrRef2FormLinkHdrCommand command)
        {
            command.Validate();

            var GnrRef2FormLinkHdrs = await _unitOfWork.GnrRef2FormLinkHdrRepository.FindAsync(c => c.Id == command.Id);

            if (GnrRef2FormLinkHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrRef2FormLinkHdr = Mapper.Map(command);
            await _unitOfWork.GnrRef2FormLinkHdrRepository.AddAsync(newGnrRef2FormLinkHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrRef2FormLinkHdrCommand command)
        {

            command.Validate();

            var GnrRef2FormLinkHdr = await _unitOfWork.GnrRef2FormLinkHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrRef2FormLinkHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRef2FormLinkHdr = Mapper.Map(GnrRef2FormLinkHdr, command);
            GnrRef2FormLinkHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrRef2FormLinkHdr = await _unitOfWork.GnrRef2FormLinkHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrRef2FormLinkHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRef2FormLinkHdr.IsActive = false;
            GnrRef2FormLinkHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrRef2FormLinkHdrs = await _unitOfWork.GnrRef2FormLinkHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrRef2FormLinkHdrsDto = Mapper.Map(GnrRef2FormLinkHdrs);

            return OkResult(CustomMessage.DefaultMessage, GnrRef2FormLinkHdrsDto.ToPagingAndSorting(query), GnrRef2FormLinkHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrRef2FormLinkHdr = await _unitOfWork.GnrRef2FormLinkHdrRepository.GetByIdAsync(id);

            if (GnrRef2FormLinkHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrRef2FormLinkHdrDto = Mapper.Map(GnrRef2FormLinkHdr);

            return OkResult( CustomMessage.DefaultMessage , GnrRef2FormLinkHdrDto);

        }
    }
}
