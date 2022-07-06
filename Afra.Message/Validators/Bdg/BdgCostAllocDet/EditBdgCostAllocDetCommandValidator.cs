using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgCostAllocDetCommandValidator : AbstractValidator<EditBdgCostAllocDetCommand>
    {
        public EditBdgCostAllocDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
