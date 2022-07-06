using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayCompBranchsCommandValidator : AbstractValidator<EditPayCompBranchsCommand>
    {
        public EditPayCompBranchsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
