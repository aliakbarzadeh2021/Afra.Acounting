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

namespace Afra.Api.Controllers.CmrPOrderItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrPOrderItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrPOrderItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrPOrderItmCommand command)
        {
            command.Validate();

            var CmrPOrderItms = await _unitOfWork.CmrPOrderItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrPOrderItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrPOrderItm = Mapper.Map(command);
            await _unitOfWork.CmrPOrderItmRepository.AddAsync(newCmrPOrderItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrPOrderItmCommand command)
        {

            command.Validate();

            var CmrPOrderItm = await _unitOfWork.CmrPOrderItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrPOrderItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPOrderItm = Mapper.Map(CmrPOrderItm, command);
            CmrPOrderItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrPOrderItm = await _unitOfWork.CmrPOrderItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrPOrderItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPOrderItm.IsActive = false;
            CmrPOrderItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrPOrderItms = await _unitOfWork.CmrPOrderItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrPOrderItmsDto = Mapper.Map(CmrPOrderItms);

            return OkResult(CustomMessage.DefaultMessage, CmrPOrderItmsDto.ToPagingAndSorting(query), CmrPOrderItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrPOrderItm = await _unitOfWork.CmrPOrderItmRepository.GetByIdAsync(id);

            if (CmrPOrderItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrPOrderItmDto = Mapper.Map(CmrPOrderItm);

            return OkResult( CustomMessage.DefaultMessage , CmrPOrderItmDto);

        }
    }
}
