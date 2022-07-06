using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsRcvBoredOprCommandValidator : AbstractValidator<EditTrsRcvBoredOprCommand>
    {
        public EditTrsRcvBoredOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
