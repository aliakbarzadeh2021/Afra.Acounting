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

namespace Afra.Api.Controllers.CntFormValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntFormValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntFormValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntFormValsCommand command)
        {
            command.Validate();

            var CntFormValss = await _unitOfWork.CntFormValsRepository.FindAsync(c => c.Id == command.Id);

            if (CntFormValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntFormVals = Mapper.Map(command);
            await _unitOfWork.CntFormValsRepository.AddAsync(newCntFormVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntFormValsCommand command)
        {

            command.Validate();

            var CntFormVals = await _unitOfWork.CntFormValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntFormVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntFormVals = Mapper.Map(CntFormVals, command);
            CntFormVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntFormVals = await _unitOfWork.CntFormValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntFormVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntFormVals.IsActive = false;
            CntFormVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntFormValss = await _unitOfWork.CntFormValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntFormValssDto = Mapper.Map(CntFormValss);

            return OkResult(CustomMessage.DefaultMessage, CntFormValssDto.ToPagingAndSorting(query), CntFormValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntFormVals = await _unitOfWork.CntFormValsRepository.GetByIdAsync(id);

            if (CntFormVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntFormValsDto = Mapper.Map(CntFormVals);

            return OkResult( CustomMessage.DefaultMessage , CntFormValsDto);

        }
    }
}
