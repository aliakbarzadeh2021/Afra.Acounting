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

namespace Afra.Api.Controllers.CntMastersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntMastersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntMastersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntMastersCommand command)
        {
            command.Validate();

            var CntMasterss = await _unitOfWork.CntMastersRepository.FindAsync(c => c.Id == command.Id);

            if (CntMasterss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntMasters = Mapper.Map(command);
            await _unitOfWork.CntMastersRepository.AddAsync(newCntMasters);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntMastersCommand command)
        {

            command.Validate();

            var CntMasters = await _unitOfWork.CntMastersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntMasters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasters = Mapper.Map(CntMasters, command);
            CntMasters.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntMasters = await _unitOfWork.CntMastersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntMasters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasters.IsActive = false;
            CntMasters.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntMasterss = await _unitOfWork.CntMastersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntMasterssDto = Mapper.Map(CntMasterss);

            return OkResult(CustomMessage.DefaultMessage, CntMasterssDto.ToPagingAndSorting(query), CntMasterssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntMasters = await _unitOfWork.CntMastersRepository.GetByIdAsync(id);

            if (CntMasters is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntMastersDto = Mapper.Map(CntMasters);

            return OkResult( CustomMessage.DefaultMessage , CntMastersDto);

        }
    }
}
