using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankAccountsCommandValidator : AbstractValidator<AddTrsBankAccountsCommand>
    {
        public AddTrsBankAccountsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
