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

namespace Afra.Api.Controllers.CrspndsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CrspndsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CrspndsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCrspndsCommand command)
        {
            command.Validate();

            var Crspndss = await _unitOfWork.CrspndsRepository.FindAsync(c => c.Id == command.Id);

            if (Crspndss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCrspnds = Mapper.Map(command);
            await _unitOfWork.CrspndsRepository.AddAsync(newCrspnds);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCrspndsCommand command)
        {

            command.Validate();

            var Crspnds = await _unitOfWork.CrspndsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Crspnds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Crspnds = Mapper.Map(Crspnds, command);
            Crspnds.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Crspnds = await _unitOfWork.CrspndsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Crspnds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Crspnds.IsActive = false;
            Crspnds.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Crspndss = await _unitOfWork.CrspndsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CrspndssDto = Mapper.Map(Crspndss);

            return OkResult(CustomMessage.DefaultMessage, CrspndssDto.ToPagingAndSorting(query), CrspndssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Crspnds = await _unitOfWork.CrspndsRepository.GetByIdAsync(id);

            if (Crspnds is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CrspndsDto = Mapper.Map(Crspnds);

            return OkResult( CustomMessage.DefaultMessage , CrspndsDto);

        }
    }
}
