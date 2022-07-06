using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstElmntRolesCommandValidator : AbstractValidator<AddCstElmntRolesCommand>
    {
        public AddCstElmntRolesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
