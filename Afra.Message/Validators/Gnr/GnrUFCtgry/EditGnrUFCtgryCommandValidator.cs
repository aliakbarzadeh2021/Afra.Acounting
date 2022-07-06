using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUFCtgryCommandValidator : AbstractValidator<EditGnrUFCtgryCommand>
    {
        public EditGnrUFCtgryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
