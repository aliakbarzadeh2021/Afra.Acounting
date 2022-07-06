using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstElmntRolesCommandValidator : AbstractValidator<EditCstElmntRolesCommand>
    {
        public EditCstElmntRolesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
