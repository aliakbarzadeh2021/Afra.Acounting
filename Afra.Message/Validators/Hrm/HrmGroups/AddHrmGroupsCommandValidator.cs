using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmGroupsCommandValidator : AbstractValidator<AddHrmGroupsCommand>
    {
        public AddHrmGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
