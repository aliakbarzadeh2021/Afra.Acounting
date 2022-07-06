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

namespace Afra.Api.Controllers.GnrUserFormDesignControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserFormDesignController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserFormDesignController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserFormDesignCommand command)
        {
            command.Validate();

            var GnrUserFormDesigns = await _unitOfWork.GnrUserFormDesignRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserFormDesigns.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserFormDesign = Mapper.Map(command);
            await _unitOfWork.GnrUserFormDesignRepository.AddAsync(newGnrUserFormDesign);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserFormDesignCommand command)
        {

            command.Validate();

            var GnrUserFormDesign = await _unitOfWork.GnrUserFormDesignRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserFormDesign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserFormDesign = Mapper.Map(GnrUserFormDesign, command);
            GnrUserFormDesign.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserFormDesign = await _unitOfWork.GnrUserFormDesignRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserFormDesign == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserFormDesign.IsActive = false;
            GnrUserFormDesign.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserFormDesigns = await _unitOfWork.GnrUserFormDesignRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserFormDesignsDto = Mapper.Map(GnrUserFormDesigns);

            return OkResult(CustomMessage.DefaultMessage, GnrUserFormDesignsDto.ToPagingAndSorting(query), GnrUserFormDesignsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserFormDesign = await _unitOfWork.GnrUserFormDesignRepository.GetByIdAsync(id);

            if (GnrUserFormDesign is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserFormDesignDto = Mapper.Map(GnrUserFormDesign);

            return OkResult( CustomMessage.DefaultMessage , GnrUserFormDesignDto);

        }
    }
}
