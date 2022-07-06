using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankBranchsCommandValidator : AbstractValidator<AddTrsBankBranchsCommand>
    {
        public AddTrsBankBranchsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
