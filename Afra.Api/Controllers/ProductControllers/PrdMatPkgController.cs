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

namespace Afra.Api.Controllers.PrdMatPkgControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdMatPkgController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdMatPkgController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdMatPkgCommand command)
        {
            command.Validate();

            var PrdMatPkgs = await _unitOfWork.PrdMatPkgRepository.FindAsync(c => c.Id == command.Id);

            if (PrdMatPkgs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdMatPkg = Mapper.Map(command);
            await _unitOfWork.PrdMatPkgRepository.AddAsync(newPrdMatPkg);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdMatPkgCommand command)
        {

            command.Validate();

            var PrdMatPkg = await _unitOfWork.PrdMatPkgRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdMatPkg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMatPkg = Mapper.Map(PrdMatPkg, command);
            PrdMatPkg.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdMatPkg = await _unitOfWork.PrdMatPkgRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdMatPkg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMatPkg.IsActive = false;
            PrdMatPkg.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdMatPkgs = await _unitOfWork.PrdMatPkgRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdMatPkgsDto = Mapper.Map(PrdMatPkgs);

            return OkResult(CustomMessage.DefaultMessage, PrdMatPkgsDto.ToPagingAndSorting(query), PrdMatPkgsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdMatPkg = await _unitOfWork.PrdMatPkgRepository.GetByIdAsync(id);

            if (PrdMatPkg is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdMatPkgDto = Mapper.Map(PrdMatPkg);

            return OkResult( CustomMessage.DefaultMessage , PrdMatPkgDto);

        }
    }
}
