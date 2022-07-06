using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsRcvHistoryCommandValidator : AbstractValidator<AddTrsRcvHistoryCommand>
    {
        public AddTrsRcvHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
