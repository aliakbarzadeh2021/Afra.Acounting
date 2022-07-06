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

namespace Afra.Api.Controllers.CstProductPackageControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstProductPackageController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstProductPackageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstProductPackageCommand command)
        {
            command.Validate();

            var CstProductPackages = await _unitOfWork.CstProductPackageRepository.FindAsync(c => c.Id == command.Id);

            if (CstProductPackages.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstProductPackage = Mapper.Map(command);
            await _unitOfWork.CstProductPackageRepository.AddAsync(newCstProductPackage);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstProductPackageCommand command)
        {

            command.Validate();

            var CstProductPackage = await _unitOfWork.CstProductPackageRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstProductPackage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductPackage = Mapper.Map(CstProductPackage, command);
            CstProductPackage.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstProductPackage = await _unitOfWork.CstProductPackageRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstProductPackage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductPackage.IsActive = false;
            CstProductPackage.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstProductPackages = await _unitOfWork.CstProductPackageRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstProductPackagesDto = Mapper.Map(CstProductPackages);

            return OkResult(CustomMessage.DefaultMessage, CstProductPackagesDto.ToPagingAndSorting(query), CstProductPackagesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstProductPackage = await _unitOfWork.CstProductPackageRepository.GetByIdAsync(id);

            if (CstProductPackage is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstProductPackageDto = Mapper.Map(CstProductPackage);

            return OkResult( CustomMessage.DefaultMessage , CstProductPackageDto);

        }
    }
}
