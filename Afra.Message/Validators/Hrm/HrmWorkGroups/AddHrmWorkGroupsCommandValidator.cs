using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmWorkGroupsCommandValidator : AbstractValidator<AddHrmWorkGroupsCommand>
    {
        public AddHrmWorkGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
