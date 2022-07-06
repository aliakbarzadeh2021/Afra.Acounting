using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrAllocCommandValidator : AbstractValidator<AddCstCostCntrAllocCommand>
    {
        public AddCstCostCntrAllocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
