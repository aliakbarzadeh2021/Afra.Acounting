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

namespace Afra.Api.Controllers.QcsVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsVchHdrCommand command)
        {
            command.Validate();

            var QcsVchHdrs = await _unitOfWork.QcsVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (QcsVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsVchHdr = Mapper.Map(command);
            await _unitOfWork.QcsVchHdrRepository.AddAsync(newQcsVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsVchHdrCommand command)
        {

            command.Validate();

            var QcsVchHdr = await _unitOfWork.QcsVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsVchHdr = Mapper.Map(QcsVchHdr, command);
            QcsVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsVchHdr = await _unitOfWork.QcsVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsVchHdr.IsActive = false;
            QcsVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsVchHdrs = await _unitOfWork.QcsVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsVchHdrsDto = Mapper.Map(QcsVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, QcsVchHdrsDto.ToPagingAndSorting(query), QcsVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsVchHdr = await _unitOfWork.QcsVchHdrRepository.GetByIdAsync(id);

            if (QcsVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsVchHdrDto = Mapper.Map(QcsVchHdr);

            return OkResult( CustomMessage.DefaultMessage , QcsVchHdrDto);

        }
    }
}
