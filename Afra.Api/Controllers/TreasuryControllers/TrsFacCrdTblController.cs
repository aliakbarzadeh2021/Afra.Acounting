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

namespace Afra.Api.Controllers.TrsFacCrdTblControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacCrdTblController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacCrdTblController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacCrdTblCommand command)
        {
            command.Validate();

            var TrsFacCrdTbls = await _unitOfWork.TrsFacCrdTblRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacCrdTbls.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacCrdTbl = Mapper.Map(command);
            await _unitOfWork.TrsFacCrdTblRepository.AddAsync(newTrsFacCrdTbl);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacCrdTblCommand command)
        {

            command.Validate();

            var TrsFacCrdTbl = await _unitOfWork.TrsFacCrdTblRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacCrdTbl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacCrdTbl = Mapper.Map(TrsFacCrdTbl, command);
            TrsFacCrdTbl.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacCrdTbl = await _unitOfWork.TrsFacCrdTblRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacCrdTbl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacCrdTbl.IsActive = false;
            TrsFacCrdTbl.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacCrdTbls = await _unitOfWork.TrsFacCrdTblRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacCrdTblsDto = Mapper.Map(TrsFacCrdTbls);

            return OkResult(CustomMessage.DefaultMessage, TrsFacCrdTblsDto.ToPagingAndSorting(query), TrsFacCrdTblsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacCrdTbl = await _unitOfWork.TrsFacCrdTblRepository.GetByIdAsync(id);

            if (TrsFacCrdTbl is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacCrdTblDto = Mapper.Map(TrsFacCrdTbl);

            return OkResult( CustomMessage.DefaultMessage , TrsFacCrdTblDto);

        }
    }
}
