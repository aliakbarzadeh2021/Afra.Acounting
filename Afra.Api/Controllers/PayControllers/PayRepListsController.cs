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

namespace Afra.Api.Controllers.PayRepListsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayRepListsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayRepListsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayRepListsCommand command)
        {
            command.Validate();

            var PayRepListss = await _unitOfWork.PayRepListsRepository.FindAsync(c => c.Id == command.Id);

            if (PayRepListss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayRepLists = Mapper.Map(command);
            await _unitOfWork.PayRepListsRepository.AddAsync(newPayRepLists);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayRepListsCommand command)
        {

            command.Validate();

            var PayRepLists = await _unitOfWork.PayRepListsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayRepLists == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayRepLists = Mapper.Map(PayRepLists, command);
            PayRepLists.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayRepLists = await _unitOfWork.PayRepListsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayRepLists == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayRepLists.IsActive = false;
            PayRepLists.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayRepListss = await _unitOfWork.PayRepListsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayRepListssDto = Mapper.Map(PayRepListss);

            return OkResult(CustomMessage.DefaultMessage, PayRepListssDto.ToPagingAndSorting(query), PayRepListssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayRepLists = await _unitOfWork.PayRepListsRepository.GetByIdAsync(id);

            if (PayRepLists is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayRepListsDto = Mapper.Map(PayRepLists);

            return OkResult( CustomMessage.DefaultMessage , PayRepListsDto);

        }
    }
}
