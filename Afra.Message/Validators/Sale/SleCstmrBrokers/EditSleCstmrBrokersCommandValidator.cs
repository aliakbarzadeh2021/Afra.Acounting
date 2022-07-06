using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleCstmrBrokersCommandValidator : AbstractValidator<EditSleCstmrBrokersCommand>
    {
        public EditSleCstmrBrokersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
