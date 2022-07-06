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

namespace Afra.Api.Controllers.CmrSellerGrpControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrSellerGrpController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrSellerGrpController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrSellerGrpCommand command)
        {
            command.Validate();

            var CmrSellerGrps = await _unitOfWork.CmrSellerGrpRepository.FindAsync(c => c.Id == command.Id);

            if (CmrSellerGrps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrSellerGrp = Mapper.Map(command);
            await _unitOfWork.CmrSellerGrpRepository.AddAsync(newCmrSellerGrp);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrSellerGrpCommand command)
        {

            command.Validate();

            var CmrSellerGrp = await _unitOfWork.CmrSellerGrpRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrSellerGrp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSellerGrp = Mapper.Map(CmrSellerGrp, command);
            CmrSellerGrp.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrSellerGrp = await _unitOfWork.CmrSellerGrpRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrSellerGrp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSellerGrp.IsActive = false;
            CmrSellerGrp.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrSellerGrps = await _unitOfWork.CmrSellerGrpRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrSellerGrpsDto = Mapper.Map(CmrSellerGrps);

            return OkResult(CustomMessage.DefaultMessage, CmrSellerGrpsDto.ToPagingAndSorting(query), CmrSellerGrpsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrSellerGrp = await _unitOfWork.CmrSellerGrpRepository.GetByIdAsync(id);

            if (CmrSellerGrp is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrSellerGrpDto = Mapper.Map(CmrSellerGrp);

            return OkResult( CustomMessage.DefaultMessage , CmrSellerGrpDto);

        }
    }
}
