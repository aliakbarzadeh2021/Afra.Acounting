using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrRptGroupsCommandValidator : AbstractValidator<EditGnrRptGroupsCommand>
    {
        public EditGnrRptGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
