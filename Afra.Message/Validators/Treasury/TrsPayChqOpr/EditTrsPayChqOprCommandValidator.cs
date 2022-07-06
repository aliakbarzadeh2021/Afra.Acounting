using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsPayChqOprCommandValidator : AbstractValidator<EditTrsPayChqOprCommand>
    {
        public EditTrsPayChqOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
