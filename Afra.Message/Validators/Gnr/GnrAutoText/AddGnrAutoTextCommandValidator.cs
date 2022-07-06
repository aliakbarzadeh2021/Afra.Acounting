using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrAutoTextCommandValidator : AbstractValidator<AddGnrAutoTextCommand>
    {
        public AddGnrAutoTextCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
