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

namespace Afra.Api.Controllers.UsrBuyServiceDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrBuyServiceDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrBuyServiceDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrBuyServiceDetCommand command)
        {
            command.Validate();

            var UsrBuyServiceDets = await _unitOfWork.UsrBuyServiceDetRepository.FindAsync(c => c.Id == command.Id);

            if (UsrBuyServiceDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrBuyServiceDet = Mapper.Map(command);
            await _unitOfWork.UsrBuyServiceDetRepository.AddAsync(newUsrBuyServiceDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrBuyServiceDetCommand command)
        {

            command.Validate();

            var UsrBuyServiceDet = await _unitOfWork.UsrBuyServiceDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrBuyServiceDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrBuyServiceDet = Mapper.Map(UsrBuyServiceDet, command);
            UsrBuyServiceDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrBuyServiceDet = await _unitOfWork.UsrBuyServiceDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrBuyServiceDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrBuyServiceDet.IsActive = false;
            UsrBuyServiceDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrBuyServiceDets = await _unitOfWork.UsrBuyServiceDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrBuyServiceDetsDto = Mapper.Map(UsrBuyServiceDets);

            return OkResult(CustomMessage.DefaultMessage, UsrBuyServiceDetsDto.ToPagingAndSorting(query), UsrBuyServiceDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrBuyServiceDet = await _unitOfWork.UsrBuyServiceDetRepository.GetByIdAsync(id);

            if (UsrBuyServiceDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrBuyServiceDetDto = Mapper.Map(UsrBuyServiceDet);

            return OkResult( CustomMessage.DefaultMessage , UsrBuyServiceDetDto);

        }
    }
}
