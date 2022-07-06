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

namespace Afra.Api.Controllers.CstPeriodsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstPeriodsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstPeriodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstPeriodsCommand command)
        {
            command.Validate();

            var CstPeriodss = await _unitOfWork.CstPeriodsRepository.FindAsync(c => c.Id == command.Id);

            if (CstPeriodss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstPeriods = Mapper.Map(command);
            await _unitOfWork.CstPeriodsRepository.AddAsync(newCstPeriods);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstPeriodsCommand command)
        {

            command.Validate();

            var CstPeriods = await _unitOfWork.CstPeriodsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstPeriods = Mapper.Map(CstPeriods, command);
            CstPeriods.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstPeriods = await _unitOfWork.CstPeriodsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstPeriods.IsActive = false;
            CstPeriods.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstPeriodss = await _unitOfWork.CstPeriodsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstPeriodssDto = Mapper.Map(CstPeriodss);

            return OkResult(CustomMessage.DefaultMessage, CstPeriodssDto.ToPagingAndSorting(query), CstPeriodssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstPeriods = await _unitOfWork.CstPeriodsRepository.GetByIdAsync(id);

            if (CstPeriods is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstPeriodsDto = Mapper.Map(CstPeriods);

            return OkResult( CustomMessage.DefaultMessage , CstPeriodsDto);

        }
    }
}
