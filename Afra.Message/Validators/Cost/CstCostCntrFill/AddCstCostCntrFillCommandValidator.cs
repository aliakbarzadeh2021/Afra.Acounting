using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrFillCommandValidator : AbstractValidator<AddCstCostCntrFillCommand>
    {
        public AddCstCostCntrFillCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
