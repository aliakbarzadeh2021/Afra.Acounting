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

namespace Afra.Api.Controllers.PayElmntRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayElmntRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayElmntRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayElmntRelsCommand command)
        {
            command.Validate();

            var PayElmntRelss = await _unitOfWork.PayElmntRelsRepository.FindAsync(c => c.Id == command.Id);

            if (PayElmntRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayElmntRels = Mapper.Map(command);
            await _unitOfWork.PayElmntRelsRepository.AddAsync(newPayElmntRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayElmntRelsCommand command)
        {

            command.Validate();

            var PayElmntRels = await _unitOfWork.PayElmntRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayElmntRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayElmntRels = Mapper.Map(PayElmntRels, command);
            PayElmntRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayElmntRels = await _unitOfWork.PayElmntRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayElmntRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayElmntRels.IsActive = false;
            PayElmntRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayElmntRelss = await _unitOfWork.PayElmntRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayElmntRelssDto = Mapper.Map(PayElmntRelss);

            return OkResult(CustomMessage.DefaultMessage, PayElmntRelssDto.ToPagingAndSorting(query), PayElmntRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayElmntRels = await _unitOfWork.PayElmntRelsRepository.GetByIdAsync(id);

            if (PayElmntRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayElmntRelsDto = Mapper.Map(PayElmntRels);

            return OkResult( CustomMessage.DefaultMessage , PayElmntRelsDto);

        }
    }
}
