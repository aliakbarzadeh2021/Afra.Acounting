using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserLabelsCommandValidator : AbstractValidator<EditGnrUserLabelsCommand>
    {
        public EditGnrUserLabelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
