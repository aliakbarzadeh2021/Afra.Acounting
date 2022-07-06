using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoLttrLabelsCommandValidator : AbstractValidator<AddOtoLttrLabelsCommand>
    {
        public AddOtoLttrLabelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
