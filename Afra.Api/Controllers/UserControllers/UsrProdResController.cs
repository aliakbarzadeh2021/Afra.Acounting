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

namespace Afra.Api.Controllers.UsrProdResControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdResController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdResController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdResCommand command)
        {
            command.Validate();

            var UsrProdRess = await _unitOfWork.UsrProdResRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdRess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdRes = Mapper.Map(command);
            await _unitOfWork.UsrProdResRepository.AddAsync(newUsrProdRes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdResCommand command)
        {

            command.Validate();

            var UsrProdRes = await _unitOfWork.UsrProdResRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdRes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdRes = Mapper.Map(UsrProdRes, command);
            UsrProdRes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdRes = await _unitOfWork.UsrProdResRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdRes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdRes.IsActive = false;
            UsrProdRes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdRess = await _unitOfWork.UsrProdResRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdRessDto = Mapper.Map(UsrProdRess);

            return OkResult(CustomMessage.DefaultMessage, UsrProdRessDto.ToPagingAndSorting(query), UsrProdRessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdRes = await _unitOfWork.UsrProdResRepository.GetByIdAsync(id);

            if (UsrProdRes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdResDto = Mapper.Map(UsrProdRes);

            return OkResult( CustomMessage.DefaultMessage , UsrProdResDto);

        }
    }
}
