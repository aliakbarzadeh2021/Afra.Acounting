using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstCostCntrAllocSValsCommandValidator : AbstractValidator<EditCstCostCntrAllocSValsCommand>
    {
        public EditCstCostCntrAllocSValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
