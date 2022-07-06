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

namespace Afra.Api.Controllers.AstPitchsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstPitchsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstPitchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstPitchsCommand command)
        {
            command.Validate();

            var AstPitchss = await _unitOfWork.AstPitchsRepository.FindAsync(c => c.Id == command.Id);

            if (AstPitchss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstPitchs = Mapper.Map(command);
            await _unitOfWork.AstPitchsRepository.AddAsync(newAstPitchs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstPitchsCommand command)
        {

            command.Validate();

            var AstPitchs = await _unitOfWork.AstPitchsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstPitchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstPitchs = Mapper.Map(AstPitchs, command);
            AstPitchs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstPitchs = await _unitOfWork.AstPitchsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstPitchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstPitchs.IsActive = false;
            AstPitchs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstPitchss = await _unitOfWork.AstPitchsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstPitchssDto = Mapper.Map(AstPitchss);

            return OkResult(CustomMessage.DefaultMessage, AstPitchssDto.ToPagingAndSorting(query), AstPitchssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstPitchs = await _unitOfWork.AstPitchsRepository.GetByIdAsync(id);

            if (AstPitchs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstPitchsDto = Mapper.Map(AstPitchs);

            return OkResult( CustomMessage.DefaultMessage , AstPitchsDto);

        }
    }
}
