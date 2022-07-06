using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstCostCntrRoleValsCommandValidator : AbstractValidator<EditCstCostCntrRoleValsCommand>
    {
        public EditCstCostCntrRoleValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
