using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstCostCntrElmntRoleCommandValidator : AbstractValidator<EditCstCostCntrElmntRoleCommand>
    {
        public EditCstCostCntrElmntRoleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
