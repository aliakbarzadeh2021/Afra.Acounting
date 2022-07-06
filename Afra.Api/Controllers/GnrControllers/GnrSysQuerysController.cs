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

namespace Afra.Api.Controllers.GnrSysQuerysControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysQuerysController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysQuerysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysQuerysCommand command)
        {
            command.Validate();

            var GnrSysQueryss = await _unitOfWork.GnrSysQuerysRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysQueryss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysQuerys = Mapper.Map(command);
            await _unitOfWork.GnrSysQuerysRepository.AddAsync(newGnrSysQuerys);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysQuerysCommand command)
        {

            command.Validate();

            var GnrSysQuerys = await _unitOfWork.GnrSysQuerysRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysQuerys == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysQuerys = Mapper.Map(GnrSysQuerys, command);
            GnrSysQuerys.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysQuerys = await _unitOfWork.GnrSysQuerysRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysQuerys == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysQuerys.IsActive = false;
            GnrSysQuerys.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysQueryss = await _unitOfWork.GnrSysQuerysRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysQueryssDto = Mapper.Map(GnrSysQueryss);

            return OkResult(CustomMessage.DefaultMessage, GnrSysQueryssDto.ToPagingAndSorting(query), GnrSysQueryssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysQuerys = await _unitOfWork.GnrSysQuerysRepository.GetByIdAsync(id);

            if (GnrSysQuerys is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysQuerysDto = Mapper.Map(GnrSysQuerys);

            return OkResult( CustomMessage.DefaultMessage , GnrSysQuerysDto);

        }
    }
}
