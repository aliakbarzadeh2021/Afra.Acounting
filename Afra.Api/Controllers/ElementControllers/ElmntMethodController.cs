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

namespace Afra.Api.Controllers.ElmntMethodControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElmntMethodController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElmntMethodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElmntMethodCommand command)
        {
            command.Validate();

            var ElmntMethods = await _unitOfWork.ElmntMethodRepository.FindAsync(c => c.Id == command.Id);

            if (ElmntMethods.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElmntMethod = Mapper.Map(command);
            await _unitOfWork.ElmntMethodRepository.AddAsync(newElmntMethod);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElmntMethodCommand command)
        {

            command.Validate();

            var ElmntMethod = await _unitOfWork.ElmntMethodRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ElmntMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElmntMethod = Mapper.Map(ElmntMethod, command);
            ElmntMethod.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ElmntMethod = await _unitOfWork.ElmntMethodRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ElmntMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElmntMethod.IsActive = false;
            ElmntMethod.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ElmntMethods = await _unitOfWork.ElmntMethodRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElmntMethodsDto = Mapper.Map(ElmntMethods);

            return OkResult(CustomMessage.DefaultMessage, ElmntMethodsDto.ToPagingAndSorting(query), ElmntMethodsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ElmntMethod = await _unitOfWork.ElmntMethodRepository.GetByIdAsync(id);

            if (ElmntMethod is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElmntMethodDto = Mapper.Map(ElmntMethod);

            return OkResult( CustomMessage.DefaultMessage , ElmntMethodDto);

        }
    }
}
