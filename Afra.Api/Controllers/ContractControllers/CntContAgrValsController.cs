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

namespace Afra.Api.Controllers.CntContAgrValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContAgrValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContAgrValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContAgrValsCommand command)
        {
            command.Validate();

            var CntContAgrValss = await _unitOfWork.CntContAgrValsRepository.FindAsync(c => c.Id == command.Id);

            if (CntContAgrValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContAgrVals = Mapper.Map(command);
            await _unitOfWork.CntContAgrValsRepository.AddAsync(newCntContAgrVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContAgrValsCommand command)
        {

            command.Validate();

            var CntContAgrVals = await _unitOfWork.CntContAgrValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContAgrVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContAgrVals = Mapper.Map(CntContAgrVals, command);
            CntContAgrVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContAgrVals = await _unitOfWork.CntContAgrValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContAgrVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContAgrVals.IsActive = false;
            CntContAgrVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContAgrValss = await _unitOfWork.CntContAgrValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContAgrValssDto = Mapper.Map(CntContAgrValss);

            return OkResult(CustomMessage.DefaultMessage, CntContAgrValssDto.ToPagingAndSorting(query), CntContAgrValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContAgrVals = await _unitOfWork.CntContAgrValsRepository.GetByIdAsync(id);

            if (CntContAgrVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContAgrValsDto = Mapper.Map(CntContAgrVals);

            return OkResult( CustomMessage.DefaultMessage , CntContAgrValsDto);

        }
    }
}
