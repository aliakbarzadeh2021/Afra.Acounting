using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrFormRepRelsCommandValidator : AbstractValidator<AddGnrFormRepRelsCommand>
    {
        public AddGnrFormRepRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
