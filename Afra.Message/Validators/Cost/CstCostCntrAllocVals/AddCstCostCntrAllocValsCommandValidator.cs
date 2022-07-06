using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrAllocValsCommandValidator : AbstractValidator<AddCstCostCntrAllocValsCommand>
    {
        public AddCstCostCntrAllocValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
