using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgCostAllocDetCommandValidator : AbstractValidator<AddBdgCostAllocDetCommand>
    {
        public AddBdgCostAllocDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
