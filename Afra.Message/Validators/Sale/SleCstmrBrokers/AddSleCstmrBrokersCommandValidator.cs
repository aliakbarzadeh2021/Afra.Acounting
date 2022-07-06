using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleCstmrBrokersCommandValidator : AbstractValidator<AddSleCstmrBrokersCommand>
    {
        public AddSleCstmrBrokersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
