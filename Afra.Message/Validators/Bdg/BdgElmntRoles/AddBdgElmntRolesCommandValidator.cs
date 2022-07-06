using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgElmntRolesCommandValidator : AbstractValidator<AddBdgElmntRolesCommand>
    {
        public AddBdgElmntRolesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
