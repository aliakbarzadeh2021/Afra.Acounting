using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvQtPartRelsCommandValidator : AbstractValidator<AddInvQtPartRelsCommand>
    {
        public AddInvQtPartRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
