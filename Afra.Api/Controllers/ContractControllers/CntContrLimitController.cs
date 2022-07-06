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

namespace Afra.Api.Controllers.CntContrLimitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContrLimitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContrLimitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContrLimitCommand command)
        {
            command.Validate();

            var CntContrLimits = await _unitOfWork.CntContrLimitRepository.FindAsync(c => c.Id == command.Id);

            if (CntContrLimits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContrLimit = Mapper.Map(command);
            await _unitOfWork.CntContrLimitRepository.AddAsync(newCntContrLimit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContrLimitCommand command)
        {

            command.Validate();

            var CntContrLimit = await _unitOfWork.CntContrLimitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContrLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContrLimit = Mapper.Map(CntContrLimit, command);
            CntContrLimit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContrLimit = await _unitOfWork.CntContrLimitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContrLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContrLimit.IsActive = false;
            CntContrLimit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContrLimits = await _unitOfWork.CntContrLimitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContrLimitsDto = Mapper.Map(CntContrLimits);

            return OkResult(CustomMessage.DefaultMessage, CntContrLimitsDto.ToPagingAndSorting(query), CntContrLimitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContrLimit = await _unitOfWork.CntContrLimitRepository.GetByIdAsync(id);

            if (CntContrLimit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContrLimitDto = Mapper.Map(CntContrLimit);

            return OkResult( CustomMessage.DefaultMessage , CntContrLimitDto);

        }
    }
}
