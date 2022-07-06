using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgCostCntrAllocCommandValidator : AbstractValidator<AddBdgCostCntrAllocCommand>
    {
        public AddBdgCostCntrAllocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
