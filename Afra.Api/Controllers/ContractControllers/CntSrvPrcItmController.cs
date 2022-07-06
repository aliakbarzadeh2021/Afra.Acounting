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

namespace Afra.Api.Controllers.CntSrvPrcItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntSrvPrcItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntSrvPrcItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntSrvPrcItmCommand command)
        {
            command.Validate();

            var CntSrvPrcItms = await _unitOfWork.CntSrvPrcItmRepository.FindAsync(c => c.Id == command.Id);

            if (CntSrvPrcItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntSrvPrcItm = Mapper.Map(command);
            await _unitOfWork.CntSrvPrcItmRepository.AddAsync(newCntSrvPrcItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntSrvPrcItmCommand command)
        {

            command.Validate();

            var CntSrvPrcItm = await _unitOfWork.CntSrvPrcItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntSrvPrcItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvPrcItm = Mapper.Map(CntSrvPrcItm, command);
            CntSrvPrcItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntSrvPrcItm = await _unitOfWork.CntSrvPrcItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntSrvPrcItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvPrcItm.IsActive = false;
            CntSrvPrcItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntSrvPrcItms = await _unitOfWork.CntSrvPrcItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntSrvPrcItmsDto = Mapper.Map(CntSrvPrcItms);

            return OkResult(CustomMessage.DefaultMessage, CntSrvPrcItmsDto.ToPagingAndSorting(query), CntSrvPrcItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntSrvPrcItm = await _unitOfWork.CntSrvPrcItmRepository.GetByIdAsync(id);

            if (CntSrvPrcItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntSrvPrcItmDto = Mapper.Map(CntSrvPrcItm);

            return OkResult( CustomMessage.DefaultMessage , CntSrvPrcItmDto);

        }
    }
}
