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

namespace Afra.Api.Controllers.CmrRegisterControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrRegisterController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrRegisterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrRegisterCommand command)
        {
            command.Validate();

            var CmrRegisters = await _unitOfWork.CmrRegisterRepository.FindAsync(c => c.Id == command.Id);

            if (CmrRegisters.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrRegister = Mapper.Map(command);
            await _unitOfWork.CmrRegisterRepository.AddAsync(newCmrRegister);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrRegisterCommand command)
        {

            command.Validate();

            var CmrRegister = await _unitOfWork.CmrRegisterRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrRegister == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRegister = Mapper.Map(CmrRegister, command);
            CmrRegister.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrRegister = await _unitOfWork.CmrRegisterRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrRegister == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRegister.IsActive = false;
            CmrRegister.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrRegisters = await _unitOfWork.CmrRegisterRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrRegistersDto = Mapper.Map(CmrRegisters);

            return OkResult(CustomMessage.DefaultMessage, CmrRegistersDto.ToPagingAndSorting(query), CmrRegistersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrRegister = await _unitOfWork.CmrRegisterRepository.GetByIdAsync(id);

            if (CmrRegister is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrRegisterDto = Mapper.Map(CmrRegister);

            return OkResult( CustomMessage.DefaultMessage , CmrRegisterDto);

        }
    }
}
