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

namespace Afra.Api.Controllers.GnrTablesInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrTablesInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrTablesInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrTablesInfCommand command)
        {
            command.Validate();

            var GnrTablesInfs = await _unitOfWork.GnrTablesInfRepository.FindAsync(c => c.Id == command.Id);

            if (GnrTablesInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrTablesInf = Mapper.Map(command);
            await _unitOfWork.GnrTablesInfRepository.AddAsync(newGnrTablesInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrTablesInfCommand command)
        {

            command.Validate();

            var GnrTablesInf = await _unitOfWork.GnrTablesInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrTablesInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTablesInf = Mapper.Map(GnrTablesInf, command);
            GnrTablesInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrTablesInf = await _unitOfWork.GnrTablesInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrTablesInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTablesInf.IsActive = false;
            GnrTablesInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrTablesInfs = await _unitOfWork.GnrTablesInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrTablesInfsDto = Mapper.Map(GnrTablesInfs);

            return OkResult(CustomMessage.DefaultMessage, GnrTablesInfsDto.ToPagingAndSorting(query), GnrTablesInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrTablesInf = await _unitOfWork.GnrTablesInfRepository.GetByIdAsync(id);

            if (GnrTablesInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrTablesInfDto = Mapper.Map(GnrTablesInf);

            return OkResult( CustomMessage.DefaultMessage , GnrTablesInfDto);

        }
    }
}
