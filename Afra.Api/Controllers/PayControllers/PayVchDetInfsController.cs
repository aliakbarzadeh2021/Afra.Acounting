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

namespace Afra.Api.Controllers.PayVchDetInfsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayVchDetInfsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayVchDetInfsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayVchDetInfsCommand command)
        {
            command.Validate();

            var PayVchDetInfss = await _unitOfWork.PayVchDetInfsRepository.FindAsync(c => c.Id == command.Id);

            if (PayVchDetInfss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayVchDetInfs = Mapper.Map(command);
            await _unitOfWork.PayVchDetInfsRepository.AddAsync(newPayVchDetInfs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayVchDetInfsCommand command)
        {

            command.Validate();

            var PayVchDetInfs = await _unitOfWork.PayVchDetInfsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayVchDetInfs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchDetInfs = Mapper.Map(PayVchDetInfs, command);
            PayVchDetInfs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayVchDetInfs = await _unitOfWork.PayVchDetInfsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayVchDetInfs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchDetInfs.IsActive = false;
            PayVchDetInfs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayVchDetInfss = await _unitOfWork.PayVchDetInfsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayVchDetInfssDto = Mapper.Map(PayVchDetInfss);

            return OkResult(CustomMessage.DefaultMessage, PayVchDetInfssDto.ToPagingAndSorting(query), PayVchDetInfssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayVchDetInfs = await _unitOfWork.PayVchDetInfsRepository.GetByIdAsync(id);

            if (PayVchDetInfs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayVchDetInfsDto = Mapper.Map(PayVchDetInfs);

            return OkResult( CustomMessage.DefaultMessage , PayVchDetInfsDto);

        }
    }
}
