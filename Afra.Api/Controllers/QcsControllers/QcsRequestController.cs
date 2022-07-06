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

namespace Afra.Api.Controllers.QcsRequestControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsRequestController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsRequestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsRequestCommand command)
        {
            command.Validate();

            var QcsRequests = await _unitOfWork.QcsRequestRepository.FindAsync(c => c.Id == command.Id);

            if (QcsRequests.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsRequest = Mapper.Map(command);
            await _unitOfWork.QcsRequestRepository.AddAsync(newQcsRequest);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsRequestCommand command)
        {

            command.Validate();

            var QcsRequest = await _unitOfWork.QcsRequestRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsRequest == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsRequest = Mapper.Map(QcsRequest, command);
            QcsRequest.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsRequest = await _unitOfWork.QcsRequestRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsRequest == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsRequest.IsActive = false;
            QcsRequest.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsRequests = await _unitOfWork.QcsRequestRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsRequestsDto = Mapper.Map(QcsRequests);

            return OkResult(CustomMessage.DefaultMessage, QcsRequestsDto.ToPagingAndSorting(query), QcsRequestsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsRequest = await _unitOfWork.QcsRequestRepository.GetByIdAsync(id);

            if (QcsRequest is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsRequestDto = Mapper.Map(QcsRequest);

            return OkResult( CustomMessage.DefaultMessage , QcsRequestDto);

        }
    }
}
