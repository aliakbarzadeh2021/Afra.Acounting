using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditQcsMenLabsCommandValidator : AbstractValidator<EditQcsMenLabsCommand>
    {
        public EditQcsMenLabsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
