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

namespace Afra.Api.Controllers.CmrSendItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrSendItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrSendItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrSendItmCommand command)
        {
            command.Validate();

            var CmrSendItms = await _unitOfWork.CmrSendItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrSendItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrSendItm = Mapper.Map(command);
            await _unitOfWork.CmrSendItmRepository.AddAsync(newCmrSendItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrSendItmCommand command)
        {

            command.Validate();

            var CmrSendItm = await _unitOfWork.CmrSendItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrSendItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSendItm = Mapper.Map(CmrSendItm, command);
            CmrSendItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrSendItm = await _unitOfWork.CmrSendItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrSendItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSendItm.IsActive = false;
            CmrSendItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrSendItms = await _unitOfWork.CmrSendItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrSendItmsDto = Mapper.Map(CmrSendItms);

            return OkResult(CustomMessage.DefaultMessage, CmrSendItmsDto.ToPagingAndSorting(query), CmrSendItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrSendItm = await _unitOfWork.CmrSendItmRepository.GetByIdAsync(id);

            if (CmrSendItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrSendItmDto = Mapper.Map(CmrSendItm);

            return OkResult( CustomMessage.DefaultMessage , CmrSendItmDto);

        }
    }
}
