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

namespace Afra.Api.Controllers.CntFormFieldsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntFormFieldsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntFormFieldsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntFormFieldsCommand command)
        {
            command.Validate();

            var CntFormFieldss = await _unitOfWork.CntFormFieldsRepository.FindAsync(c => c.Id == command.Id);

            if (CntFormFieldss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntFormFields = Mapper.Map(command);
            await _unitOfWork.CntFormFieldsRepository.AddAsync(newCntFormFields);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntFormFieldsCommand command)
        {

            command.Validate();

            var CntFormFields = await _unitOfWork.CntFormFieldsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntFormFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntFormFields = Mapper.Map(CntFormFields, command);
            CntFormFields.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntFormFields = await _unitOfWork.CntFormFieldsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntFormFields == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntFormFields.IsActive = false;
            CntFormFields.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntFormFieldss = await _unitOfWork.CntFormFieldsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntFormFieldssDto = Mapper.Map(CntFormFieldss);

            return OkResult(CustomMessage.DefaultMessage, CntFormFieldssDto.ToPagingAndSorting(query), CntFormFieldssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntFormFields = await _unitOfWork.CntFormFieldsRepository.GetByIdAsync(id);

            if (CntFormFields is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntFormFieldsDto = Mapper.Map(CntFormFields);

            return OkResult( CustomMessage.DefaultMessage , CntFormFieldsDto);

        }
    }
}
