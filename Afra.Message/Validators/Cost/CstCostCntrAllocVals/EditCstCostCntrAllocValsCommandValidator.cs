using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstCostCntrAllocValsCommandValidator : AbstractValidator<EditCstCostCntrAllocValsCommand>
    {
        public EditCstCostCntrAllocValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
