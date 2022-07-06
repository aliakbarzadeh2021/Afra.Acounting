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

namespace Afra.Api.Controllers.CntAccVchTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAccVchTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAccVchTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAccVchTypesCommand command)
        {
            command.Validate();

            var CntAccVchTypess = await _unitOfWork.CntAccVchTypesRepository.FindAsync(c => c.Id == command.Id);

            if (CntAccVchTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAccVchTypes = Mapper.Map(command);
            await _unitOfWork.CntAccVchTypesRepository.AddAsync(newCntAccVchTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAccVchTypesCommand command)
        {

            command.Validate();

            var CntAccVchTypes = await _unitOfWork.CntAccVchTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAccVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAccVchTypes = Mapper.Map(CntAccVchTypes, command);
            CntAccVchTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAccVchTypes = await _unitOfWork.CntAccVchTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAccVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAccVchTypes.IsActive = false;
            CntAccVchTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAccVchTypess = await _unitOfWork.CntAccVchTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAccVchTypessDto = Mapper.Map(CntAccVchTypess);

            return OkResult(CustomMessage.DefaultMessage, CntAccVchTypessDto.ToPagingAndSorting(query), CntAccVchTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAccVchTypes = await _unitOfWork.CntAccVchTypesRepository.GetByIdAsync(id);

            if (CntAccVchTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAccVchTypesDto = Mapper.Map(CntAccVchTypes);

            return OkResult( CustomMessage.DefaultMessage , CntAccVchTypesDto);

        }
    }
}
