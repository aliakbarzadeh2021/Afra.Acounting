using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsRcvHistoryCommandValidator : AbstractValidator<EditTrsRcvHistoryCommand>
    {
        public EditTrsRcvHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
