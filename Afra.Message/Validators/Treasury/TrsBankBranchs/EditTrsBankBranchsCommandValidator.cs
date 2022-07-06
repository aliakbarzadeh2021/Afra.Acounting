using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsBankBranchsCommandValidator : AbstractValidator<EditTrsBankBranchsCommand>
    {
        public EditTrsBankBranchsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
