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

namespace Afra.Api.Controllers.CmrReleaseItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrReleaseItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrReleaseItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrReleaseItmCommand command)
        {
            command.Validate();

            var CmrReleaseItms = await _unitOfWork.CmrReleaseItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrReleaseItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrReleaseItm = Mapper.Map(command);
            await _unitOfWork.CmrReleaseItmRepository.AddAsync(newCmrReleaseItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrReleaseItmCommand command)
        {

            command.Validate();

            var CmrReleaseItm = await _unitOfWork.CmrReleaseItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseItm = Mapper.Map(CmrReleaseItm, command);
            CmrReleaseItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrReleaseItm = await _unitOfWork.CmrReleaseItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseItm.IsActive = false;
            CmrReleaseItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrReleaseItms = await _unitOfWork.CmrReleaseItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrReleaseItmsDto = Mapper.Map(CmrReleaseItms);

            return OkResult(CustomMessage.DefaultMessage, CmrReleaseItmsDto.ToPagingAndSorting(query), CmrReleaseItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrReleaseItm = await _unitOfWork.CmrReleaseItmRepository.GetByIdAsync(id);

            if (CmrReleaseItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrReleaseItmDto = Mapper.Map(CmrReleaseItm);

            return OkResult( CustomMessage.DefaultMessage , CmrReleaseItmDto);

        }
    }
}
