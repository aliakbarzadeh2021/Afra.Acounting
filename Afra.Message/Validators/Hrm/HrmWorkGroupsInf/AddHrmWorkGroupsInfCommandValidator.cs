using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmWorkGroupsInfCommandValidator : AbstractValidator<AddHrmWorkGroupsInfCommand>
    {
        public AddHrmWorkGroupsInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
