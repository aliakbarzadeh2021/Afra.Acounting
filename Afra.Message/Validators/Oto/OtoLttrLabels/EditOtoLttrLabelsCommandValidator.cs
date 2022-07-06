using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoLttrLabelsCommandValidator : AbstractValidator<EditOtoLttrLabelsCommand>
    {
        public EditOtoLttrLabelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
