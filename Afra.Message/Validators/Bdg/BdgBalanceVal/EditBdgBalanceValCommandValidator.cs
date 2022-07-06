using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgBalanceValCommandValidator : AbstractValidator<EditBdgBalanceValCommand>
    {
        public EditBdgBalanceValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
