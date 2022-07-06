using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsPayHistoryCommandValidator : AbstractValidator<EditTrsPayHistoryCommand>
    {
        public EditTrsPayHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
