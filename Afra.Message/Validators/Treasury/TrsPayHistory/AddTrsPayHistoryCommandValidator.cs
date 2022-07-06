using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsPayHistoryCommandValidator : AbstractValidator<AddTrsPayHistoryCommand>
    {
        public AddTrsPayHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
