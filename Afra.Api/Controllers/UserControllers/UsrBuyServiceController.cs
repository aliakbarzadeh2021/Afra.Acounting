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

namespace Afra.Api.Controllers.UsrBuyServiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrBuyServiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrBuyServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrBuyServiceCommand command)
        {
            command.Validate();

            var UsrBuyServices = await _unitOfWork.UsrBuyServiceRepository.FindAsync(c => c.Id == command.Id);

            if (UsrBuyServices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrBuyService = Mapper.Map(command);
            await _unitOfWork.UsrBuyServiceRepository.AddAsync(newUsrBuyService);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrBuyServiceCommand command)
        {

            command.Validate();

            var UsrBuyService = await _unitOfWork.UsrBuyServiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrBuyService == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrBuyService = Mapper.Map(UsrBuyService, command);
            UsrBuyService.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrBuyService = await _unitOfWork.UsrBuyServiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrBuyService == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrBuyService.IsActive = false;
            UsrBuyService.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrBuyServices = await _unitOfWork.UsrBuyServiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrBuyServicesDto = Mapper.Map(UsrBuyServices);

            return OkResult(CustomMessage.DefaultMessage, UsrBuyServicesDto.ToPagingAndSorting(query), UsrBuyServicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrBuyService = await _unitOfWork.UsrBuyServiceRepository.GetByIdAsync(id);

            if (UsrBuyService is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrBuyServiceDto = Mapper.Map(UsrBuyService);

            return OkResult( CustomMessage.DefaultMessage , UsrBuyServiceDto);

        }
    }
}
