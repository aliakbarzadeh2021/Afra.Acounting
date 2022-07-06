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

namespace Afra.Api.Controllers.WebImagesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WebImagesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WebImagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWebImagesCommand command)
        {
            command.Validate();

            var WebImagess = await _unitOfWork.WebImagesRepository.FindAsync(c => c.Id == command.Id);

            if (WebImagess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWebImages = Mapper.Map(command);
            await _unitOfWork.WebImagesRepository.AddAsync(newWebImages);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWebImagesCommand command)
        {

            command.Validate();

            var WebImages = await _unitOfWork.WebImagesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WebImages == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebImages = Mapper.Map(WebImages, command);
            WebImages.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WebImages = await _unitOfWork.WebImagesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WebImages == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebImages.IsActive = false;
            WebImages.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WebImagess = await _unitOfWork.WebImagesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WebImagessDto = Mapper.Map(WebImagess);

            return OkResult(CustomMessage.DefaultMessage, WebImagessDto.ToPagingAndSorting(query), WebImagessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WebImages = await _unitOfWork.WebImagesRepository.GetByIdAsync(id);

            if (WebImages is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WebImagesDto = Mapper.Map(WebImages);

            return OkResult( CustomMessage.DefaultMessage , WebImagesDto);

        }
    }
}
