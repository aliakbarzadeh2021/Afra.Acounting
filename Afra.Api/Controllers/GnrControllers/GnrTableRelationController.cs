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

namespace Afra.Api.Controllers.GnrTableRelationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrTableRelationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrTableRelationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrTableRelationCommand command)
        {
            command.Validate();

            var GnrTableRelations = await _unitOfWork.GnrTableRelationRepository.FindAsync(c => c.Id == command.Id);

            if (GnrTableRelations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrTableRelation = Mapper.Map(command);
            await _unitOfWork.GnrTableRelationRepository.AddAsync(newGnrTableRelation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrTableRelationCommand command)
        {

            command.Validate();

            var GnrTableRelation = await _unitOfWork.GnrTableRelationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrTableRelation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTableRelation = Mapper.Map(GnrTableRelation, command);
            GnrTableRelation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrTableRelation = await _unitOfWork.GnrTableRelationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrTableRelation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTableRelation.IsActive = false;
            GnrTableRelation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrTableRelations = await _unitOfWork.GnrTableRelationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrTableRelationsDto = Mapper.Map(GnrTableRelations);

            return OkResult(CustomMessage.DefaultMessage, GnrTableRelationsDto.ToPagingAndSorting(query), GnrTableRelationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrTableRelation = await _unitOfWork.GnrTableRelationRepository.GetByIdAsync(id);

            if (GnrTableRelation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrTableRelationDto = Mapper.Map(GnrTableRelation);

            return OkResult( CustomMessage.DefaultMessage , GnrTableRelationDto);

        }
    }
}
