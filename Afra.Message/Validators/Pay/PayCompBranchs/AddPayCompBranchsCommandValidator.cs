using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayCompBranchsCommandValidator : AbstractValidator<AddPayCompBranchsCommand>
    {
        public AddPayCompBranchsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
