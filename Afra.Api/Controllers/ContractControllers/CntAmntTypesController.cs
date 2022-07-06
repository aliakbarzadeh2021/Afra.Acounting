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

namespace Afra.Api.Controllers.CntAmntTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAmntTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAmntTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAmntTypesCommand command)
        {
            command.Validate();

            var CntAmntTypess = await _unitOfWork.CntAmntTypesRepository.FindAsync(c => c.Id == command.Id);

            if (CntAmntTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAmntTypes = Mapper.Map(command);
            await _unitOfWork.CntAmntTypesRepository.AddAsync(newCntAmntTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAmntTypesCommand command)
        {

            command.Validate();

            var CntAmntTypes = await _unitOfWork.CntAmntTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAmntTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAmntTypes = Mapper.Map(CntAmntTypes, command);
            CntAmntTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAmntTypes = await _unitOfWork.CntAmntTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAmntTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAmntTypes.IsActive = false;
            CntAmntTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAmntTypess = await _unitOfWork.CntAmntTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAmntTypessDto = Mapper.Map(CntAmntTypess);

            return OkResult(CustomMessage.DefaultMessage, CntAmntTypessDto.ToPagingAndSorting(query), CntAmntTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAmntTypes = await _unitOfWork.CntAmntTypesRepository.GetByIdAsync(id);

            if (CntAmntTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAmntTypesDto = Mapper.Map(CntAmntTypes);

            return OkResult( CustomMessage.DefaultMessage , CntAmntTypesDto);

        }
    }
}
