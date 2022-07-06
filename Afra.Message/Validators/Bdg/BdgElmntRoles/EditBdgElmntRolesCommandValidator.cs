using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgElmntRolesCommandValidator : AbstractValidator<EditBdgElmntRolesCommand>
    {
        public EditBdgElmntRolesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
