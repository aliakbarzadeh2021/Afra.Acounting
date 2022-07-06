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

namespace Afra.Api.Controllers.AccGLVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccGLVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccGLVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccGLVchHdrCommand command)
        {
            command.Validate();

            var AccGLVchHdrs = await _unitOfWork.AccGLVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (AccGLVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccGLVchHdr = Mapper.Map(command);
            await _unitOfWork.AccGLVchHdrRepository.AddAsync(newAccGLVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccGLVchHdrCommand command)
        {

            command.Validate();

            var AccGLVchHdr = await _unitOfWork.AccGLVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccGLVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGLVchHdr = Mapper.Map(AccGLVchHdr, command);
            AccGLVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccGLVchHdr = await _unitOfWork.AccGLVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccGLVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGLVchHdr.IsActive = false;
            AccGLVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccGLVchHdrs = await _unitOfWork.AccGLVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccGLVchHdrsDto = Mapper.Map(AccGLVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, AccGLVchHdrsDto.ToPagingAndSorting(query), AccGLVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccGLVchHdr = await _unitOfWork.AccGLVchHdrRepository.GetByIdAsync(id);

            if (AccGLVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccGLVchHdrDto = Mapper.Map(AccGLVchHdr);

            return OkResult( CustomMessage.DefaultMessage , AccGLVchHdrDto);

        }
    }
}
