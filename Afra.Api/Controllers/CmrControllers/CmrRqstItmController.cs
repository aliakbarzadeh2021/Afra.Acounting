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

namespace Afra.Api.Controllers.CmrRqstItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrRqstItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrRqstItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrRqstItmCommand command)
        {
            command.Validate();

            var CmrRqstItms = await _unitOfWork.CmrRqstItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrRqstItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrRqstItm = Mapper.Map(command);
            await _unitOfWork.CmrRqstItmRepository.AddAsync(newCmrRqstItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrRqstItmCommand command)
        {

            command.Validate();

            var CmrRqstItm = await _unitOfWork.CmrRqstItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrRqstItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRqstItm = Mapper.Map(CmrRqstItm, command);
            CmrRqstItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrRqstItm = await _unitOfWork.CmrRqstItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrRqstItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRqstItm.IsActive = false;
            CmrRqstItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrRqstItms = await _unitOfWork.CmrRqstItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrRqstItmsDto = Mapper.Map(CmrRqstItms);

            return OkResult(CustomMessage.DefaultMessage, CmrRqstItmsDto.ToPagingAndSorting(query), CmrRqstItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrRqstItm = await _unitOfWork.CmrRqstItmRepository.GetByIdAsync(id);

            if (CmrRqstItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrRqstItmDto = Mapper.Map(CmrRqstItm);

            return OkResult( CustomMessage.DefaultMessage , CmrRqstItmDto);

        }
    }
}
