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

namespace Afra.Api.Controllers.TrsCreditTblControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsCreditTblController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsCreditTblController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsCreditTblCommand command)
        {
            command.Validate();

            var TrsCreditTbls = await _unitOfWork.TrsCreditTblRepository.FindAsync(c => c.Id == command.Id);

            if (TrsCreditTbls.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsCreditTbl = Mapper.Map(command);
            await _unitOfWork.TrsCreditTblRepository.AddAsync(newTrsCreditTbl);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsCreditTblCommand command)
        {

            command.Validate();

            var TrsCreditTbl = await _unitOfWork.TrsCreditTblRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsCreditTbl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCreditTbl = Mapper.Map(TrsCreditTbl, command);
            TrsCreditTbl.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsCreditTbl = await _unitOfWork.TrsCreditTblRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsCreditTbl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCreditTbl.IsActive = false;
            TrsCreditTbl.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsCreditTbls = await _unitOfWork.TrsCreditTblRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsCreditTblsDto = Mapper.Map(TrsCreditTbls);

            return OkResult(CustomMessage.DefaultMessage, TrsCreditTblsDto.ToPagingAndSorting(query), TrsCreditTblsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsCreditTbl = await _unitOfWork.TrsCreditTblRepository.GetByIdAsync(id);

            if (TrsCreditTbl is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsCreditTblDto = Mapper.Map(TrsCreditTbl);

            return OkResult( CustomMessage.DefaultMessage , TrsCreditTblDto);

        }
    }
}
