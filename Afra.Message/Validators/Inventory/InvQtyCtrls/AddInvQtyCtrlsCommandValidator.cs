using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvQtyCtrlsCommandValidator : AbstractValidator<AddInvQtyCtrlsCommand>
    {
        public AddInvQtyCtrlsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
