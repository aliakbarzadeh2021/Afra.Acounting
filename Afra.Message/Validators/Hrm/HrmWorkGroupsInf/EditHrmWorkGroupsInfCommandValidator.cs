using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmWorkGroupsInfCommandValidator : AbstractValidator<EditHrmWorkGroupsInfCommand>
    {
        public EditHrmWorkGroupsInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
