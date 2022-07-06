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

namespace Afra.Api.Controllers.AccVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchHdrCommand command)
        {
            command.Validate();

            var AccVchHdrs = await _unitOfWork.AccVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchHdr = Mapper.Map(command);
            await _unitOfWork.AccVchHdrRepository.AddAsync(newAccVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchHdrCommand command)
        {

            command.Validate();

            var AccVchHdr = await _unitOfWork.AccVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchHdr = Mapper.Map(AccVchHdr, command);
            AccVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchHdr = await _unitOfWork.AccVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchHdr.IsActive = false;
            AccVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchHdrs = await _unitOfWork.AccVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchHdrsDto = Mapper.Map(AccVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, AccVchHdrsDto.ToPagingAndSorting(query), AccVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchHdr = await _unitOfWork.AccVchHdrRepository.GetByIdAsync(id);

            if (AccVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchHdrDto = Mapper.Map(AccVchHdr);

            return OkResult( CustomMessage.DefaultMessage , AccVchHdrDto);

        }
    }
}
