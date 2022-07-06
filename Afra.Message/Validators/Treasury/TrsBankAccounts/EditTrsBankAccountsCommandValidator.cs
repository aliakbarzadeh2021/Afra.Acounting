using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsBankAccountsCommandValidator : AbstractValidator<EditTrsBankAccountsCommand>
    {
        public EditTrsBankAccountsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
