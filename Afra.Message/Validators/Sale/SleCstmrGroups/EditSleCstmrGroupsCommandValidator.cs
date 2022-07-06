using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleCstmrGroupsCommandValidator : AbstractValidator<EditSleCstmrGroupsCommand>
    {
        public EditSleCstmrGroupsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
