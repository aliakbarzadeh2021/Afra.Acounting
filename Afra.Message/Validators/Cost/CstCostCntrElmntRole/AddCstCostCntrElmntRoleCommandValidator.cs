using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrElmntRoleCommandValidator : AbstractValidator<AddCstCostCntrElmntRoleCommand>
    {
        public AddCstCostCntrElmntRoleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
