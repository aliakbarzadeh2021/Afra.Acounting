using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostAllocDetCommandValidator : AbstractValidator<AddCstCostAllocDetCommand>
    {
        public AddCstCostAllocDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
