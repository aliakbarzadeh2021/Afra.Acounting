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

namespace Afra.Api.Controllers.CntExpAcntCostCntrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAcntCostCntrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAcntCostCntrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAcntCostCntrCommand command)
        {
            command.Validate();

            var CntExpAcntCostCntrs = await _unitOfWork.CntExpAcntCostCntrRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAcntCostCntrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAcntCostCntr = Mapper.Map(command);
            await _unitOfWork.CntExpAcntCostCntrRepository.AddAsync(newCntExpAcntCostCntr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAcntCostCntrCommand command)
        {

            command.Validate();

            var CntExpAcntCostCntr = await _unitOfWork.CntExpAcntCostCntrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntCostCntr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntCostCntr = Mapper.Map(CntExpAcntCostCntr, command);
            CntExpAcntCostCntr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAcntCostCntr = await _unitOfWork.CntExpAcntCostCntrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntCostCntr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntCostCntr.IsActive = false;
            CntExpAcntCostCntr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAcntCostCntrs = await _unitOfWork.CntExpAcntCostCntrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAcntCostCntrsDto = Mapper.Map(CntExpAcntCostCntrs);

            return OkResult(CustomMessage.DefaultMessage, CntExpAcntCostCntrsDto.ToPagingAndSorting(query), CntExpAcntCostCntrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAcntCostCntr = await _unitOfWork.CntExpAcntCostCntrRepository.GetByIdAsync(id);

            if (CntExpAcntCostCntr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAcntCostCntrDto = Mapper.Map(CntExpAcntCostCntr);

            return OkResult( CustomMessage.DefaultMessage , CntExpAcntCostCntrDto);

        }
    }
}
