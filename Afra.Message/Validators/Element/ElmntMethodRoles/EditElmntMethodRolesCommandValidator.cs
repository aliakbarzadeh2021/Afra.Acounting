using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditElmntMethodRolesCommandValidator : AbstractValidator<EditElmntMethodRolesCommand>
    {
        public EditElmntMethodRolesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
