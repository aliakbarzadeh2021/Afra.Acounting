using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgCostCntrAllocCommandValidator : AbstractValidator<EditBdgCostCntrAllocCommand>
    {
        public EditBdgCostCntrAllocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
