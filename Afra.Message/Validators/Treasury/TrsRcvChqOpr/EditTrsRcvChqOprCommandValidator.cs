using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsRcvChqOprCommandValidator : AbstractValidator<EditTrsRcvChqOprCommand>
    {
        public EditTrsRcvChqOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
