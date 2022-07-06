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

namespace Afra.Api.Controllers.HrmBaseAmountsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmBaseAmountsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmBaseAmountsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmBaseAmountsCommand command)
        {
            command.Validate();

            var HrmBaseAmountss = await _unitOfWork.HrmBaseAmountsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmBaseAmountss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmBaseAmounts = Mapper.Map(command);
            await _unitOfWork.HrmBaseAmountsRepository.AddAsync(newHrmBaseAmounts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmBaseAmountsCommand command)
        {

            command.Validate();

            var HrmBaseAmounts = await _unitOfWork.HrmBaseAmountsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmBaseAmounts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmBaseAmounts = Mapper.Map(HrmBaseAmounts, command);
            HrmBaseAmounts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmBaseAmounts = await _unitOfWork.HrmBaseAmountsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmBaseAmounts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmBaseAmounts.IsActive = false;
            HrmBaseAmounts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmBaseAmountss = await _unitOfWork.HrmBaseAmountsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmBaseAmountssDto = Mapper.Map(HrmBaseAmountss);

            return OkResult(CustomMessage.DefaultMessage, HrmBaseAmountssDto.ToPagingAndSorting(query), HrmBaseAmountssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmBaseAmounts = await _unitOfWork.HrmBaseAmountsRepository.GetByIdAsync(id);

            if (HrmBaseAmounts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmBaseAmountsDto = Mapper.Map(HrmBaseAmounts);

            return OkResult( CustomMessage.DefaultMessage , HrmBaseAmountsDto);

        }
    }
}
