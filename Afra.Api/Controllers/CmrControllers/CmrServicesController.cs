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

namespace Afra.Api.Controllers.CmrServicesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrServicesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrServicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrServicesCommand command)
        {
            command.Validate();

            var CmrServicess = await _unitOfWork.CmrServicesRepository.FindAsync(c => c.Id == command.Id);

            if (CmrServicess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrServices = Mapper.Map(command);
            await _unitOfWork.CmrServicesRepository.AddAsync(newCmrServices);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrServicesCommand command)
        {

            command.Validate();

            var CmrServices = await _unitOfWork.CmrServicesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrServices == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrServices = Mapper.Map(CmrServices, command);
            CmrServices.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrServices = await _unitOfWork.CmrServicesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrServices == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrServices.IsActive = false;
            CmrServices.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrServicess = await _unitOfWork.CmrServicesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrServicessDto = Mapper.Map(CmrServicess);

            return OkResult(CustomMessage.DefaultMessage, CmrServicessDto.ToPagingAndSorting(query), CmrServicessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrServices = await _unitOfWork.CmrServicesRepository.GetByIdAsync(id);

            if (CmrServices is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrServicesDto = Mapper.Map(CmrServices);

            return OkResult( CustomMessage.DefaultMessage , CmrServicesDto);

        }
    }
}
