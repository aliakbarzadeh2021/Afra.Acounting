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

namespace Afra.Api.Controllers.BdgProjDetInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjDetInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjDetInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjDetInfCommand command)
        {
            command.Validate();

            var BdgProjDetInfs = await _unitOfWork.BdgProjDetInfRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjDetInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjDetInf = Mapper.Map(command);
            await _unitOfWork.BdgProjDetInfRepository.AddAsync(newBdgProjDetInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjDetInfCommand command)
        {

            command.Validate();

            var BdgProjDetInf = await _unitOfWork.BdgProjDetInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjDetInf = Mapper.Map(BdgProjDetInf, command);
            BdgProjDetInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjDetInf = await _unitOfWork.BdgProjDetInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjDetInf.IsActive = false;
            BdgProjDetInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjDetInfs = await _unitOfWork.BdgProjDetInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjDetInfsDto = Mapper.Map(BdgProjDetInfs);

            return OkResult(CustomMessage.DefaultMessage, BdgProjDetInfsDto.ToPagingAndSorting(query), BdgProjDetInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjDetInf = await _unitOfWork.BdgProjDetInfRepository.GetByIdAsync(id);

            if (BdgProjDetInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjDetInfDto = Mapper.Map(BdgProjDetInf);

            return OkResult( CustomMessage.DefaultMessage , BdgProjDetInfDto);

        }
    }
}
