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

namespace Afra.Api.Controllers.SleServicesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleServicesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleServicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleServicesCommand command)
        {
            command.Validate();

            var SleServicess = await _unitOfWork.SleServicesRepository.FindAsync(c => c.Id == command.Id);

            if (SleServicess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleServices = Mapper.Map(command);
            await _unitOfWork.SleServicesRepository.AddAsync(newSleServices);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleServicesCommand command)
        {

            command.Validate();

            var SleServices = await _unitOfWork.SleServicesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleServices == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleServices = Mapper.Map(SleServices, command);
            SleServices.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleServices = await _unitOfWork.SleServicesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleServices == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleServices.IsActive = false;
            SleServices.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleServicess = await _unitOfWork.SleServicesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleServicessDto = Mapper.Map(SleServicess);

            return OkResult(CustomMessage.DefaultMessage, SleServicessDto.ToPagingAndSorting(query), SleServicessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleServices = await _unitOfWork.SleServicesRepository.GetByIdAsync(id);

            if (SleServices is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleServicesDto = Mapper.Map(SleServices);

            return OkResult( CustomMessage.DefaultMessage , SleServicesDto);

        }
    }
}
