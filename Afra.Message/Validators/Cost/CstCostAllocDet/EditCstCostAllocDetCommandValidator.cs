using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstCostAllocDetCommandValidator : AbstractValidator<EditCstCostAllocDetCommand>
    {
        public EditCstCostAllocDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
