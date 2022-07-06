using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmPersSldrCommandValidator : AbstractValidator<AddHrmPersSldrCommand>
    {
        public AddHrmPersSldrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
