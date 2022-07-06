using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserRoleCommandValidator : AbstractValidator<EditGnrUserRoleCommand>
    {
        public EditGnrUserRoleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
