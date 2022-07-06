using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrFormRepRelsCommandValidator : AbstractValidator<EditGnrFormRepRelsCommand>
    {
        public EditGnrFormRepRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
